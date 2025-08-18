using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeTito
{
    public class MenuBiblioteca
    {
        public void ExecutarMenuBiblioteca()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Iniciar a biblioteca ABM? S/N");
                    string respostaUser = Console.ReadLine();

                    if (respostaUser == null)
                    {
                        Console.WriteLine("Entrada nula detectada. Tente novamente.");
                        continue;
                    }

                    respostaUser = respostaUser.ToUpper();

                    if (respostaUser == "S")
                    {
                        Console.WriteLine("Biblioteca iniciada!");
                        break;
                    }
                    else if (respostaUser == "N")
                    {
                        Console.WriteLine("O programa será encerrado!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida. Por favor, digite S ou N.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocorreu um erro inesperado: " + ex.Message);
                    Console.WriteLine("Tente novamente.");
                }
                //O try catch, nos permite dentro do código fazer a captura do erro para os programadores, evitando que o programa quebre e aí a pessoa decide qual será a recorrencia do cdg
            }
        }
    }
}