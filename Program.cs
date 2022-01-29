using static System.Console;
using WishList.src.Classes;
using WishList.src.Enums;

namespace WishList
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
            WriteLine("-----------Bem Vindo(a)!-----------");
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        InserirSeries();
                        break;
                    case "3":
                        AtualizarSeries();
                        break;
                    case "4":
                        MarcarAssistido();
                        break;
                    case "5":
                        ExcluirSeries();
                        break;
                    case "6":
                        VisualizarSeries();
                        break;
                    case "C":
                        Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
            WriteLine("Obrigada por usar nossos serviços!");
            ReadLine();
        }

        private static void MarcarAssistido()
        {
            Write("Digite o id da série: ");
            int idSerie = int.Parse(ReadLine());
            Write("Digite a quantidade de episódios assistidos: ");
            int epsAssistidos = int.Parse(ReadLine());
            repositorio.MarcaAssistidos(idSerie,epsAssistidos);
        }
        private static void ExcluirSeries()
        {
            Write("Digite o id da série: ");
            repositorio.Exclui(int.Parse(ReadLine()));
        }

        private static void VisualizarSeries()
        {
            Write("Digite o id da série: ");
            int indiceSerie = int.Parse(ReadLine());
            var serie = repositorio.RetornaPorId(indiceSerie);
            WriteLine(serie);
        }
        private static void AtualizarSeries()
        {
            Write("Digite o id da série: ");
            int indiceSerie = int.Parse(ReadLine());

            foreach (int i  in Enum.GetValues(typeof(Genero)))
            {
                WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero),i));                
            }

            WriteLine("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(ReadLine());

            WriteLine("Digite o título da série: ");
            string entradaTitulo = ReadLine();

            WriteLine("Digite a quantidade de episódios da série: ");
            int entradaEps = int.Parse(ReadLine());

            WriteLine("Digite o ano de lançamento da série: ");
            int entradaAno = int.Parse(ReadLine());

            WriteLine("Digite a sinopse da série: ");
            string entradaSinopse = ReadLine();


            Serie atualizaSerie = new Serie(id: indiceSerie,
                                        titulo: entradaTitulo,
                                        genero: (Genero)entradaGenero,
                                        eps: entradaEps,
                                        ano_estreia: entradaAno,
                                        sinopse: entradaSinopse);
            repositorio.Atualiza(indiceSerie,atualizaSerie);
        }

        private static void ListarSeries()
        {
            WriteLine("Listar séries");
            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
                WriteLine("Nenhuma série cadastrada.");
                return;
            }

            foreach (var serie in lista)
            {
                var excluido = serie.retornaExcluido();
                var assistido = serie.retornaAssistido();
                
                if(!excluido)
                {
                    WriteLine("#ID {0}: - {1} - {2}/{3}({4})", serie.retornaId(), serie.retornaTitulo(), serie.retornaEpsAssistido(), serie.retornaTotalEps(), (assistido ? "Assistido" : "Para assistir"));
                }
            }
        }

        private static void InserirSeries()
        {
            WriteLine("Inserir nova série:");

            foreach (int i  in Enum.GetValues(typeof(Genero)))
            {
                WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero),i));                
            }

            WriteLine("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(ReadLine());

            WriteLine("Digite o título da série: ");
            string entradaTitulo = ReadLine();

            WriteLine("Digite a quantidade de episódios da série: ");
            int entradaEps = int.Parse(ReadLine());

            WriteLine("Digite o ano de lançamento da série: ");
            int entradaAno = int.Parse(ReadLine());

            WriteLine("Digite a sinopse da série: ");
            string entradaSinopse = ReadLine();

            //int id, string titulo, Genero genero, int eps, int ano_estreia, string sinopse
            Serie novaSerie = new Serie(id: repositorio.ProximoId(),
                                        titulo: entradaTitulo,
                                        genero: (Genero)entradaGenero,
                                        eps: entradaEps,
                                        ano_estreia: entradaAno,
                                        sinopse: entradaSinopse);
            repositorio.Insere(novaSerie);
        }

        private static string ObterOpcaoUsuario()
        {
            WriteLine();
            WriteLine("O que deseja fazer?");
            WriteLine("1 - Listar séries");
            WriteLine("2 - Adicionar nova série");
            WriteLine("3 - Atualizar série");
            WriteLine("4 - Marcar episódios assistidos");
            WriteLine("5 - Excluir série");
            WriteLine("6 - Visualizar série");
            WriteLine("C - Limpar tela");
            WriteLine("X - Sair");
            WriteLine("Digite a opção escolhida: ");
            WriteLine();
        
            string opcaoUsuario = ReadLine().ToUpper();
            WriteLine();
            return opcaoUsuario;
        }

    }
}