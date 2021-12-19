using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3_20_Dek
{
    public static class Extension
    {

        public static void Custom(this string st, char a )
        {
            StringBuilder str = new StringBuilder(st);
            
            for (int i = 0; i < str.Length; i++)
            {

                if (str[i] == a)
                {

                    Console.WriteLine("yes");
                    return;
                }
                
              
            }
            Console.WriteLine("no");

        }
    }
}
