using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Mud_Maker.Data;

namespace Mud_Maker.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
            .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Muds.Any())
            {
                context.Muds.AddRange(
                        new Mud
                        {
                            MudName = "Jay's Sweet, Sweet Mud",
                            MudDescription = "Jay Loves to Make Muds. It is his favorite."
                        }
                );
                context.SaveChanges();
            }
        }
    }
}
