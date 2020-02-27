namespace csharp_text_analyser_chashafe
{
    public class FileContent : IterableText
    {

        /* ---ta klasa to kolekcja iteratorów ---*/
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
            Iterator u = new CharIterator(this); //rzutowanie??? ; jak przekazać object typu FileContent tutaj??
            while (u.HasNext())
            {
                u.MoveNext();
            }
            return u;
        }
        public Iterator WordIterator()
        {
            Iterator it = new WordIterator(this); // jak przekazać object typu FileContent tutaj??
            while (it.HasNext())
            {
                it.MoveNext();
            }
            return it;
        }
        internal string GetWord(int i)
        {
            char[] separators = {' ', ',', '-'};
            return fileContent.Split(separators, System.StringSplitOptions.RemoveEmptyEntries)[i];
        }
        internal int GetTextLength() => fileContent.Length;    
        
        // string GetFilename()
        // {
        //     fileName = System.Console.ReadLine();
        //     return fileName;
        // }
    }
}