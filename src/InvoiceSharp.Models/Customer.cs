using System.ComponentModel.DataAnnotations;

namespace InvoiceSharp.Models;

public class Customer
{
    public int CustomerId { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    public int VatNumberId { get; set; }

    [Required]
    public VatNumber VatNumber { get; set; } = new();

    public List<Invoice> Invoices { get; set;} = new List<Invoice>();
}
