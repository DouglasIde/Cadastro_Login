using System.Text.RegularExpressions;

namespace Cadastro_Login.Model;
public class Usuario
{
    public string Nome { get; }
    public string Email { get; }
    public string Senha { get; set; }

    
    public Usuario(string nome, string email, string senha) // Contrutor
    {
        Nome = nome;
        Email = email;
        Senha = senha;
    } 
}