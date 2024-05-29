using Cadastro_Login.Model;
using Cadastro_Login.Menus;
using Cadastro_Login.Servicos;


class Program
{
    static void Main(string[] args)
    {

        Cadastrar cadastrar = new Cadastrar();
        cadastrar.InserirDados();


        Login login = new Login();

        //Dictionary<int, Menu> opcoes = new();
        //opcoes.Add(1, new MenuCadastrar());
        //opcoes.Add(2, new MenuLogin());
        //opcoes.Add(3, new MenuAlterarSenha());
        //opcoes.Add(4, new MenuSair());


        void ExibirBoasVindas()
        {
            Console.WriteLine(@"

░██╗░░░░░░░██╗███████╗██╗░░░░░░█████╗░░█████╗░███╗░░░███╗███████╗
░██║░░██╗░░██║██╔════╝██║░░░░░██╔══██╗██╔══██╗████╗░████║██╔════╝
░╚██╗████╗██╔╝█████╗░░██║░░░░░██║░░╚═╝██║░░██║██╔████╔██║█████╗░░
░░████╔═████║░██╔══╝░░██║░░░░░██║░░██╗██║░░██║██║╚██╔╝██║██╔══╝░░
░░╚██╔╝░╚██╔╝░███████╗███████╗╚█████╔╝╚█████╔╝██║░╚═╝░██║███████╗
░░░╚═╝░░░╚═╝░░╚══════╝╚══════╝░╚════╝░░╚════╝░╚═╝░░░░░╚═╝╚══════╝
");
        }

        void ExibirOpcoesMenu()
        {
            Console.WriteLine("\n1. Cadastrar Usuário");
            Console.WriteLine("2. Fazer o Login do Usuário");
            Console.WriteLine("3. Esqueci minha senha");
            Console.WriteLine("4. Sair");
        }
    }
}