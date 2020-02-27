using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class BlogContext : DbContext
    {
        public BlogContext() : base()
        {
            Database.SetInitializer(new BlogContextInitializer());
        }

        public IDbSet<Article> Articles { get; set; }
        public IDbSet<Comment> Comments { get; set; }
    }
}
