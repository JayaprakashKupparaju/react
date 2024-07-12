using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UserAPI.Models;

namespace UserAPI.Data
{
    public class UserAPIContext : DbContext
    {
        public UserAPIContext (DbContextOptions<UserAPIContext> options)
            : base(options)
        {
        }

        public DbSet<UserAPI.Models.User> User { get; set; } = default!;
    }
}
