using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder.WithTheProblem
{
    public class Presentation
    {
        private List<Slide> _slides = new List<Slide>();
        public void AddSlide(Slide slide)
        {
            _slides.Add(slide);
        }

        public void Export(EnumPresentationFormat format)
        {
            if (format == EnumPresentationFormat.PDF)
            {
                var pdf = new PdfDocument();
                foreach (var slide in _slides)
                {
                    pdf.AddPage(slide.Text);
                }
            }
            else if (format == EnumPresentationFormat.MOVIE)
            {
                var movie = new Movie();
                foreach (var slide in _slides)
                {
                    movie.AddFrame(slide.Text, 5);
                }
            }
        }
    }
}
