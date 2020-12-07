using System;
using System.Threading;

namespace Cactus.Blade.Logger
{
    /// <summary>
    /// Generic implementation of object pooling pattern with predefined pool size limit. 
    /// </summary>
    /// <remarks>
    /// Notes: 
    /// 1) it is not the goal to keep all returned objects. Pool is not meant for storage. If there
    ///    is no space in the pool, extra returned objects will be dropped.
    /// 
    /// 2) it is implied that if object was obtained from a pool, the caller will return it back in
    ///    a relatively short time. Keeping checked out objects for long durations is ok, but 
    ///    reduces usefulness of pooling. Just new up your own.
    /// 
    /// Not returning objects to the pool in not detrimental to the pool's work, but is a bad practice. 
    /// Rationale: 
    ///    If there is no intent for reusing the object, do not use pool - just use "new". 
    /// </remarks>
    internal class ObjectPool<T> : IObjectPool<T> where T : class
    {
        private struct Element
        {
            internal T Value;
        }

        /// <remarks>
        /// Not using System.Func{T} because this file is linked into the (debugger) Formatter,
        /// which does not have that type (since it compiles against .NET 2.0).
        /// </remarks>
        internal delegate T Factory();

        private T _firstItem;
        private readonly Element[] _items;

        private readonly Factory _factory;

        internal ObjectPool(Factory factory)
            : this(factory, Environment.ProcessorCount * 2)
        { }

        internal ObjectPool(Factory factory, int size)
        {
            _factory = factory;
            _items = new Element[size - 1];
        }

        private T CreateInstance()
        {
            var instance = _factory();
            return instance;
        }

        /// <summary>
        /// Produces an instance.
        /// </summary>
        /// <remarks>
        /// Search strategy is a simple linear probing which is chosen for it cache-friendliness.
        /// Note that Free will try to store recycled objects close to the start thus statistically 
        /// reducing how far we will typically search.
        /// </remarks>
        public T Allocate()
        {
            var instance = _firstItem;
            if (instance == null || instance != Interlocked.CompareExchange(ref _firstItem, null, instance))
                instance = AllocateSlow();

            return instance;
        }

        private T AllocateSlow()
        {
            var items = _items;

            for (var i = 0; i < items.Length; i++)
            {
                var inst = items[i].Value;
                if (inst == null)
                    continue;

                if (inst == Interlocked.CompareExchange(ref items[i].Value, null, inst))
                    return inst;
            }

            return CreateInstance();
        }

        /// <summary>
        /// Returns objects to the pool.
        /// </summary>
        /// <remarks>
        /// Search strategy is a simple linear probing which is chosen for it cache-friendliness.
        /// Note that Free will try to store recycled objects close to the start thus statistically 
        /// reducing how far we will typically search in Allocate.
        /// </remarks>
        public void Free(T obj)
        {
            if (_firstItem == null)
            {
                _firstItem = obj;
            }
            else
            {
                FreeSlow(obj);
            }
        }

        private void FreeSlow(T obj)
        {
            var items = _items;
            for (var i = 0; i < items.Length; i++)
            {
                if (items[i].Value != null) continue;

                items[i].Value = obj;
                break;
            }
        }

        /// <summary>
        /// Remove all pooled objects from object pool.
        /// </summary>
        public void Clear()
        {
            _firstItem = null;
            for (var i = 0; i < _items.Length; i++)
                _items[i].Value = null;
        }
    }
}
