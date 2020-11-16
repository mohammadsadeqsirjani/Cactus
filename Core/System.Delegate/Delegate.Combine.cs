namespace Core.System.Delegate
{
    public static partial class Extension
    {
        /// <summary>
        ///     Concatenates the invocation lists of two delegates.
        /// </summary>
        /// <param name="a">The delegate whose invocation list comes first.</param>
        /// <param name="b">The delegate whose invocation list comes last.</param>
        /// ###
        /// <returns>
        ///     A new delegate with an invocation list that concatenates the invocation lists of  and  in that order. Returns
        ///     if  is null, returns  if  is a null reference, and returns a null reference if both  and  are null references.
        /// </returns>
        public static global::System.Delegate Combine(this global::System.Delegate a, global::System.Delegate b)
        {
            return global::System.Delegate.Combine(a, b);
        }
    }
}
