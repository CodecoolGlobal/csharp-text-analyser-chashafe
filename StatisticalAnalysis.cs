using System;
using System.Collections;
using System.Collections.Generic;

namespace csharp_text_analyser_chashafe
{
    class StatisticalAnalysis
    {
        Dictionary<string, int> WordStats;
        Iterator localIterator;
        ISet<string> ExampleSet;

        // public int Count => throw new NotImplementedException();

        // public bool IsReadOnly => throw new NotImplementedException();

        /* ----- constructor -----*/
        public StatisticalAnalysis(Iterator Iter) // jak odróżnić Iterator z WordIterator i CharIterator?
        {
            this.localIterator = Iter;
            // localIterator = WordIterator.MoveNext();
            WordStats = new Dictionary<string, int>();
            ExampleSet = new HashSet<string>();
        }

        /* --- methods ------ */
        void AddLocalIteratorToWordStats()
        {
            foreach (KeyValuePair<string, int> kv in WordStats)
            {
                if (kv.Key == localIterator.MoveNext())
                {
                    WordStats.Add(localIterator.MoveNext(), WordStats[localIterator.MoveNext()] + 1);
                }
                WordStats.Add(localIterator.MoveNext(), 1);
                System.Console.WriteLine("test");
            }
        }
        int CountOf(params string[] elems)  // jak odróżnić char od string?
        {
            if (elems.Length == 1)
            {
                return 1;
            }
            return elems.Length;
        }
        int DictionarySize() => WordStats.Count;
        int Size() => localIterator.ToString().Split().Length; // raczej wordy niż chary
        ISet<string> OccurMoreThan(int _n_)
        {
            foreach (KeyValuePair<string, int> kv in WordStats)
            {
                if (kv.Value >= _n_)
                ExampleSet.Add(kv.Key);
            }
            return ExampleSet;
        }
    }

}