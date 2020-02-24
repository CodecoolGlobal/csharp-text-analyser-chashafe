namespace csharp_text_analyser_chashafe
{
    public interface IterableText
    {
        Iterator CharIterator();
        Iterator WordIterator();
    }
}