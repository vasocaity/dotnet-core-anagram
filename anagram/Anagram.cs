using System;
using System.Linq;

namespace anagram
{
    
    public class Aangram
    {
        public bool checkAnagram(string[] strings, string searchString)
        {
            char[] searchStringArray = searchString.ToCharArray();

            for (int j = 0; j < searchStringArray.Length; j++)
            {
                // Search for the first occurrence of the duplicated value.
                int index = Array.IndexOf(strings, searchStringArray[j].ToString());
                if (index < 0)
                {
                    return false;
                }
                else
                {
                    // remove a[index] if searchString[j] == a[index] 
                    strings = strings.Where(w => w != strings[index]).ToArray();
                }
            }
            return true;
        }
    }
}