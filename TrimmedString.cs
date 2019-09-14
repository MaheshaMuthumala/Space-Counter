using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Trim_Words{

    class TrimmedString{

        public void FinalString(string str){

            //string input;

            string trim = Regex.Replace( str, @"\s", "" );

            Console.WriteLine("Trimmed String: " + trim);
        }
    }
}