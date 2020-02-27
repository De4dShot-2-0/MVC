using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ClassLibrary
{
    public class BlogContextInitializer : DropCreateDatabaseAlways<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            var articles = new List<Article>
            {
                new Article
                {
                    Name = "Name1",
                    Text = "Text1Text1Text1Text1Text1Text1Text1Text1Text1Text1Text1Text1Text1Text1Text1Text1Text1Text1Text1Text1Text1Text1Text1Text1",
                    Date = DateTime.Now,
                    Tags = "glhf"//new ArticleTag(new List<string> { "gl","hf" })
                },

                new Article
                {
                    Name = "Name2",
                    Text = "Text2Text2Text2Text2TeText2TexText2Tet2TeTet2Text2TeText2Text2TexText2Te2Tet2Tet2Text2Text2Text2Text2Texxt2Text2Text2Tt2Text2Text2Text2Text2Texext2Texxt2t2Text2Text2Text2TexText2Tet2TexText2TeText2Text2Text2TexText2Te2Text2Text2TexText2Tet2Text2Text2Text2Text2TeTexText2Tet2Text2Text2TeText2TeText2Text2Text2",
                    Date = DateTime.Now,
                    Tags = "ggwp"//new ArticleTag(new List<string> { "gg","wp" })
                }
            };

            var comments = new List<Comment>
            {
                new Comment
                {
                    Name = "Comment1",
                    Text = "TextComment1",
                    Date = DateTime.Now
                },

                new Comment
                {
                    Name = "Comment2",
                    Text = "TextComment2",
                    Date = DateTime.Now
                }
            };

            articles.ForEach(art => context.Articles.Add(art));
            comments.ForEach(com => context.Comments.Add(com));
            context.SaveChanges();
        }
    }
}
