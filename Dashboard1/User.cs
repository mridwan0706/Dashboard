﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard1
{
   public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
      


        public User() { }

        public User(int id, string username, string password, string role)
        {
            this.Id = id;
            this.Username = username;
            this.Password = password;
            this.Role = role;
           
        }

        public virtual void Update(string username, string password, string role)
        {
            this.Username = username;
            this.Password = password;
            this.Role = role;
            
        }

        public virtual void Delete(int id)
        {
            this.Id = id;

        }


    }
}
