namespace SimpleFactoryPattern
{
    public class WordDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Word Document Open");
        }

        public void Save()
        {
            Console.WriteLine("Word Document Save");
        }

        public IDocument Clone()
        {
            return (IDocument)MemberwiseClone();
        }
    }
}