using System;
using System.Collections.Generic;

namespace csharp_text_analyser_chashafe
{
    class StatisticalAnalysis
    {
        Dictionary<string, int> WordStats; 
        string localIterator;

        /* ----- constructor -----*/
        public StatisticalAnalysis(Iterator WordIterator) // jak odróżnić Iterator z WordIterator i CharIterator?
        {
            localIterator = WordIterator.MoveNext();
            WordStats = new Dictionary<string, int>();
        } 

        /* --- methods ------ */ 
        void AddLocalIteratorToWordStats()
        {
            foreach (KeyValuePair<string, int> kv in WordStats)
            {
                if (kv.Key == localIterator)
                {
                    WordStats.Add(localIterator, WordStats[localIterator]+1);
                }
                WordStats.Add(localIterator, 1);
            }
        }
        int CountOf(params string[] elems)
        {
            return 1;
        }
        int DictionarySize() => WordStats.Count;
        
        int Size()
        {
            return 1;
        }
        // ISet <string> OccurMoreThan(Integer _n_)
        // {
        //     return ISet<string>;
        // }
    }
    
}