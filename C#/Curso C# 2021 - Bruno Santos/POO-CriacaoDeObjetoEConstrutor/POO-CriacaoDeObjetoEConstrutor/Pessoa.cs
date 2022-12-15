using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_CriacaoDeObjetoEConstrutor
{//verdadeiro
	class Pessoa
	{
        public string Nome { get; set; }
        public string Morada { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }

        public Pessoa()
		{
			Nome = "";
			Morada = "";
			Idade = 0;
			Email = "";
		}

		public Pessoa(string nome, string morada, int idade, string email)
		{
			this.Nome = nome;
			this.Morada = morada;
			this.Idade = idade;
			this.Email = email;
		}

		public Pessoa(Pessoa p)
		{
			Nome = p.Nome;
			Morada = p.Morada;
			Idade = p.Idade;
			Email = p.Email;
		}

		public override string ToString()
		{
			return "Nome: " + Nome +
				"\nMorada: " + Morada +
				"\nIdade: " + Idade +
				"\nEmail: " + Email;
		}

        public override bool Equals(object obj)
        {
            if (Nome == ((Pessoa)obj).Nome && Morada == ((Pessoa)obj).Morada && Idade == ((Pessoa)obj).Idade && Email == ((Pessoa)obj).Email)
				return true;
			return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

