using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstapp.domain
{
    class User
    {
        private string name;

        public int Id { get; set; }

        public User(int id, string name)
        {
            this.name = name;
            Id = id;
        }
    }
}
