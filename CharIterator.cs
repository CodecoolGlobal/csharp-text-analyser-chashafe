namespace csharp_text_analyser_chashafe
{
    public class CharIterator : Iterator
    {
        int filecontentLength;
        int index = -1;
        string localContent;

        /* ----- constructors -----*/ 
        public CharIterator(FileContent filecontent) 
        {
            localContent = filecontent.ToString();
            filecontentLength = localContent.Length;
        }
        public CharIterator() {}

        /* ----- methods -----*/ 
        public bool HasNext()
        {
            index = index + 1;
            if (index < localContent.Length)
            {
                return true;
            }
            return false;
        }
        public string MoveNext()
        {
            return localContent[index].ToString();
        }
        public void Remove(){}
    }    
}