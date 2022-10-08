using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace api_publicidadRyR.Entitys
{
    public class Cliente
    {
        [Key]
        public string dni_cli { get; set; }
        [Required]
        [StringLength(maximumLength: 100,
            ErrorMessage = "Se tiene que ingresar el nombre del cliente")]
        public string nombre_cli { get; set; }

        public List<Venta> venta { get; set; }
    }
}
