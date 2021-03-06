using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Visitor.Demo2
{
    public class WavFile
    {
        private List<Segment> segments = new List<Segment>();

        public static WavFile Read(String fileName)
        {
            // Simulate reading a wav file and building the segments
            var wavFile = new WavFile();
            wavFile.segments.Add(new FormatSegment());
            wavFile.segments.Add(new FactSegment());
            wavFile.segments.Add(new FactSegment());
            wavFile.segments.Add(new FactSegment());

            return wavFile;
        }

        public void applyFilter(IAudioFilter filter)
        {
            foreach (var segment in segments)
                segment.ApplyFilter(filter);
        }
    }
}
