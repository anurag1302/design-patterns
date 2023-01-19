namespace SimpleFactoryPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IDocument document = DocumentFactory.CreateDocument("PDF");
            document.Save();
            document.Open();

            Console.ReadLine();
        }
    }
}