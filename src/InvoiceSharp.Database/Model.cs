using InvoiceSharp.Models;
using Microsoft.EntityFrameworkCore;

namespace InvoiceSharp.Database;

public class InvoicingContext : DbContext
{
    public DbSet<VatZone> VatZones { get; set; }    
    public DbSet<Customer> Customers { get; set; }
    public DbSet<VatNumber> VatNumbers { get; set; }
    public DbSet<Invoice> Invoices { get; set; }

    public string DbPath { get; }

    public InvoicingContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = Path.Join(path, "invoicesharp.db");
    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}