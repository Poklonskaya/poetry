using Poetry.DomainModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Mvc4WebApplication.EntityFramework
{
    public class ApplicationDbInitializer : CreateDatabaseIfNotExists<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            var poeeets = new List<Poet>
            {
            new Poet{PoetId=1,Name="Марина Ивановна Цветаева",AvatarUrl="http://localhost:1640/Images/c.jpg"},
            new Poet{PoetId=2,Name="Сергей Александрович Есенин",AvatarUrl="http://localhost:1640/Images/e.jpg"},
            new Poet{PoetId=3,Name="Владимир Владимирович Маяковский",AvatarUrl="http://localhost:1640/Images/m.jpg"},
            new Poet{PoetId=4,Name="Александр Сергеевич Пушкин",AvatarUrl="http://localhost:1640/Images/p.PNG"},
            new Poet{PoetId=5,Name="Анна Андреевна Ахматова",AvatarUrl="http://localhost:1640/Images/a.jpg"},
            new Poet{PoetId=6,Name="Михаил Юрьевич Лермонтов",AvatarUrl="http://localhost:1640/Images/l.jpg"},
            new Poet{PoetId=7,Name="Владимир Высоцкий",AvatarUrl="http://localhost:1640/Images/l.jpg"},
           
            };

            poeeets.ForEach(s => context.Poets.Add(s));
            context.SaveChanges();

            // add data to DB

        }
    }
}