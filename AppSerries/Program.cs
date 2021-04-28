using System;
using System.Collections.Generic;

namespace AppSerries
{
    class Program
    {
       // static SerieRepositorio serieRepositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
            Console.WriteLine("número de casos de teste ");
            int NumeroDeClientes = int.Parse(Console.ReadLine());
            int[] OrdemDeChegada;
            int NumeroRecebido;
            int reordenacao = 0;
            
            List<int> list = new List<int>();
            
            // caso de teste que indica o nro de clientes
            for ( int i = 0; i < NumeroDeClientes; i++ )
            {
                Console.WriteLine("NumeroRecebido ");
                NumeroRecebido = int.Parse(Console.ReadLine());
                
                string[] s = Console.ReadLine().Split(' ');
                OrdemDeChegada = new int[NumeroRecebido];
                // indica o nro recebido via sms
                for ( int j = 0; j < NumeroRecebido; j++ )
                {
                    OrdemDeChegada[j] = int.Parse(s[j]);
                    
                    list.Add(OrdemDeChegada[j]);

                    if ( j == ( NumeroRecebido - 1 ) )
                    {
                        list.Sort();
                        list.Reverse();
                        for ( int k = 0; k < list.Count; k++ )
                        {
                            if ( OrdemDeChegada[k] == list[k] )
                            {
                                reordenacao++;
                            }
                        }

                    }                   
                }
                Console.WriteLine(reordenacao);
                reordenacao = 0;
                list.Clear();
            }
/* 
            string opcaoUsuario = ObterOpcaoUsuario();
while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarSerires();
                        break;
                    case "2":
                        InserirSerires();
                        break;
                    case "3":
                        AtualizarSerires();
                        break;
                    case "4":
                        ExcluirSerires();
                        break;
                    case "5":
                        VisualizarSerires();
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }

           
           Console.WriteLine("Obrigado por utilizar nossos serviços!!!");
            Console.ReadLine(); */
        }

       /*  private static void VisualizarSerires()
        {
            Console.WriteLine("Digite o id da serie:");
            int indiceSerie = int.Parse(Console.ReadLine());
          
            var serie = serieRepositorio.RetornaPorId(indiceSerie);
            Console.WriteLine(serie);
        }

        private static void ExcluirSerires()
        {
            Console.WriteLine("Digite o id da serie que será removida");
            int indiceSerie = int.Parse(Console.ReadLine());

            serieRepositorio.Exclui(indiceSerie);
        }

        private static void AtualizarSerires()
        {
            Console.WriteLine("Digite o id da serie");
            int indiceSerie = int.Parse(Console.ReadLine());

            //pesquisar sobre getvalues e getname
            foreach (int item in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1}", item, Enum.GetName(typeof(Genero), item));
            }

            Console.WriteLine("Digite o genero entre as opções acima:");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o titulo da serie");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o ano de inicio da serie:");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descrição da serie:");
            string entradaDescricao = Console.ReadLine();

            Serie atualizaSerie = new Serie(id: indiceSerie, 
                                    genero: (Genero)entradaGenero, 
                                    titulo: entradaTitulo, 
                                    descricao: entradaDescricao, 
                                    ano: entradaAno);

            serieRepositorio.Atualiza(indiceSerie, atualizaSerie);

        }

        private static void InserirSerires()
        {
            Console.WriteLine("Inserir nova Serie");

            //pesquisar sobre getvalues e getname
            foreach (int item in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1}", item, Enum.GetName(typeof(Genero), item));
            }

            Console.WriteLine("Digite o genero entre as opções acima:");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o titulo da serie");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o ano de inicio da serie:");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descrição da serie:");
            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie(id: serieRepositorio.ProximoId(), 
                                    genero: (Genero)entradaGenero, 
                                    titulo: entradaTitulo, 
                                    descricao: entradaDescricao, 
                                    ano: entradaAno);

            serieRepositorio.Insere(novaSerie);

        }

        private static void ListarSerires()
        {
            Console.WriteLine("Lista de Series");
            var lista = serieRepositorio.Lista();

            if(lista.Count == 0)
            {
                Console.WriteLine("Nenhuma series cadastrada");
                return;
            }

            foreach (var serie in lista)
            {
                var excluido = serie.retornaExcluido();                

                Console.WriteLine("#ID {0}: - {1}  {2}", serie.retornaId(), serie.retornaTitulo(), (excluido ? "*Excluido*" : ""));
            }

        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Series a seu dispor!!!");
            Console.WriteLine("Informe a opção desejada:");
            
            Console.WriteLine("1 - Listar séries");
            Console.WriteLine("2 - Inserir nova série");
            Console.WriteLine("3 - Atualizar serie");
            Console.WriteLine("4 - Excluir serie");
            Console.WriteLine("5 - Visualizar serie");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            
            Console.WriteLine();
            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        } */
    }
}
