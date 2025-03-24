using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Bayron20250324B.AppWebMVC.Models;

public partial class Product
{
    public int Id { get; set; }
    [Required(ErrorMessage = "El nombre es obligatorio.")]
    public string ProductName { get; set; } = null!;

    public string? Description { get; set; }

    public decimal Price { get; set; }
    [Required(ErrorMessage = "El precio es obligatorio.")]
    
    public decimal PurchasePrice { get; set; }

    public int? WarehouseId { get; set; }

    public int? BrandId { get; set; }

    public string? Notes { get; set; }

    public virtual Brand? Brand { get; set; }

    public virtual Warehouse? Warehouse { get; set; }
}
