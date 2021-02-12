using System;
using System.IO;
using Insta_Dev_Ex.Interfaces;
namespace Insta_Dev_Ex.Models
{
    public class Usuario : InstaDevBase, IUsuario
    {
        // PROPRIEDADES
        public int          IdUsuario { get; set; }
        public string       Nome { get; set; }   
        public string       Foto { get; set; }
        public DateTime     DataNascimento { get; set; }
        public string       Email { get; set; }
        public string       UserName { get; set; }
        public string       Senha { get; set; }
        public const string PATH ="/DataBase/Usuario.csv";
        
        //MÉTODOS
        public string Preparar(Usuario u)
        {
            return $"{u.IdUsuario};{u.Nome};{u.Foto};{u.DataNascimento};{u.Email};{u.UserName};{u.Senha}";
        }

        public void Cadastrar(Usuario user) // == Create
        {
            string[] linha = {Preparar(user)};
            File.AppendAllLines(PATH, linha);
        }
    }    
}