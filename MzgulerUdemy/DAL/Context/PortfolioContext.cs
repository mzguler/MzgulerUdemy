﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using MzgulerUdemy.DAL.Entities;

namespace MzgulerUdemy.DAL.Context
{
    public class PortfolioContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ABL000299-0036;initial Catalog=MzgulerDb;integrated Security=true;");
        }

        public DbSet<About>Abouts { get; set; }
        public DbSet<Feature>Features { get; set; }
        public DbSet<Contact>Contacts { get; set; }
        public DbSet<Experience>Experiences { get; set; }
        public DbSet<Message>Messages { get; set; }
        public DbSet<Portfolio>Portfolios { get; set; }
        public DbSet<Skill>Skills { get; set; }
        public DbSet<SocialMedia>SocialMedias { get; set; }
        public DbSet<Testimonial>Testimonials { get; set; }
    }
}