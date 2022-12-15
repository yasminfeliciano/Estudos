using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_CriacaoDeObjetoEConstrutor
{
	class Pessoa
	{
		string nome;
		string morada;
		int idade;
		string email;

		public Pessoa()
		{
			nome = "";
			morada = "";
			idade = 0;
			email = "";
		}

		public Pessoa(string nome, string morada, int idade, string email)
		{
			this.nome = morada;
			this.morada = morada;
			this.idade = idade;
			this.email = email;
		}

		public override string ToString()
		{
			return "Nome: " + nome +
				"\nMorada: " + morada +
				"\nIdade: " + idade +
				"\nEmail: " + email;
		}
	}
}