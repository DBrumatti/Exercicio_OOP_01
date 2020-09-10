using System;

namespace Pessoa
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	class Dados
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			// Declaração de Variáveis

			string	nome,	//Nome de uma pessoa
					sexo;	//Sexo de uma pessoa

			//Solicita e lê os Dados da Pessoa
			Console.Write("Informe o seu nome: ");
			nome = Console.ReadLine();
			Console.WriteLine();	// Adiciona uma linha em branco

			Console.Write("Informe o seu sexo: ");
			sexo = Console.ReadLine();
			Console.WriteLine();	// Adiciona uma linha em branco

			// Verifica o sexo da pessoa
			// Estrutura de Seleção Composta IF / ELSE

			if ((sexo == "masculino") || (sexo == "MASCULINO")|| (sexo == "Masculino"))
				Console.WriteLine("Ilmo Sr. {0}", nome);
			else
				Console.WriteLine("Ilma Sra. {0}", nome);
		
		} // Fim do método Main

	} // Fim da Classe Dados
}
