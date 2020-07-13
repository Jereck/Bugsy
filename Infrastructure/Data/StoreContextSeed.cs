using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Data
{
    public class StoreContextSeed
    {
        public static async Task SeedAsync(StoreContext context, ILoggerFactory loggerFactory)
        {
            try 
            {
                if (!context.Bugs.Any())
                {
                    var bugsData = File.ReadAllText("../Infrastructure/Data/SeedData/bugs.json");

                    var bugs = JsonSerializer.Deserialize<List<Bug>>(bugsData);

                    foreach (var item in bugs)
                    {
                        context.Bugs.Add(item);
                    }

                    await context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<StoreContextSeed>();
                logger.LogError(ex.Message);
            }
        }
    }
}