using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;
using Confitec.TestePratico.Domain.Entities;
using Confitec.TestePratico.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace Confitec.TestePratico.Infra.Data.Context
{
    public static class ModelBuilderExtensions
    {
        public static void SeedDatabase(this ModelBuilder modelBuilder)
        {
            var Ids = 1;

            var fakeUser = new Faker<User>("pt_BR")
                .RuleFor(u => u.Id, faker => Ids++)
                .RuleFor(u => u.Nome, faker => faker.Name.FirstName())
                .RuleFor(u => u.Sobrenome, faker => faker.Name.LastName())
                .RuleFor(u => u.Email, faker => faker.Internet.Email(faker.Person.FirstName).ToLower())
                .RuleFor(u => u.DataNascimento, faker => faker.Date.Past(20))
                .RuleFor(u => u.Escolaridade, faker => faker.PickRandom<SchoolingEnum>());

            var fakeUsers = fakeUser.Generate(200);

            modelBuilder.Entity<User>().HasData(fakeUsers);
        }
    }
}
