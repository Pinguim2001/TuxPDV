using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuxPDV.Enum;

namespace TuxPDV.Model
{
    public class Usuarios
    {
        public int Id { get; }
        public string Login { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public TipoUsuario Tipo { get; set; }

        public Usuarios() { }

        public Usuarios(int _id, string _login, string _nome, string _email, string _senha, TipoUsuario _tipo)
        {
            Id = _id;
            Login = _login;
            Nome = _nome;
            Email = _email;
            Senha = _senha;
            Tipo = _tipo;
        }
    }
}
