using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeTito
{
    public abstract class MaterialBiblioteca
    {
        public int IdMaterial {get; set;}
        public string Titulo { get; set;}
        public int AnoPublicacao { get ; set;} 
        public bool DisponibilidadeMaterial {get; set;}


        public MaterialBiblioteca (int IdMaterial, string Titulo, int AnoPublicacao, bool DisponibilidadeMaterial)
        {
            /*
              O this. utilizado aqui, serve para trazer uma referenciação do código;
            Ao usarmos o this no nosso código, estamos especificando que ele é a mesma coisa presente
            na classe principal;
            
            */

            this.IdMaterial = IdMaterial;
            this.Titulo = Titulo;
            this.AnoPublicacao = AnoPublicacao;
            this.DisponibilidadeMaterial = DisponibilidadeMaterial;

        } 

        public void EmprestarMaterial()
        {
            Console.WriteLine($"Deseja Emprestar o {Titulo}? ");

        }

        public void DevolverMaterial()
        {
            Console.WriteLine($"Deseja Devolver o {Titulo}");
        }

        public virtual void ExibirInformacoes()
        {
            Console.WriteLine("");
        
        }
    }
    /*
     
     SUBCLASSE LIVRO ABAIXO:
        
     */

    public class Livro : MaterialBiblioteca 
    {
        public string Genero { get; set;}
        public string Autor { get; set;}

        public Livro(int IdMaterial, string Titulo, int AnoPublicacao, bool DisponibilidadeMaterial, string Genero, string Autor)
            : base (IdMaterial, Titulo, AnoPublicacao, DisponibilidadeMaterial)
        {
            this.Genero = Genero;
            this.Autor = Autor;
        }

        /* 
         Ao criarmos uma subclasse, se a classe base não tiver um construtor padrão (sem parâmetros),
        é necessário passar os parâmetros esperados pela classe base através do uso de : base(...), 
        para que ela seja corretamente inicializada.
         */
    }

    public class Revista : MaterialBiblioteca
    {
        public string Edicao { get; set;}

        public Revista(int IdMaterial, string Titulo, int AnoPublicacao, bool DisponibilidadeMaterial, string Genero) 
            : base(IdMaterial, Titulo, AnoPublicacao, DisponibilidadeMaterial)
        {
            this.Edicao = Edicao;
        }
    }
}
