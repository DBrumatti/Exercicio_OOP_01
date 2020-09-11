using System;

namespace Pessoa
{
	class Dados
	{
    	static string nome;
      static int idade;
      static double peso, altura;

		static void Main(string[] args)
		{
			Console.Write("Informe o seu nome: ");
			nome = Console.ReadLine();
			Console.WriteLine();

			Console.Write("Informe a sua idade: ");
			idade = int.Parse(Console.ReadLine());
			Console.WriteLine();

      Console.Write("Informe o seu peso: ");
			peso = float.Parse(Console.ReadLine());
			Console.WriteLine();

      Console.Write("Informe a sua altura: ");
			altura = Double.Parse(Console.ReadLine());
			Console.WriteLine();

      envelhecer();
      
		}
    
    public static void crescer ()
    {
      altura = altura + 0.5;
      Console.WriteLine(" Nova altura: " + altura);
    }
    
    public static void envelhecer ()
    {
      idade++;

      Console.WriteLine("Parabéns, você envelheceu!");
      Console.WriteLine("Nova idade: " + idade);
      
      if (idade <21)
      {
        crescer();
      }
      
      else
      {
        Console.WriteLine("Altura: " + altura);
      }

    }
    
    public static void engordar (){

    } 
    
    public static void emagrecer (){

    }

	}

}
