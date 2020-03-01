using System;
using System.Collections.Generic;

namespace csharp_text_analyser_chashafe
{
    class view
    {
        void Print(string text)        
        {
            System.Console.WriteLine(text);
        }
        void Print(List<string> list)
        {
            System.Console.WriteLine(list.ToString());
        }
        void Print(Dictionary<string,int> dct, int integ )
        {
            foreach(KeyValuePair<string,int> kv in dct)
            {
                System.Console.WriteLine("{0}, {1}, {2}", integ, kv.Key, kv.Value);
            }
        }
    }
}