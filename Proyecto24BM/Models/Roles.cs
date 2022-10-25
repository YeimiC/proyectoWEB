using System.ComponentModel.DataAnnotations;

namespace Proyecto24BM.Models
{
    public class Roles
    {
        [Key]
        public int PKRol { get; set; }
        public string Nombre { get; set; }
    }
}
