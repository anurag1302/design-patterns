namespace SimpleFactoryPattern
{
    public class PdfDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("PDF Document Open");
        }

        public void Save()
        {
            Console.WriteLine("PDF Document Save");
        }

        public IDocument Clone()
        {
            return (IDocument)MemberwiseClone();
        }
    }
}