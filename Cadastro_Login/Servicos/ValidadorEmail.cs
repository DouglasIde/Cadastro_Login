using Cadastro_Login.Model;
using System.Text.RegularExpressions;

namespace Cadastro_Login.Servicos;

public class ValidadorEmail
{
    public static bool ValidacaoEmail(string email)
    {
        string emailModelo = "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
        
        if(Regex.IsMatch(email, emailModelo))
        {
            return true;
        } else
        {
            Console.WriteLine("Este e-mail está em um fomrato inválido!");
            return false;
        }
    }
}
