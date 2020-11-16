using System;
using System.Collections.Generic;
using System.Linq;

public static partial class Extension
{
    /// <summary>
    ///     Enumerates from @this to toCharacter.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="toCharacter">to character.</param>
    /// <returns>An enumerator that allows foreach to be used to process @this to toCharacter.</returns>
    public static IEnumerable<char> To(this char @this, char toCharacter)
    {
        var reverseRequired = (@this > toCharacter);

        var first = reverseRequired ? toCharacter : @this;
        var last = reverseRequired ? @this : toCharacter;

        var result = Enumerable.Range(first, last - first + 1).Select(charCode => (char)charCode);

        if (reverseRequired) result = result.Reverse();


        return result;
    }
}