namespace csharp_text_analyser_chashafe
{
    public class WordIterator : Iterator
    {
        int filecontentLength = new FileContent().GetTextLength();
        static int index = -1;
        string word, localContent;

        /* ----- constructors -----*/ 
        public WordIterator(FileContent fileContent)
        {
            localContent = fileContent.ToString();
        } 
        // public WordIterator() { }

        /* ----- methods -----*/ 
        public bool HasNext()
        {            
            index = index + 1;
            return (index < filecontentLength) ? true : false;
        }
        public string MoveNext()
        {
            word = new FileContent().GetWord(index);
            return word;
        }
        public void Remove()
        {/* 
        analogiczny problem to CharIterator
        */
        }
    }
}