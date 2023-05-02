using System.ComponentModel.DataAnnotations;

namespace InvoiceSharp.Models;

public class VatNumber
{
    public int VatNumberId { get; set; }
    [Required]
    public string Number { get; set; }
    [Required]
    public DateTime Created { get; set; }
    [Required]
    public DateTime LastModified { get; set; }

    public int ZoneId { get; set; }
    [Required]
    public VatZone Zone { get; set; }
}
