using System.Collections.Generic;

namespace RenameFiles
{
    public class WhatToFix
    {
        public static IDictionary<char, char> Fixes()
        {
            return new Dictionary<char, char>
            {
                { '¢', 'o' },
                { '‚', 'e' },
                { '‡', 'c' },
                { 'Æ', 'a' },
                { 'µ', 'a' },
                { 'é', 'u' },
                { 'ˆ', 'e' },
                { 'ä', 'o' },
                { '¡', 'i' }
            };
        }
    }
}
