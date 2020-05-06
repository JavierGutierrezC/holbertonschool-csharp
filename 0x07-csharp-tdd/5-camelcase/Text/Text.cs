using System;
using System.Text.RegularExpressions;

namespace Text
{
     /// <summary>Str Class</summary>
    public class Str
    {
        /// <summary>Find number of words</summary>
        /// <param name="s">String of words.</param>
        /// <returns> number of words</returns>
        public static int CamelCase(string s)
        {
            if(s == "" || s == null)
            {
                return(0);
            }
            int cont = 1;
            for(int x = 0; x < s.Length; x++)
            {
                if(char.IsUpper(s[x]) == true)
                {
                    cont ++;
                }
                else
                {
                    continue;
                }
            }
            return(cont);
        }    
    }
}
