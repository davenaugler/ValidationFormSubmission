using System.ComponentModel.DataAnnotations;

namespace ValidatingFormSubmission.Models
{
  public class User
  {
    [Required]
    [MinLength(4)]
    public string FirstName { get; set; }

    [Required]
    [MinLength(4)]
    public string LastName { get; set; }

    [Required]
    [Range(10,120)]
    public int Age { get; set; }

    [Required]
    [EmailAddress]
    public string EmailAddress { get; set; }

    [Required]
    [MinLength(8)]
    [DataType(DataType.Password)]
    public string Password { get; set; }
  }
}