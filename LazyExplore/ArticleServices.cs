using System;
using System.Collections.Generic;

namespace LazyExplore
{
    public class ArticleServices
    {
        public static List<Article> GetArtices()
        {
            List<Article> articles = new List<Article>
            {
                new Article{Id=1,Title="Lazy Load",PublishDate=DateTime.Parse("2015-4-20")},
                new Article{Id=2,Title="Delegate",PublishDate=DateTime.Parse("2015-4-21")},
                new Article{Id=3,Title="Event",PublishDate=DateTime.Parse("2015-4-22")},
                new Article{Id=4,Title="Thread",PublishDate=DateTime.Parse("2015-4-23")}
            };
            Console.WriteLine("Article Initalizer");
            return articles;
        }

        public static IEnumerable<Article> GetAllArtices() 
        {
            List<Article> articles = new List<Article>
            {
                new Article{Id=1,Title="Lazy Load",PublishDate=DateTime.Parse("2015-4-20")},
                new Article{Id=2,Title="Delegate",PublishDate=DateTime.Parse("2015-4-21")},
                new Article{Id=3,Title="Event",PublishDate=DateTime.Parse("2015-4-22")},
                new Article{Id=4,Title="Thread",PublishDate=DateTime.Parse("2015-4-23")}
            };
            Console.WriteLine("文章初始化完成");
            foreach (var item in articles)
            {
                yield return item;
            }
            Console.WriteLine("Article Initalizer");
            
        }

    }
}