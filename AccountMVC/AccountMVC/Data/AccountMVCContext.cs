using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AccountMVC.Models;

namespace AccountMVC.Data
{
    public class AccountMVCContext : DbContext
    {
        public AccountMVCContext (DbContextOptions<AccountMVCContext> options)
            : base(options)
        {
        }

        public DbSet<AccountMVC.Models.Account> Account { get; set; }
    }
}
