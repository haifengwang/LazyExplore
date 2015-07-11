using System;
using System.Collections.Generic;

namespace LazyExplore
{
   public class User_lazy
    {
       public int Id { get; private set; }

        public Lazy<List<Article>> Articles { get; private set; }

        public User_lazy(int id)
        {
            this.Id = id;
            Articles =new Lazy<List<Article>>(()=>ArticleServices.GetArtices());
            Console.WriteLine("User_lazy Initializer");
        }
    }
}