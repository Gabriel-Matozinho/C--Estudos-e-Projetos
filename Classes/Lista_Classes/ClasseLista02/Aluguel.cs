using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseLista02 {
    internal class Aluguel {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Room { get; set; }

        public Aluguel(string nome,string email,int room) {
            Nome = nome;
            Email = email;
            Room = room;
        }

        public override string ToString() {
            return Nome 
                +", " 
                + Email;
        }
    }
}
