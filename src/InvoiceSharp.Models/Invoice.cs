using System.ComponentModel.DataAnnotations;

namespace InvoiceSharp.Models;

public class Invoice
{
    public int InvoiceId { get; set; }
    
    [Required]
    public string Number { get; set; } = string.Empty;

    public int CustomerId { get; set; }
    
    [Required]
    public required Customer Customer { get; set; }
}
