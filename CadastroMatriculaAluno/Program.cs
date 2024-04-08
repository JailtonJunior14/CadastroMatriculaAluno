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
                        if (contD < 5)
                        {
                            contD++;
                            Console.WriteLine("Cadastrado");
                            
                        }
                        else
                        {
                            Console.WriteLine("Não há vagas");
                        }
                        
                        break;
                    case "m":

                        if (contM < 5)
                        {
                            contM++;
                            Console.WriteLine("Cadastrado");
                        }
                        else
                        {
                            Console.WriteLine("Não há vagas");
                        }
                        
                        
                        break;
                    case "a":
                      
                        if (contA < 5)
                        {
                            contA++;
                            Console.WriteLine("Cadastrado");
                            
                        }
                        else
                        {
                            Console.WriteLine("Não há vagas");
                        }
                        
                        break;
                    case "e":
                        
                        if (contE < 5)
                        {

                            Console.WriteLine("Cadastrado");
                            contE++;
                        }
                        else
                        {
                            Console.WriteLine("Não há vagas");
                        }

                        break;
                    default: 
                        Console.WriteLine("Opção invalida");
                        break;

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
