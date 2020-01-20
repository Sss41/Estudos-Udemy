using System;

namespace Exercicio3
{
    class Estudantes
    {
        public string Nome { get; set; }
        public string Email;
        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }

}
