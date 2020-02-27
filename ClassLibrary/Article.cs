using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassLibrary
{
    public class Article
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public string Tags { get; set; }
    }
    public struct ArticleTag
    {
        public List<string> TagLine;
        public ArticleTag(List<string> tags)
        {
            TagLine = tags;
        }
    }
}