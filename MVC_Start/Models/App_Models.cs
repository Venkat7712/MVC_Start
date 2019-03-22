using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Start.Models
{
  public class GuestContact
  {

    [Required(ErrorMessage = "Please enter your Name")]
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
  }
}