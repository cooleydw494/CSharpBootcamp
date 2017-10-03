using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_34
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentManager<Document> docManager = new DocumentManager<Document>();

            docManager.AddDocument(new Document("Harry Potter", "J.K. Rowling"));
            docManager.AddDocument(new Document("2k leagues under the sea", "Jules Verne"));
            docManager.AddDocument(new Document("Lord of the Flies", "William Golding"));
            docManager.AddDocument(new Document("Catcher in the Rye", "J.D. Salinger"));

            docManager.DisplayAllDocuments();

            if (docManager.IsDocumentAvailable)
            {
                Console.WriteLine(docManager.GetDocument());
            }
        }
    }
}
