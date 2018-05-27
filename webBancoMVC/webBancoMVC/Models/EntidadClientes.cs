using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

public class EntidadClientes
{
    [Display(Name = "ID")] // Data annotation Para visualizacion, se despliega el nombre "ID"
    [Required(ErrorMessage = "Debe digitar el ID del cliente")]
    public string ClienteID { get; set; }
    [Display(Name = "ID")]
    [Required(ErrorMessage = "Debe digitar el tipo de cliente")]
    public string TipoClienteID { get; set; }
    [Required(ErrorMessage = "Debe digitar el nombre del cliente")]
    public string Nombre { get; set; }
    [Required(ErrorMessage = "Debe digitar los apellidos del cliente")]
    public string Apellidos { get; set; }
    [Required(ErrorMessage = "Debe digitar el ID del cliente")]
    public string Direccion { get; set; }
    [Required(ErrorMessage = "Debe digitar el ID del cliente")]
    public string Telefono { get; set; }
    [Required(ErrorMessage = "Debe digitar el ID del cliente")]
    public string Email { get; set; }
    [Display(Name = "ID")]
    [Required(ErrorMessage = "Debe digitar el ID del cliente")]
    public DateTime Fecha_Ingreso { get; set; }
    [Display(Name = "ID")]
    [Required(ErrorMessage = "Debe digitar el ID del cliente")]
    public string Sexo { get; set; }
    [Display(Name = "ID")]
    [Required(ErrorMessage = "Debe digitar el ID del cliente")]
    public string Clave { get; set; }

}