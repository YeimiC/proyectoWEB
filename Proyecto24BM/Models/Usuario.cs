using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto24BM.Models
{
    public class Usuario
    {
        [Key]
        public int PKUsuario { get; set; }
        public string Name { get; set; }
        public string user { get; set; }
       
         [ForeignKey("Roles")]
         //toma la pk de la tabla roles
        public int FkRol { get; set; }
        //declaramos la llave foránea
        public Roles Roles { get; set; }

    }
}
