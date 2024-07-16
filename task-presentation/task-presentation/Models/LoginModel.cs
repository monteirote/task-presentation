using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using task_presentation.Database;

namespace task_presentation.Models
{
    public class LoginModel
    {
        [Display(Name = "Usuário")]
        public string DS_NOME { get; set; }
        public string Senha { get; set; }

        public bool VerificarSenha() {
            using (var banco = new TASK_PRESENTATIONEntities()) {
                var usuario = banco.USUARIO.Where(x => x.DS_NOME == this.DS_NOME).FirstOrDefault();
                return BCrypt.Net.BCrypt.Verify(this.Senha, usuario.DS_SENHA_CRIPTOGRAFADA);
            }
        }
    }
}