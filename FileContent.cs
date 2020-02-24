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
    }
}