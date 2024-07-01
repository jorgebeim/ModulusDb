using System.ComponentModel.DataAnnotations;
using DataBaseWebApp.Locales;

namespace DataBaseWebApp.Models;

public class Company
{
    public int Id { get; init; }

    [Required(ErrorMessageResourceType = typeof(ErrorMessageResource), ErrorMessageResourceName = "CoNameRequired")]
    public string CompanyName { get; set; }

    public string? Address { get; set; }

    [MaxLength(100)]
    public string? City { get; set; }

    [MaxLength(100)]
    public string? State { get; set; }

    [MaxLength(100)]
    public string? PostalCode { get; set; }

    [MaxLength(100)]
    public string? Country { get; set; }

    [Phone, MaxLength(100)]
    public string? Phone { get; set; }
    public string? Contact { get; set; }

    [EmailAddress, MaxLength(100)]
    public string? Email { get; set; }

}