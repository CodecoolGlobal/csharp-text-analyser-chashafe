namespace csharp_text_analyser_chashafe
{
    class Chariterator : Iterator
    {
        string sth = "";
        public bool HasNext() => sth != "";
        
        public string MoveNext() => sth;
        public void Remove()
        {

        }

    }
}