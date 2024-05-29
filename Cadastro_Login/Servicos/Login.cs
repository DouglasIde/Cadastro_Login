using Cadastro_Login.Model;

namespace Cadastro_Login.Servicos;

internal class Login
{
    public void ExecutarLogin(List<Usuario> usuariosRegistrados)
    {
        

        while (true)
        {
            Console.WriteLine("Digite seu e-mail ou nome de usuário");
            string nomeUsuario = Console.ReadLine();
            if (string.IsNullOrEmpty(nomeUsuario))
            {
                Console.WriteLine("Valor inválido!! Por favor digite seu e-mail ou nome de usuário: ");
                return;
            } // Validação de Entrada.
            //if (ValidadorEmail.ValidacaoEmail(nomeUsuario))
            //{
            //    continue;
            //} // Chamando a classe "ValidadorEmail" para validar o e-mail.

            Usuario usuario = usuariosRegistrados.FirstOrDefault(u => u.Email.Equals(nomeUsuario) || u.Nome.Equals(nomeUsuario));
            for(int i = 0; i <= usuariosRegistrados.Count(); i++)
            {
               var indiceUsuario = usuariosRegistrados.IndexOf(usuariosRegistrados[i]);
                if (indiceUsuario[i])
                {

                }
            }
            if (usuario == null)
            {
                Console.WriteLine("Usário não encontrado. Tente novamente.");
                return;
            } // Se o usuario da lista de usuarios estiver vazia
            break;
        }
        while (true) { 
            Console.WriteLine("Digite sua senha: ");
            string senha = Console.ReadLine();
            if (senha.Equals(senha))
            {
                continue;
            } else
            {
                Console.WriteLine("Senha inválida!! Tente novamente");
                return;
            }
            foreach (var pessoa in usuariosRegistrados)
            {
                Console.WriteLine($"Seja bem-vindo {pessoa.Nome}");
            }

        }
    }}

