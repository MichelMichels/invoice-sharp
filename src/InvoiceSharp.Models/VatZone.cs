using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceSharp.Models;

public class VatZone
{
    public int VatZoneId { get; set; }
    
    [Required]
    [MaxLength(2)]
    public string CountryCode { get; set; } = string.Empty;
    
    [Required]
    public decimal Rate { get; set; }

    [Required]
    public string Description { get; set; } = string.Empty;

    public List<VatNumber> VatNumbers { get; set; } = new();
}
