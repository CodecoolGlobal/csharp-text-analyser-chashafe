namespace csharp_text_analyser_chashafe
{
    public class WordIterator : Iterator
    {
        int filecontentLength; // = new FileContent().GetTextLength(); // jak się pozbyć?
        int index = 0;
        string word;
        FileContent localContent; // to jest kluczowem żeby pozbyć się bezparametrycznego konstruktora


        /* ----- constructors -----*/ 
        public WordIterator(FileContent fileContent)
        {
            // localContent = fileContent.ToString();
            this.localContent = fileContent;
        } 
        // public WordIterator() { }

        /* ----- methods -----*/ 
        public bool HasNext()
        {
            this.filecontentLength = this.localContent.ToString().Length;            
            // this.index = index + 1;
            return (this.index < filecontentLength) ? true : false;
        }
        public string MoveNext()
        {
            char[] separs = {' ', ',', '-'};
            word = this.localContent.fileContent.Split(separs, System.StringSplitOptions.RemoveEmptyEntries)[index];
            // word = new FileContent().GetWord(index);
            return word;
        }
        public void IncreaseIndex()
        {
            this.index += 1;
        }
        public void Remove()
        {/* 
        analogiczny problem to CharIterator
        */
        }
        public void costam()
        {
            char[] separs = {' ', ',', '-'};
            var sth = this.localContent.fileContent.Split(separs, System.StringSplitOptions.RemoveEmptyEntries)[index];
        }
    }
}