using System.ComponentModel.DataAnnotations;

namespace InvoiceSharp.Models;

public class Invoice
{
    public int InvoiceId { get; set; }
    [Required]
    public string Number { get; set; }

    public int CustomerId { get; set; }
    [Required]
    public Customer Customer { get; set; }
}
