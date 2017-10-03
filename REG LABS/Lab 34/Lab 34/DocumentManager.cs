using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_34
{
    class DocumentManager<TDocument> where TDocument : IDocument
    {
        private readonly Queue<TDocument> idocuments = new Queue<TDocument>();

        public bool IsDocumentAvailable { get { return idocuments.Count > 0; } }

		public void AddDocument(TDocument idocument)
		{
            lock (this)
            {
                idocuments.Enqueue(idocument);
            }
		}

        public void DisplayAllDocuments()
        {
            foreach (TDocument doc in idocuments)
            {
                Console.WriteLine($"{doc.Title} by {doc.Author}");
            }
        }

        public TDocument GetDocument()
        {
            TDocument doc = default(TDocument);
            lock (this)
            {
                doc = idocuments.Dequeue();
            }
            return doc;
        }
    }
}
