using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Visitor.Demo2.WithTheProblem
{
    public class Segment
    {
        public void ReduceNoise()
        {
            Console.WriteLine("Reduce noise");
        }

        public void AddReverb()
        {
            Console.WriteLine("Add reverb");
        }

        public void Normalize()
        {
            Console.WriteLine("Normalize");
        }
    }
}
