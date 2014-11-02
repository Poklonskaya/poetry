using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poetry.DomainModels
{
    public class Poet
    {
        public int PoetId { get; set; }
        public string Name { get; set; }

        public string AvatarUrl { get; set; }

        public virtual List<Post> Posts { get; set; }
    }
}

