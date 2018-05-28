using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

public class EntidadClientes
{
    // Data annotation Para visualizacion, se despliega el nombre "ID"
    [Display(Name = "ID")]
    //Se le indica via el data annotation, que es requerido y en caso de incumplir la regla se muestra el mensaje de error
    //[Required(ErrorMessage = "Debe digitar el ID del cliente")]
    public string ClienteID { get; set; }
    [Display(Name = "Tipo")]
    //[Required(ErrorMessage = "Debe digitar el tipo de cliente")]
    public string TipoClienteID { get; set; }
    //[Required(ErrorMessage = "Debe digitar el nombre del cliente")]
    public string Nombre { get; set; }
    //[Required(ErrorMessage = "Debe digitar los apellidos del cliente")]
    public string Apellidos { get; set; }
    //[Required(ErrorMessage = "Debe digitar la dirección del cliente")]
    public string Direccion { get; set; }
    //[Required(ErrorMessage = "Debe digitar el teléfono del cliente")]
    public string Telefono { get; set; }
    //[Required(ErrorMessage = "Debe digitar el email del cliente")]
    public string Email { get; set; }
    [Display(Name = "Ingreso")]
    //[Required(ErrorMessage = "Debe digitar la fecha de ingreso del cliente")]
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MMM/yyyy}")]
    public DateTime Fecha_Ingreso { get; set; }
    //[Required(ErrorMessage = "Debe digitar el sexo del cliente")]
    public string Sexo { get; set; }
    //[Required(ErrorMessage = "Debe digitar la clave del cliente")]
    public string Clave { get; set; }
}