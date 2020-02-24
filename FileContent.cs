namespace csharp_text_analyser_chashafe
{
    public class FileContent : IterableText
    {
        string sth;
        public FileContent(string sth) {
            this.sth = sth;
        }
        public Iterator CharIterator() 
        {

            Iterator Char_sth;
            return Char_sth;
        }
        public Iterator WordIterator()
        {
            Iterator Word_sth;
            return Word_sth;
        }
        string GetFilename()
        {
            var sth = System.Console.ReadLine();
            return sth;
        }


    }
}