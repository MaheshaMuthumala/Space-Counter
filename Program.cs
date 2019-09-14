using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Trim_Words
{
    class Program
    {
        /*public static int SpaceCount(string str)
	    {   
        public static int SpaceCount(string str)
	{   
		int spaceCount = 0;
		string inputString;
		for (int i = 0;i < str.Length;i++)
			{
			  inputString = str.Substring(i,1);
			  if (inputString == " ")
					spaceCount++;
			}
		return spaceCount;
	    }*/
	}
        static void Main(string[] args)
        {
            string val;
            Console.Write("Enter String: ");
            val = Console.ReadLine();
            //Console.WriteLine(val);
            //string trim = Regex.Replace( val, @"\s", "" );
            //int strLength = val.Length;
            //int count = SpaceCount(val);

            StringLength strLength = new StringLength();
            strLength.LengthofString(val);

            SpaceCount count = new SpaceCount();
            count.CountofSpaces(val);

            TrimmedString trim = new TrimmedString();
            trim.FinalString(val);

            //Console.WriteLine("Lenth of the String: " + strLength);
            //Console.WriteLine("Number of Spaces:" + count);
            //Console.WriteLine("Trimmed String: " + trim);
            /*string trim = Regex.Replace( val, @"\s", "" );
            int strLength = val.Length;
            int count = SpaceCount(val);

            Console.WriteLine("Lenth of the String: " + strLength);
            Console.WriteLine("Number of Spaces:" + count);
            Console.WriteLine("Trimmed String: " + trim);*/
        }
    }
}
