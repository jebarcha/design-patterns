using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public class MovieBuilder : IPresentationBuilder
    {
        private Movie _movie = new Movie();
        public void AddSlide(Slide slide)
        {
            _movie.AddFrame(slide.Text, 3);
        }
        public Movie GetMovie() => _movie;
    }
}
