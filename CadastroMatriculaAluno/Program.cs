using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroMatriculaAluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contE = 0;
            int contA = 0;
            int contM = 0;
            int contD = 0;
            
            Console.WriteLine("Deseja iniciar?");
            string ini = Console.ReadLine().ToLower();

            while (ini == "s")
            {
                Console.WriteLine("Qual o curso para matricula? [Desenvolvimento de Sistemas(D), Mecatronica(M), Administração(A), Edificações(E)] ");
                string curso = Console.ReadLine().ToLower();

                switch (curso)
                {
                    case "d":
                        contD++;
                        Console.WriteLine("Nome do aluno:");
                        string aluno = Console.ReadLine();
                        Console.Clear();
                        break;
                    case "m":
                        Console.WriteLine("Nome do aluno:");
                        aluno = Console.ReadLine();
                        Console.Clear();
                        contM++;
                        break;
                    case "a":
                        Console.WriteLine("Nome do aluno:");
                        aluno = Console.ReadLine();
                        contA++;
                        Console.Clear();
                        break;
                    case "e":
                        Console.WriteLine("Nome do aluno:");
                        aluno = Console.ReadLine();
                        contE++;
                        Console.Clear();
                        break;
                    default: 
                        Console.WriteLine("Opção invalida");
                        break;

                }
                if ( contD || contM || contE || contA > 5 )
                {
                    Console.WriteLine("Não a mais vagas");
                    contD--;
                    contM--;
                    contE--;
                    contA--;
                }
                Console.WriteLine("Deseja continuar: ");
                ini = Console.ReadLine().ToLower();

            }
            Console.WriteLine("Mastriculas em DS: " + contD);
            Console.WriteLine("Mastriculas em Meca: " + contM);
            Console.WriteLine("Mastriculas em ADM: " + contA);
            Console.WriteLine("Mastriculas em EDF: " + contE);


            Console.ReadKey();
        }
    }
}
