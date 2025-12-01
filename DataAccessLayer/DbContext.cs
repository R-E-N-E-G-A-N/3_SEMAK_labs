using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    /// <summary>
    /// Контекст базы данных для Entity Framework
    /// </summary>
    public class DbContext : System.Data.Entity.DbContext
    {
        /// <summary>
        /// Конструктор контекста базы данных
        /// </summary>
        public DbContext() : base("name=GamerConnectionString")
        {
            // Инициализация контекста
            Database.SetInitializer(new CreateDatabaseIfNotExists<DbContext>());
        }

        /// <summary>
        /// Набор сущностей Gamer в базе данных
        /// </summary>
        public virtual DbSet<GamerEntity> Gamers { get; set; }

        /// <summary>
        /// Конфигурация модели при создании контекста
        /// </summary>
        /// <param name="modelBuilder">Конструктор модели</param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Настройка таблицы GamerEntity
            modelBuilder.Entity<GamerEntity>()
                .ToTable("Gamers");

            modelBuilder.Entity<GamerEntity>()
                .HasKey(e => e.Id);

            modelBuilder.Entity<GamerEntity>()
                .Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<GamerEntity>()
                .Property(e => e.IQ)
                .IsRequired();

            modelBuilder.Entity<GamerEntity>()
                .Property(e => e.Balance)
                .IsRequired();

            base.OnModelCreating(modelBuilder);
        }
    }

    /// <summary>
    /// Сущность Gamer для Entity Framework
    /// </summary>
    public class GamerEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int IQ { get; set; }
        public int Balance { get; set; }
    }
}