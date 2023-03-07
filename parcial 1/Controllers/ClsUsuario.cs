using parcial_1.Models;

namespace parcial_1.Controllers
{
    public class ClsUsuario
    {
        public bool Acceso (Usuario usuario)
        {
            if (usuario.contra.Equals(123) && usuario.nombre.Equals("Fabricio")) 
                {
                    return true;    
                }
            return false;
            
        }
    }
}
