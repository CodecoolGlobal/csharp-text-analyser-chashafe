namespace csharp_text_analyser_chashafe
{
    public class FileContent : IterableText
    {

        /* ---ta klasa to kolekcja iteratorów ---*/
        internal string fileName
        {
            get => fileName;
            // private set => fileName = System.Console.ReadLine();
        }
        internal string fileContent { get; private set; }


        /* ---- constructors ----- */
        public FileContent(string fileName)
        {
            // this.fileContent = System.IO.File.ReadAllText(fileName);
            this.fileContent = GetFile(fileName);
        }

        /* ---- methods ----- */
        public Iterator CharIterator()
        {
            Iterator newChariter = new CharIterator(this);
            return newChariter;
        }
        public Iterator WordIterator()
        {
            Iterator newWordIter = new WordIterator(this);
            return newWordIter;
        }
        internal string GetWord(int i)
        {
            char[] separators = { ' ', ',', '-' };
            return fileContent.Split(separators, System.StringSplitOptions.RemoveEmptyEntries)[i];
        }
        internal int GetTextLength() => fileContent.Length;

        string GetFile(string fileName)
        {
            if (fileName == null)
            {
                throw new System.ArgumentNullException("path");
            }
            if (fileName.Length == 0)
            {
                throw new System.ArgumentException("Argument_EmptyPath");
            }
            return System.IO.File.ReadAllText(fileName);
        }
        
    }
}