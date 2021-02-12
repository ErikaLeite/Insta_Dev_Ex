using System;
using System.IO;
using Insta_Dev_Ex.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Insta_Dev_Ex.Controllers
{
    [Route("Cadastro")]
    public class CadastroController : Controller
    {
        Usuario usuarioModel = new Usuario();
       
       public IActionResult Index()
       {
           return View();
       }
       public IActionResult Cadastrar (IFormCollection form)
       {
           Usuario novoUsuario      = new Usuario();
           novoUsuario.IdUsuario    = Int32.Parse(form["IdUsuario"]);
           novoUsuario.Nome         = form["Nome"];
           novoUsuario.UserName     = form["UserName"];
           novoUsuario.Senha        = form["Senha"];      
           
            if(form.Files.Count > 0)
            {
                // Upload Início
                // var file    = form.Files[0];
                // var folder  = Path.Combine(Directory.GetCurrentDirectory(), "LOCAL");

                // if(!Directory.Exists(folder)){
                //     Directory.CreateDirectory(folder);
                // }
                
                // var path = Path.Combine(Directory.GetCurrentDirectory(), "LOCAL", folder, file.FileName);
                // using (var stream = new FileStream(path, FileMode.Create))  
                // {  
                //     file.CopyTo(stream);  
                // }
                // novoUsuario.Foto   = file.FileName;                
            }
                
       }
    }
    // !!!! DÚVIDAS: Retirar header e footer de pages que não utilizam
    // 
}