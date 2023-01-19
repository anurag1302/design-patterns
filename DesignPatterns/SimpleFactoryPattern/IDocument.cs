namespace SimpleFactoryPattern
{
    public interface IDocument
    {
        void Save();

        void Open();

        IDocument Clone();
    }
}