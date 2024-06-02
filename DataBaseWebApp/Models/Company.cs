using System.ComponentModel.DataAnnotations;

namespace DataBaseWebApp.Models;

public class Company
{
    public int Id { get; set; }

    [Required]
    public string CompanyName { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }
    public string? State { get; set; }
    public string? PostalCode { get; set; }
    public string? Country { get; set; }
    public string? Phone { get; set; }
    public string? Contact { get; set; }

    [EmailAddress]
    public string? Email { get; set; }

}