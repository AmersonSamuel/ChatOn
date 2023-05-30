using ChatOn.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatOn.Model;
using Microsoft.EntityFrameworkCore;

namespace ChatOn.Controller
{
    public class DefaultController
    {
        public static DataContext Context = new DataContext();
    }

    public class UsuarioController : DefaultController
    {
        // Métodos para alterar dados

        public bool ValidarSenha(Usuarios user)
        {
            // Lógica de validação da nova senha
            // Por exemplo, verificar o comprimento mínimo, caracteres especiais, etc.
            return user.Senha.Length >= 8;
        }
        public void AlterarSenha(Usuarios user, string novaSenha)
        {
            // Lógica para validar a nova senha
            if (ValidarSenha())
            {
                // Lógica para alterar a senha do usuário
                user.Senha = novaSenha;
                Console.WriteLine("Senha alterada com sucesso!");
            }
            else
            {
                Console.WriteLine("A nova senha é inválida. Certifique-se de que atenda aos requisitos.");
            }
        }

        public void AlterarNomeUsuario(Usuarios user, string novoNomeUsuario)
        {
            // Lógica para validar o novo nome de usuário
            if (ValidarNomeUsuario(novoNomeUsuario))
            {
                // Lógica para alterar o nome de usuário
                user.NomeUsuario = novoNomeUsuario;
                Console.WriteLine("Nome de usuário alterado com sucesso!");
            }
            else
            {
                Console.WriteLine("O novo nome de usuário é inválido. Certifique-se de que atenda aos requisitos.");
            }
        }

        public bool ValidarNomeUsuario(Usuarios user, string nomeUsuario)
        {
            // Lógica de validação do novo nome de usuário
            // Por exemplo, verificar comprimento mínimo, caracteres permitidos, disponibilidade, etc.
            return nomeUsuario.Length >= 4;
        }

        public void AlterarImagemPerfil(string novaImagemPerfil)
        {
            // Lógica para validar a nova imagem de perfil
            if (ValidarImagemPerfil(novaImagemPerfil))
            {
                // Lógica para alterar a imagem de perfil
                this.ImagemPerfil = novaImagemPerfil;
                Console.WriteLine("Imagem de perfil alterada com sucesso!");
            }
            else
            {
                Console.WriteLine("A nova imagem de perfil é inválida. Certifique-se de que esteja no formato correto e seja acessível.");
            }
        }

        private bool ValidarImagemPerfil(string imagemPerfil)
        {
            // Lógica de validação da nova imagem de perfil
            // Por exemplo, verificar o formato (JPEG, PNG, etc.), tamanho máximo, URL válida, etc.
            return !string.IsNullOrEmpty(imagemPerfil) && Uri.IsWellFormedUriString(imagemPerfil, UriKind.Absolute);
        }
    }
}
