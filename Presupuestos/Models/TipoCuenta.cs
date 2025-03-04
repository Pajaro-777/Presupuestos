﻿using Presupuesto.Validations;
using System.ComponentModel.DataAnnotations;

namespace Presupuestos.Models
{
    public class TipoCuenta
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(maximumLength: 50, MinimumLength = 3,
         ErrorMessage = "La longitud del campo {0} debe estar entre {2} y {1}  ")]
        [Display(Name = "Nombre del tipo de la cuenta")]


        ///1. Probar los dos tipos de validaciones personalizadas.
        [ValidarMayuscula]
        public string Nombre { get; set; }

        public int UduarioId { get; set; }
        public int Orden { get; set; }


    }
}
