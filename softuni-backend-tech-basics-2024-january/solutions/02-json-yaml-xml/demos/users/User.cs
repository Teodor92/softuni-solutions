using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using users;

namespace users
{
    public class User
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }
}

var exampleUser = new User 
{
    Name = "John Doe",
    Age = 42
};