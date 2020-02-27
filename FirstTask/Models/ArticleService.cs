using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstTask.Models
{
    public class ArticleService
    {
        public List<ClassLibrary.Article> ShowArticles()
        {
            var articles = new List<ClassLibrary.Article>();
            using (var Blog = new BlogContext())
            {
                foreach (var elem in Blog.Articles)
                    articles.Add(elem);
            }
            return articles;
        }
    }
}
