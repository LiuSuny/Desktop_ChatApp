﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SunnyLize.Word.Web.Server
{
    /// <summary>
    /// The database representational model for our application
    /// </summary>
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        #region Public Properties

        /// <summary>
        /// The settings for the application
        /// </summary>
        public DbSet<SettingsDataModel> Settings { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor, expecting database options passed in
        /// </summary>
        /// <param name="options">The database context options</param>
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Fluent API

            modelBuilder.Entity<SettingsDataModel>().HasIndex(a => a.Name);
        }
    }
}
