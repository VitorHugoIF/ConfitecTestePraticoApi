using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Confitec.TestePratico.Infra.Data.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Confitec.TestePratico.Infra.CrossCutting.Database
{
    public static class CreateDatabase
    {
        public static void Create(IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>()?.CreateScope();
            if (serviceScope != null)
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<ConfitecContext>();
                context.Database.Migrate();
            }
        }
    }
}
