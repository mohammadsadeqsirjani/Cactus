using Cactus.Blade.Caching.Helper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Cactus.Blade.Caching
{
    /// <summary>
    /// A simple and lightweight tool for persisting data in dotnet (core) apps.
    /// </summary>
    public class Caching : IDisposable
    {
        /// <summary>
        /// Gets the number of elements contained in the Caching.
        /// </summary>
        public int Count => Storage.Count;

        /// <summary>
        /// Configurable behaviour for this Caching instance.
        /// </summary>
        private readonly ICachingConfiguration _config;

        /// <summary>
        /// User-provided encryption key, used for encrypting/decrypting values.
        /// </summary>
        private readonly string _encryptionKey;

        /// <summary>
        /// Most current actual, in-memory state representation of the Caching.
        /// </summary>
        private Dictionary<string, string> Storage { get; set; } = new Dictionary<string, string>();

        private readonly object _writeLock = new object();

        public Caching() : this(new CachingConfiguration(), string.Empty)
        {
        }

        public Caching(ICachingConfiguration configuration) : this(configuration, string.Empty)
        {
        }

        public Caching(ICachingConfiguration configuration, string encryptionKey)
        {
            _config = configuration ?? throw new ArgumentNullException(nameof(configuration));
            _encryptionKey = encryptionKey;

            if (_config.EnableEncryption)
            {
                if (string.IsNullOrEmpty(encryptionKey))
                    throw new ArgumentNullException(nameof(encryptionKey),
                        "When EnableEncryption is enabled, an encryptionKey is required when initializing the Caching.");
                _encryptionKey = encryptionKey;
            }

            if (_config.AutoLoad) Load();
        }

        /// <summary>
        /// Clears the in-memory contents of the Caching, but leaves any persisted state on disk intact.
        /// </summary>
        /// <remarks>
        /// Use the Destroy method to delete the persisted file on disk.
        /// </remarks>
        public void Clear() => Storage.Clear();

        /// <summary>
        /// Deletes the persisted file on disk, if it exists, but keeps the in-memory data intact.
        /// </summary>
        /// <remarks>
        /// Use the Clear method to clear only the in-memory contents.
        /// </remarks>
        public void Destroy()
        {
            var filepath = FileHelpers.GetLocalStoreFilePath(_config.Filename);
            if (File.Exists(filepath))
                File.Delete(FileHelpers.GetLocalStoreFilePath(_config.Filename));
        }

        /// <summary>
        /// Determines whether this Caching instance contains the specified key.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool Exists(string key) => Storage.ContainsKey(key: key);

        /// <summary>
        /// Gets an object from the Caching, without knowing its type.
        /// </summary>
        /// <param name="key">Unique key, as used when the object was stored.</param>
        public object Get(string key) => Get<object>(key);

        /// <summary>
        /// Gets a strong typed object from the Caching.
        /// </summary>
        /// <param name="key">Unique key, as used when the object was stored.</param>
        public T Get<T>(string key)
        {
            var succeeded = Storage.TryGetValue(key, out string raw);
            if (!succeeded) throw new ArgumentNullException($"Could not find key '{key}' in the Caching.");

            if (_config.EnableEncryption)
                raw = CryptographyHelpers.Decrypt(_encryptionKey, _config.EncryptionSalt, raw);

            return JsonConvert.DeserializeObject<T>(raw);
        }

        /// <summary>
        /// Gets a collection containing all the keys in the Caching.
        /// </summary>
        public IReadOnlyCollection<string> Keys() => Storage.Keys.OrderBy(x => x).ToList();

        /// <summary>
        /// Loads the persisted state from disk into memory, overriding the current memory instance.
        /// </summary>
        /// <remarks>
        /// Simply doesn't do anything if the file is not found on disk.
        /// </remarks>
        public void Load()
        {
            if (!File.Exists(FileHelpers.GetLocalStoreFilePath(_config.Filename))) return;

            var serializedContent = File.ReadAllText(FileHelpers.GetLocalStoreFilePath(_config.Filename));

            if (string.IsNullOrEmpty(serializedContent)) return;

            Storage.Clear();
            Storage = JsonConvert.DeserializeObject<Dictionary<string, string>>(serializedContent);
        }

        /// <summary>
        /// Stores an object into the Caching.
        /// </summary>
        /// <param name="key">Unique key, can be any string, used for retrieving it later.</param>
        /// <param name="instance"></param>
        public void Store<T>(string key, T instance)
        {
            if (string.IsNullOrEmpty(key)) throw new ArgumentNullException(nameof(key));
            if (instance == null) throw new ArgumentNullException(nameof(instance));

            var value = JsonConvert.SerializeObject(instance);

            if (Storage.Keys.Contains(key))
                Storage.Remove(key);

            if (_config.EnableEncryption)
                value = CryptographyHelpers.Encrypt(_encryptionKey, _config.EncryptionSalt, value);

            Storage.Add(key, value);
        }

        /// <summary T=", whilst also passing along an optional WHERE-clause.">
        /// Syntax sugar that transforms the response to an IEnumerable
        /// </summary>
        public IEnumerable<T> Query<T>(string key, Func<T, bool> predicate = null!)
        {
            var collection = Get<IEnumerable<T>>(key);

            return collection.Where(predicate);
        }

        /// <summary>
        /// Persists the in-memory store to disk.
        /// </summary>
        public void Persist()
        {
            var serialized = JsonConvert.SerializeObject(Storage, Newtonsoft.Json.Formatting.Indented);

            var writeMode = File.Exists(FileHelpers.GetLocalStoreFilePath(_config.Filename))
                ? FileMode.Truncate
                : FileMode.Create;

            lock (_writeLock)
            {
                using var fileStream = new FileStream(FileHelpers.GetLocalStoreFilePath(_config.Filename),
                    writeMode,
                    FileAccess.Write);
                using var writer = new StreamWriter(fileStream);
                writer.Write(serialized);
            }
        }

        public void Dispose()
        {
            if (_config.AutoSave) Persist();
        }
    }
}
