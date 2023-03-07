using Parcial1.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial1.Negocio
{
    public class ClsUsuario
    {
        public Boolean Login(Usuario usuario)
        {
            if((usuario.Usuarioo == "Yeison" || usuario.Usuarioo == "Belquiz") && usuario.Contrasenia == "1234")
            {
                Console.WriteLine("Inicio de sesion exitoso");
                return true;
            }
            else
            {
                Console.WriteLine("Usuario o contraseña incorrecto");
                return false;
            }
        }
    }
}
