using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DeliveryExpress.Models;

    public class DeliveryExpressContext : DbContext
    {
        public DeliveryExpressContext (DbContextOptions<DeliveryExpressContext> options)
            : base(options)
        {
        }

        public DbSet<DeliveryExpress.Models.OrderList> OrderList { get; set; } = default!;

        public DbSet<DeliveryExpress.Models.Customer> Customer { get; set; } = default!;

        public DbSet<DeliveryExpress.Models.DeliveryExecutive> DeliveryExecutive { get; set; } = default!;
    }
