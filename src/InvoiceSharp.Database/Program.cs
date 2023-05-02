using InvoiceSharp.Database;
using InvoiceSharp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Reflection.Metadata;

using var db = new InvoicingContext();

Customer first = db.Customers.First();
Console.WriteLine($"First customer: {first.Name}");