namespace csharp_text_analyser_chashafe
{
    public class CharIterator : Iterator
    {
        int filecontentLength;
        int index = 0;
        FileContent localContent;

        /* ----- constructors -----*/ 
   
        public CharIterator(FileContent filecontent) 
        {
            this.localContent = filecontent;
        }
        // public CharIterator() {}

        /* ----- methods -----*/ 
        public bool HasNext()
        {
            this.filecontentLength = this.localContent.ToString().Length;
            return (index < filecontentLength) ? true : false;
        }
        public string MoveNext()
        {
            var s = this.localContent.ToString()[this.index];
            return s.ToString();            
        }
        public void IncreaseIndex()
        {
            this.index += 1;
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