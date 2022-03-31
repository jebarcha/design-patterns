using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public class PdfDocumentBuilder : IPresentationBuilder
    {
        private PdfDocument _pdfDocument = new PdfDocument();
        public void AddSlide(Slide slide)
        {
            _pdfDocument.AddPage(slide.Text);
        }
        public PdfDocument GetPdfDocument() => _pdfDocument;
        
    }
}
