using System.Collections.Generic;

namespace ImageAnalyze
{
    public class AnalysisModel
    {
        public IList<Category> categories { get; set; }
        public object adult { get; set; }
        public IList<Tag> tags { get; set; }
        public Description description { get; set; }
        public string requestId { get; set; }
        public Metadata metadata { get; set; }
        public IList<Face> faces { get; set; }
        public Color color { get; set; }
        public ImageType imageType { get; set; }
    }
    public class FaceRectangle
    {
        public int left { get; set; }
        public int top { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Celebrity
    {
        public string name { get; set; }
        public FaceRectangle faceRectangle { get; set; }
        public double confidence { get; set; }
    }

    public class Detail
    {
        public IList<Celebrity> celebrities { get; set; }
        public object landmarks { get; set; }
    }

    public class Category
    {
        public string name { get; set; }
        public double score { get; set; }
        public Detail detail { get; set; }
    }

    public class Tag
    {
        public string name { get; set; }
        public double confidence { get; set; }
    }

    public class Caption
    {
        public string text { get; set; }
        public double confidence { get; set; }
    }

    public class Description
    {
        public IList<string> tags { get; set; }
        public IList<Caption> captions { get; set; }
    }

    public class Metadata
    {
        public int width { get; set; }
        public int height { get; set; }
        public string format { get; set; }
    }

    public class Face
    {
        public int age { get; set; }
        public string gender { get; set; }
        public FaceRectangle faceRectangle { get; set; }
    }

    public class Color
    {
        public string dominantColorForeground { get; set; }
        public string dominantColorBackground { get; set; }
        public IList<string> dominantColors { get; set; }
        public string accentColor { get; set; }
        public bool isBWImg { get; set; }
    }

    public class ImageType
    {
        public int clipArtType { get; set; }
        public int lineDrawingType { get; set; }
    }
}