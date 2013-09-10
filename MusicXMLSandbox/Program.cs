using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using MusicXMLSharp;

namespace MusicXMLSandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            var sampleFile = "Cooleys.xml";
            var score = new Score();
            var scoreType = score.LoadFile(sampleFile);
            switch (scoreType)
            {
                    case ScoreType.Partwise:
                    break;
                    case ScoreType.Timewise:
                    break;
                    case ScoreType.NoScore:
                    throw new Exception("No Score Found in File");
                    break;
            }
        }
    }
}
