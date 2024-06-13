
namespace VetorClasse02 {
    internal class Aluguel {
        //Declaração das propriedades
        public string Name { get; set; }
        public string Email { get; set; }      

        //Construtor
        public Aluguel(string name,string email) {
            Name = name;
            Email = email;             
        }

        public override string ToString() {
            return Name + ", " + Email;
        }
    }
}
