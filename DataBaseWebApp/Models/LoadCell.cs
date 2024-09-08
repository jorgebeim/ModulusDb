using System.ComponentModel.DataAnnotations;
using DataBaseWebApp.Locales;

namespace DataBaseWebApp.Models;

public class LoadCell
{
    public int Id { get; init; }

    [Required(ErrorMessageResourceName = "SerNumRequired", ErrorMessageResourceType = typeof(ErrorMessageResource)), MaxLength(100)]
    public string SerialNr { get; set; }

    [Range(0, 999999999.0, ErrorMessageResourceName = "CapacityRange", ErrorMessageResourceType = typeof(ErrorMessageResource))]
    public double CapacityKn { get; set; }

    [MaxLength(200)]
    public string? Manufacturer { get; set; }

    [MaxLength(100)]
    public string? Model { get; set; }

    public DateTime? PurchaseDate { get; set; }

    public DateTime? CalDate { get; set; }
}