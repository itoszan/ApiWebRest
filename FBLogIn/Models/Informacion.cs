using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FBLogIn.Models
{
  public class Informacion
  {
    
    public string Id { get; set; }
    
    public string Titular { get; set; }
    
    public string numeroTelefono { get; set; }

    public string fechaNacimiento { get; set; }
    public string password1 { get; set; }
    }
}
