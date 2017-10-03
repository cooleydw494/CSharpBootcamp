using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_34
{
    class Document : IDocument
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Document()
        {
        }

        public Document(string title, string author)
        {
            this.Title = title;
            this.Author = author;
        }
    }
}
