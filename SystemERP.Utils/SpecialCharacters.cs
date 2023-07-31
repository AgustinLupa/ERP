using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SystemERP.Utils
{
    public static class SpecialCharacters
    {
        public  static bool ContainsSpecialCharacters(string input)
        {
            string pattern = @"^[a-zA-Z0-9]*$";
           
            Regex regex = new Regex(pattern);
            
            return regex.IsMatch(input);
        }
    }
}
