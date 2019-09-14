using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Trim_Words{

    class SpaceCount{

        public void CountofSpaces(string str)
	    {   
		int spaceCount = 0;
		string inputString;
		for (int i = 0;i < str.Length;i++)
			{
			  inputString = str.Substring(i,1);
			  if (inputString == " ")
					spaceCount++;
			}
		Console.WriteLine("Number of Spaces:" + spaceCount);
	    }
    }
}