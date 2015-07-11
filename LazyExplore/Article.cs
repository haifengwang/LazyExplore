using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyExplore
{
   public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime PublishDate { get; set; }

        public override string ToString()
        {
            return string.Format("Id={0},Title={1},PublishDate={2}",
                this.Id,this.Title,this.PublishDate.ToString("yyyy-MM-dd"));
        }
    }
}
