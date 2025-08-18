using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeTito
{
    public class Biblioteca
    {

        List<MaterialBiblioteca> MaterialBiblioteca = new List<MaterialBiblioteca>();
        public void AdicionarMaterial()
        {
            Console.WriteLine("Escreva o Nome do Material que deseja adicionar: ");
            string Titulo = Console.ReadLine();
            //Aqui nós dizemos que todo o Console ReadLine que a pessoa adicionar, será o nome de um Livro/Revista ou Qualquer outro Material

            Console.WriteLine("Digite o Id do Material que Deseja adicionar: ");
            int IdMaterial = int.Parse(Console.ReadLine());

            //A partir de agora nós temos que usar o int.Parse, o que faz a coversão da string digitada do usuário para o INT

            Console.WriteLine("Digite o Ano de Publicação do Material: ");
            int AnoPublicacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Gênero do Livro: ");
            string Genero = Console.ReadLine();

            Console.WriteLine("Digite o Autor do Livro: ");
            string Autor = Console.ReadLine();

            Console.WriteLine("Digite a disponibilidade do Material (true/false): ");
            bool DisponibilidadeMaterial = bool.Parse(Console.ReadLine());

            Livro novoLivro = new Livro(IdMaterial, Titulo, AnoPublicacao, DisponibilidadeMaterial, Genero, Autor);

            MaterialBiblioteca.Add(novoLivro);
            //Após tudo isso adicionamos um novo livro para a Lista MaterialBiblioteca
        }

        public void EmprestarMaterial()
        {

        }







        public void MenuBiblioteca()
        {

            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Olá, você está dentro do menu da Biblioteca! O'que deseja fazer agora?: ");
                Console.WriteLine("1 - Realizar Empréstimo de um material \n");
                Console.WriteLine("2 - Listar todos os materiais \n");
                Console.WriteLine("3 - Buscar material por título \n");
                Console.WriteLine("4 - Emprestar material \n");
                Console.WriteLine("5 - Buscar material por título \n");
                Console.WriteLine("6 - Sair da Biblioteca");

                string RespostaUser = Console.ReadLine();

                switch (RespostaUser)
                {
                    case "1":
                        EmprestarMaterial();
                        break;
                    case "6":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine(" Opção inválida, por favor, escolha uma opção válida");
                        break;
                }
                //Aqui dentro criamos uma resposta do usuário referente ao que está presente no Menu de 1-6


            }
        }

    }
}