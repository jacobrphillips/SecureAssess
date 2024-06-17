using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class Seed
    {
        public static async Task SeedUsersAsync(DataContext context)
        {
            try
            {
                if (await context.Users.AnyAsync()) return;

                var userData = await File.ReadAllTextAsync("Data/UserSeedData.json");

                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

                var users = JsonSerializer.Deserialize<List<AppUser>>(userData, options);

                foreach (var user in users)
                {
                    using var hmac = new HMACSHA512();

                    user.EmailAddress = user.EmailAddress.ToLower();

                    user.PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes("Pa$$w0rd"));
                    user.PasswordSalt = hmac.Key;

                    context.Users.Add(user);
                }

                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during user seed: {ex.Message}");
                throw;
            }
        }
    }
}