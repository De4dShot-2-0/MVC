using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ClassLibrary;

namespace FirstTask.Models
{
    public class CommentService
    {
        public List<ClassLibrary.Comment> ShowComments()
        {
            var comments = new List<ClassLibrary.Comment>();
            using (var Blog = new BlogContext())
            {
                foreach (var elem in Blog.Comments)
                    comments.Add(elem);
            }
            return comments;
        }
        public void AddComment(string name, string text)
        {
            using (var Blog = new BlogContext())
            {
                Blog.Comments.Add(new ClassLibrary.Comment { Name = name, Text = text, Date = DateTime.Now });
                Blog.SaveChanges();
            }
        }
    }
}