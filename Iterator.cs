using System.Collections;

namespace csharp_text_analyser_chashafe
{
    public interface Iterator
    {
        bool HasNext();
        string MoveNext();
        void Remove();
    }    
}