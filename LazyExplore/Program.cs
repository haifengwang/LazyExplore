using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyExplore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------顺序执行----------------------");
            UserSetup();
            Console.WriteLine("------------------Lazy----------------------");
            Console.WriteLine();
            LazyUserSetUp();
            Console.WriteLine("----------------另一延迟------------------------");
            WhereLoad();
            Console.WriteLine("----------------where 延迟------------------------");
            LazyWhereExcute();
            Console.WriteLine("----------------Find查询不延迟执行 ------------------------");
            LazyFindExcute();
            Console.Read();
        }

        private static void UserSetup()
        {
            User blogUser = new User(1);
            Console.WriteLine("user has been initialized");

            foreach (var article in blogUser.Articles)
            {
                Console.WriteLine(article.ToString());
            }
        }

        private static void LazyUserSetUp() 
        {
            User_lazy blogUser = new User_lazy(1);
            Console.WriteLine("User_lazy has been initialized");
            foreach (var article in blogUser.Articles.Value)
            {
                Console.WriteLine(article.ToString());
            }
        }
        private static void WhereLoad() 
        {
            User blogUser = new User(1,true);
            Console.WriteLine("WhereLoad has been initialized");

            foreach (var article in blogUser.OneArtice)
            {
                Console.WriteLine(article.ToString());
            }
        }

        private static void LazyWhereExcute() 
        {
            User blogUser = new User(1);
            var list = blogUser.Articles;
            var whereLs = blogUser.Articles.Where(x => x.Id > 1);
            list.Add( new Article{Id=5,Title="后添加",PublishDate=DateTime.Now});

            foreach (var item in whereLs)
            {
                Console.WriteLine(item.ToString());
            }
        }

        private static void LazyFindExcute()
        {
            User blogUser = new User(1);
            var list = blogUser.Articles;
            var findLs = blogUser.Articles.FindAll(x => x.Id > 1);
            list.Add(new Article { Id = 5, Title = "后添加", PublishDate = DateTime.Now });

            foreach (var item in findLs)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
