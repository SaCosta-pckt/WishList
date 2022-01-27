using static System.Console;

namespace WishList
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        //ListarSeries();
                        break;
                    case "2":
                        //InserirSeries();
                        break;
                    case "3":
                        //AtualizarSeries();
                        break;
                    case "4":
                        //ExcluirSeries();
                        break;
                    case "5":
                        //VisualizarSeries();
                        break;
                    case "C":
                        Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        private static string ObterOpcaoUsuario()
        {
            WriteLine();
            WriteLine("-----------Bem Vindo(a)!-----------");
            WriteLine("O que deseja fazer?");
            WriteLine("1 - Listar séries");
            WriteLine("2 - Adicionar nova série");
            WriteLine("3 - Atualizar série");
            WriteLine("4 - Excluir série");
            WriteLine("5 - Visualizar série");
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