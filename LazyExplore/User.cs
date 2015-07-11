using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyExplore
{
  public  class User
    {
       public int Id { get; private set; }

        public List<Article> Articles { get; private set; }

        public IEnumerable<Article> OneArtice { get; private set; }

        public User(int id)
        {
            this.Id = id;
            Articles = ArticleServices.GetArtices();
            Console.WriteLine("User Initializer 未使用任何");
        }
        public User(int id,bool isOk)
        {
            this.Id = id;
            //Articles = ArticleServices.GetArticesByID(id);
            //OneArtice = ArticleServices.GetAllArtices().Where(x => x.Id == id);
            OneArtice = ArticleServices.GetAllArtices();
            
            Console.WriteLine("User Initializer 另一种延迟");
        }
    }
}
