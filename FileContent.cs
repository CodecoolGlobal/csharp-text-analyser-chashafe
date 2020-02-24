namespace csharp_text_analyser_chashafe
{
    class FileContent : IterableText
    {
        string FileContent;
        Iterator Chariterator()
        {
            
        }

        Iterator Worditerator()
        {

        }
        string GetFileName()
        {
            return "";
        }
        public static void ReadFile() // get sth from file, LINE by LINE
        {
            string text = System.IO.File.ReadAllText(@"Results.txt");
            System.Console.WriteLine("Content is:\n{0}", text);
        }
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