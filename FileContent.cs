namespace csharp_text_analyser_chashafe
{
    public class FileContent : IterableText
    {
        string fileName 
        {
            get => fileName; 
            set => fileName = System.Console.ReadLine();
        }
        string fileContent;

        /* ---- constructors ----- */
        public FileContent(string fileName)
        {
            fileContent = System.IO.File.ReadAllText(fileName);
        }
        public FileContent(){}

        /* ---- methods ----- */
        public Iterator CharIterator()
        {
            Iterator u = new CharIterator(); //rzutowanie???
            while (u.HasNext())
            {
                u.MoveNext();
            }
            return u;
        }
        public Iterator WordIterator()
        {
            Iterator i = WordIterator();
            while (i.HasNext())
            {
                i.MoveNext();
            }
            return i;
        }
        internal string GetWord(int i) => fileContent.Split()[i];
        internal int GetTextLength() => fileContent.Length;    
        
        // string GetFilename()
        // {
        //     fileName = System.Console.ReadLine();
        //     return fileName;
        // }
    }
}