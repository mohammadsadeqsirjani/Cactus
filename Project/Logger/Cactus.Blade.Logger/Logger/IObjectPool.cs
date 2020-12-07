namespace Cactus.Blade.Logger
{
    /// <summary>
    /// Generic implementation of object pooling pattern
    /// </summary>
    /// <typeparam name="T">The type of object in pool</typeparam>
    internal interface IObjectPool<T> where T : class
    {
        /// <summary>
        /// Produces an instance of <typeparamref name="T"/>.
        /// </summary>
        /// <remarks>
        /// Search strategy is a simple linear probing which is chosen for it cache-friendliness.
        /// Note that Free will try to store recycled objects close to the start thus statistically 
        /// reducing how far we will typically search.
        /// </remarks>
        T Allocate();

        /// <summary>
        /// Return specified object to the pool.
        /// </summary>
        /// <remarks>
        /// Search strategy is a simple linear probing which is chosen for it cache-friendliness.
        /// Note that Free will try to store recycled objects close to the start thus statistically 
        /// reducing how far we will typically search in <see cref="Allocate"/>.
        /// </remarks>
        void Free(T obj);

        /// <summary>
        /// Remove all pooled objects from object pool.
        /// </summary>
        void Clear();
    }
}