﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BackEnd.DAL;
using BackEnd.Entities;
using BackEnd.Libraries;


//https://medium.com/@mehanix/lets-talk-security-salted-password-hashing-in-c-5460be5c3aae
//https://stackoverflow.com/questions/2138429/hash-and-salt-passwords-in-c-sharp
//https://docs.microsoft.com/en-us/aspnet/core/security/data-protection/consumer-apis/password-hashing?view=aspnetcore-3.1
//https://forums.asp.net/t/2155576.aspx?how+to+hash+salt+password+in+Register+and+Login
//https://blog.securityinnovation.com/blog/2011/03/how-to-hash-and-salt-passwords-in-aspnet.html

namespace PruebasBackEnd
{
    [TestClass]
    public class TestUsuarioDAL
    {
        [TestMethod]
        public void TestAdd()
        {

            IUsuarioDAL usuarioDAL = new UsuarioDALImpl();

            //Crear salted password
            Auth auth = new Auth();
            string salt = auth.generarSalt();
            Console.WriteLine("Salt:" + auth.generarSalt());
            string clave = auth.hash_password("12345678", salt);
            Console.WriteLine("Hashed Password :" + clave);


            Usuario usuario = new Usuario()
            {
                estado = 1,
                usuario = "gcascante",
                salt = salt,
                clave = clave,
                tipo = 1,
                fecha_creacion = DateTime.Now,
                ultimo_login = DateTime.Now,
                identificacion = "112560518",
                nombre = "Gregory Cascante Aviles",
                email1 = "gregory@santafe.co.cr",
                email2 = "gregory@santafe.co.cr",
                telefono1 = "88493551",
                telefono2 = "88493551",
                pais = 53,
                provincia = 1,
                canton = 101,
                distrito = 10201,
                direccion = "Escazu"

            };


            Assert.AreEqual(true, usuarioDAL.Add(usuario));
        }
    }
}
