using Cadastro_Login.Model;

namespace Cadastro_Login.Servicos;

internal class Cadastrar
{
    public List<Usuario> usuariosRegistrados = new();

    public List<string> usuarioLogin = new();
    public List<string> usuariosSenhas = new();

    private readonly string email;
    private readonly string senha;

    public void InserirDados()
    {
   
        Console.WriteLine("Digite seu Nome de Usuário: ");
        string nome = Console.ReadLine();

        // As variaveis email e senha estavam sendo salvas nulas pois não estavam em escopo global.
        string email;
        string senha;
        while (true)
        {
            Console.WriteLine("Digite seu E-mail: ");
            email = Console.ReadLine();
            if (ValidadorEmail.ValidacaoEmail(email))
            {
                usuarioLogin.Add(email);
                break;
            }
        }
        while(true)
        {
            Console.WriteLine("Digite sua senha: ");
            senha = Console.ReadLine();
            Console.WriteLine("Digite novamente a sua Senha: ");
            string confirmacaoSenha = Console.ReadLine();
            if (confirmacaoSenha.Equals(senha)){
                usuariosSenhas.Add(senha);
                break;
            } else
            {
                Console.WriteLine("A senha não está de acordo com a senha Registrada. Porfavor insira uma nova senha: ");
            }
        }
        Console.WriteLine($"Usuário {nome} está registrado!");
        Console.WriteLine($"Seja Bem-vindo {nome}");

        Usuario usuarios = new(nome, email, senha);
        usuariosRegistrados.Add(usuarios);
    }

}
