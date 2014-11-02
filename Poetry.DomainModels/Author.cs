using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poetry.DomainModels{


    public class Author
    { static void Main(string[] args)
    {
    using (var db=new PoetContext())
    {
    Console.Write("Enter a poet's name:");
        var name=Console.ReadLine();

        var poet= new Poet{Name=name};
        db.Poets.Add(poet);
        db.SaveChanges();

        var guery= from b in db.Poets
                   orderby b.Name
                   select b;
        foreach (var item in collection)
        {
            Console.WriteLine(item.Name); 
        }
    }
    
    
    }
    }
}
      public class Poet
      {public int PoetId { get; set; }
        public string Name { get; set; }

        public virtual List<Post> Posts { get; set; } 
    }
    public class Post
    {
        public int PoetId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int PoetId { get; set; }
        public virtual Poet Poet { get; set; }
    }
    public class PoetContext : DbContext
{
public DbSet<Poet>Poets {get; set;}
public DbSet<Post>Posts {get; set;}

}



}
