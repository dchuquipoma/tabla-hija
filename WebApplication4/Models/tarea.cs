using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class tarea
    {
        public String car_cod { get; set; }
        public String car_nom { get; set; }

        public String car_tip { get; set; }

 public tarea(string _personaid, string _personanom)
    {
        car_cod = _personaid;
        car_nom = _personanom;
        
    
    }

    }

   
}