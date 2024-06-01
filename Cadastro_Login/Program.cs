using Cadastro_Login.Model;
using Cadastro_Login.Menus;
using Cadastro_Login.Servicos;


class Program
{
    static void Main(string[] args)
    {
        // Exibindo mensagem de boas vindas
        ExibirBoasVindas();

        Cadastrar cadastrar = new Cadastrar();
        cadastrar.InserirDados();

        /*
         O projeto não continuava porque não tinha outros metodos sendo chamados
        */

        var usuariosRegistrados = cadastrar.usuariosRegistrados;


        Login login = new Login();
        login.ExecutarLogin(usuariosRegistrados);

        //Dictionary<int, Menu> opcoes = new();
        //opcoes.Add(1, new MenuCadastrar());
        //opcoes.Add(2, new MenuLogin());
        //opcoes.Add(3, new MenuAlterarSenha());
        //opcoes.Add(4, new MenuSair());
    }

    static void ExibirBoasVindas()
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


    static void ExibirOpcoesMenu()
    {
        Console.WriteLine("\n1. Cadastrar Usuário");
        Console.WriteLine("2. Fazer o Login do Usuário");
        Console.WriteLine("3. Esqueci minha senha");
        Console.WriteLine("4. Sair");
    }
}