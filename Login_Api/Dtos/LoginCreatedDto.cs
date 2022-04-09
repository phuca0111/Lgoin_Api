using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
namespace Login_Api.Dtos
{
    public class LoginCreatedDto
    {
            [Required]
            public int Id { get; set; }
            [Required]
            public string UserName { get; set; }
            [Required]
            public int Password { get; set; }
        
    }
}
