using Cadastro_Login.Model;

namespace Cadastro_Login.Servicos;

internal class Login
{
    public void ExecutarLogin(List<Usuario> usuariosRegistrados)
    {
        // Para verificar se a senha digitada é igual a senha cadastrada, precisa fazer uma instancia global do usuario
        var usuario = new Usuario("", "", "");
        while (true)
        {
            Console.WriteLine("Digite seu e-mail ou nome de usuário");
            string nomeUsuario = Console.ReadLine();

            if (string.IsNullOrEmpty(nomeUsuario))
            {
                Console.WriteLine("Valor inválido!! Por favor digite seu e-mail ou nome de usuário: ");
                continue;
            } 
            
            // Validação de Entrada.
            //if (ValidadorEmail.ValidacaoEmail(nomeUsuario))
            //{
            //    continue;
            //} // Chamando a classe "ValidadorEmail" para validar o e-mail.


            // E aqui passar os dados obtidos á variavel 'usuario' intanciada no inicio do método.
            usuario = usuariosRegistrados.FirstOrDefault(u => u.Email.Equals(nomeUsuario) || u.Nome.Equals(nomeUsuario));
            for(int i = 0; i <= usuariosRegistrados.Count() - 1; i++)
            {

               // Aqui você já obtém o indice do usuario
               var indiceUsuario = usuariosRegistrados.IndexOf(usuariosRegistrados[i]);
               Console.WriteLine();
               Console.WriteLine("Indice {0}",indiceUsuario);
                
                // Não é preciso passar novamente o indice á variavel indiceUsuario (desta forma o compilador gerará um erro)
                // if (indiceUsuario[i])
                // {

                // }
            }

            if (usuario == null)
            {
                Console.WriteLine("Usário não encontrado. Tente novamente.");
                break;
            } // Se o usuario da lista de usuarios estiver vazia
            break;
        }
        while (true) { 
            Console.WriteLine("Digite sua senha: ");
            string senha = Console.ReadLine();

            // Aqui você faz a confirmação da senha.
            if (usuario.Senha.Equals(senha))
            {
                Console.WriteLine("Login feito!");
                continue;
            } else
            {
                // A palavra 'return' para de rodar o loop, se esse não for o comportamento desejado use 'continue'
                Console.WriteLine("Senha inválida!! Tente novamente");
                return;
            }
            foreach (var pessoa in usuariosRegistrados)
            {
                Console.WriteLine($"Seja bem-vindo {pessoa.Nome}");
            }

        }
    }}

