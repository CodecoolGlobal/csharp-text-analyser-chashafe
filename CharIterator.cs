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
        // public CharIterator() {}

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
        public void Remove()
        { 
            /* 
            zamierzałem napisać tutaj coś, co usuwa zwrócony w MoveNext() znak,
            ale jeśli będę ciąć localContent, to (ponieważ localContetnLegnth jest 
            liczona w konstruktorze) w pewnym momencie wykrzaczy się, ponieważ 
            ponieważ nie będzie już localContent a index będzie daleko od osiągnięcia wartości
            maksymalnej localContentLength
            Stąd nie jest to tutaj rozpisane 
            */
        }
    }    
}