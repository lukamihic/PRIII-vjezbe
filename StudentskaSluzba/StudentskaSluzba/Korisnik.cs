﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaSluzba
{
    class Korisnik
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public void Validate()
        {
            if (Password.Length < 3)
            {
                throw new ApplicationException("Password nije ispravan!");
            }
        }
    }
}
