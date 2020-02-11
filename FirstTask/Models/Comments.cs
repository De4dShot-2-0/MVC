using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstTask.Models
{
    static class Comments
    {
        public static List<Article> comments { get; set; }

        static Comments()
        {
            comments = new List<Article>()
            {
                new Article() {
                    Name = "name1",
                    Text = "Comment1",
                    Date = DateTime.Now                    
                },
                new Article() {
                    Name = "name2",
                    Text = "Comment2",
                    Date = DateTime.Now
                },
                new Article() {
                    Name = "name3",
                    Text = "Comment3",
                    Date = DateTime.Now
                },
            };
        }
    }
}