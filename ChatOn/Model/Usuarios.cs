using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatOn.Model
{
    public class Usuarios
    {
        public int Id { get; set; }

        [MaxLength(100)]
        [Required]
        public string Login { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Senha { get; set; }

        // Dados adicionais
        public string NomeUsuario { get; set; } // Nome de usuário alternativo
        public string ImagemPerfil { get; set; } // URL ou caminho da imagem de perfil


        // Métodos para alterar dados
        public void AlterarSenha(string novaSenha)
        {
            // Lógica para validar a nova senha
            if (ValidarSenha(novaSenha))
            {
                // Lógica para alterar a senha do usuário
                this.Senha = novaSenha;
                Console.WriteLine("Senha alterada com sucesso!");
            }
            else
            {
                Console.WriteLine("A nova senha é inválida. Certifique-se de que atenda aos requisitos.");
            }
        }

        private bool ValidarSenha(string senha)
        {
            // Lógica de validação da nova senha
            // Por exemplo, verificar o comprimento mínimo, caracteres especiais, etc.
            return senha.Length >= 8;
        }

        public void AlterarNomeUsuario(string novoNomeUsuario)
        {
            // Lógica para validar o novo nome de usuário
            if (ValidarNomeUsuario(novoNomeUsuario))
            {
                // Lógica para alterar o nome de usuário
                this.NomeUsuario = novoNomeUsuario;
                Console.WriteLine("Nome de usuário alterado com sucesso!");
            }
            else
            {
                Console.WriteLine("O novo nome de usuário é inválido. Certifique-se de que atenda aos requisitos.");
            }
        }

        private bool ValidarNomeUsuario(string nomeUsuario)
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

        // Outros métodos ou propriedades relevantes

    }

}

