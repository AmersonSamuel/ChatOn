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


    }

}

