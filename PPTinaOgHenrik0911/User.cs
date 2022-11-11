using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPTinaOgHenrik0911
{
    internal class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public List<Books> ListOfRegisteredBooks { get; set; }


        public User(int userId, string name, string email, int age)
        {
            UserId = userId;
            Name = name;
            Email = email;
            Age = age;
            ListOfRegisteredBooks = new List<Books>();
        }

        //public void RegisterBookOnUser()
        //{
        //    ListOfRegisteredBooks.Add()
        //}
    }

}
