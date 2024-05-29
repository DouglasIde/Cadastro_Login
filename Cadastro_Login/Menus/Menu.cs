using Cadastro_Login.Model;

namespace Cadastro_Login.Menus;

internal class Menu
{
    public void ExibirTituloDasOpcoesMenu(string titulo)
    {
        int quantidadeLetras = titulo.Length;
        string asterisco = titulo.PadLeft(quantidadeLetras, '*');
        Console.WriteLine(asterisco);
        Console.WriteLine(titulo);
        Console.WriteLine(asterisco + "\n");
    }
}
