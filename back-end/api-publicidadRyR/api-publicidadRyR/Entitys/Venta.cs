using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace api_publicidadRyR.Entitys
{
    public class Venta
    {
        [Key]
        public int codigo_venta { get; set; }
        [Required]
        public string fech_venta { get; set; }
        [Required]
        public Cliente dni_cli { get; set; }

        public List<Detalle_venta> detalle_venta { get; set; }
    }
}
