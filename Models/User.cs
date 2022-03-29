
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab3.Models;


public class User
{
	public int UserId { get; set; }
	public string? Name { get; set; }

	public string? Email { get; set; }

	public int? StreetNumber { get; set; }
	public string? StreetName { get; set; }

	[RegularExpression(@"^[A-Za-z][0-9][A-Za-z][ ]*[0-9][A-Za-z][0-9]$", ErrorMessage = "Please enter postal code in A1A 1A1 format")]
	public string? PostalCode { get; set; }
	public string? City { get; set; }

	public string? Province { get; set; }
	public string? Phone { get; set; }

}