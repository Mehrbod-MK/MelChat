using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelChatServerCLI.DB.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        required public string Username { get; set; }

        required public string Password { get; set; }
    }
}
