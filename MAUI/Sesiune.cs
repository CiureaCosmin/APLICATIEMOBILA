using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI
{
    class Sesiune
    {
        public int Id { get; set; }
        public string Username { get; set; }

        public Sesiune() { }

        public Sesiune(int id, string username)
        {
            Id = id;
            Username = "Cosmin";
        }
    }
}





