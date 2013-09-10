using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace MusicXMLSharp
{
    public class Score
    {
        public ScoreType LoadFile(string filePath)
        {
            var contents = System.IO.File.ReadAllText(filePath);
            return this.Load(contents);
        }
        public ScoreType Load(string musicXML)
        {
            var partwiseSerializer = new XmlSerializer(typeof(ScorePartwise));
            using (var reader = new StringReader(musicXML))
            {
                ScorePartwise = (ScorePartwise)partwiseSerializer.Deserialize(reader);
            }
            var timewiseSerializer = new XmlSerializer(typeof (ScoreTimewise));
            using (var reader = new StringReader(musicXML))
            {
                ScoreTimeWise = (ScoreTimewise)timewiseSerializer.Deserialize(reader);
            }
            if (ScorePartwise != null)
            {
                return ScoreType.Partwise;
            }
            if (ScoreTimeWise != null)
            {
                return ScoreType.Timewise;
            }
           
                return ScoreType.NoScore;
        }
        public ScorePartwise ScorePartwise { get; set; }
        public ScoreTimewise ScoreTimeWise { get; set; }
    }
    public enum ScoreType
    {
        Partwise,Timewise,NoScore

    }
}
