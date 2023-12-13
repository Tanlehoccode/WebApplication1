using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication1.data;
using Microsoft.Extensions.Options;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.data
{
    public class user_location_history : DbContext
    {
        public user_location_history(DbContextOptions<user_location_history>options) : base(options)
        {
            
        }
        
        #region  DbSets
        public required DbSet<Users> Users { get; set; }
        
        #endregion



    }
}

