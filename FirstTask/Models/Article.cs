using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstTask.Models
{
    public class Article
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }

        public Article(string Name, string Text)
        {
            this.Name = Name;
            this.Text = Text;
            Date = DateTime.Now;
        }
        public Article ()
        {

        }
        public List<Article> CreateTestList()
        {
            List<Article> testList = new List<Article>();
            testList.Add(new Article("Name1", "TextTextTextTextText"));
            testList.Add(new Article("Name2", "TextTextTextTextText"));
            testList.Add(new Article("Name3", "TextTextTextTextText"));
            testList.Add(new Article("Name4", "TextTextTextTextText"));
            return testList;
        }
    }
}