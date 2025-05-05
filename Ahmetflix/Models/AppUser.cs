using Ahmetflix.Data;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Ahmetflix.Models
{
    public class AppUser
    {
        [Key]
        public string Id { get; set; }

        public string? Nickname { get; set; }
        public int Password { get; set; }
     
    




    }
}
