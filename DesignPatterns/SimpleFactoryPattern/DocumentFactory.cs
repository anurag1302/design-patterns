namespace SimpleFactoryPattern
{
    public static class DocumentFactory
    {
        private static Dictionary<string, IDocument> container = new Dictionary<string, IDocument>();

        static DocumentFactory()
        {
            container.Add("PDF", new PdfDocument());
            container.Add("Word", new WordDocument());
        }

        public static IDocument CreateDocument(string type)
        {
            // First Way - IF ELSE BLOCKS
            //if (type == "PDF")
            //{
            //    return new PdfDocument();
            //}
            //else if (type == "Word")
            //{
            //    return new WordDocument();
            //}
            //else
            //{
            //    throw new ArgumentException("Invalid document type");
            //}

            //Second Way - USAGE OF DICTIONARY
            return container[type].Clone();
        }
    }
}