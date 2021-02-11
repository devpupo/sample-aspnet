using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace hurb_sap.Models
{
    public class PaymentsModel{
     [Key]
     [Required(ErrorMessage = "This field is required")]
     public int DocEntry {get; set;}

     [Required(ErrorMessage = "This field is required")]
     [DataType(DataType.Date)]
     [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyyMMdd}")]
     public DateTime PayDay {get; set;}

     [Required(ErrorMessage = "This field is required")]
     public decimal DocTotal {get; set;}   

    }
}