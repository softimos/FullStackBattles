using Microsoft.EntityFrameworkCore;
using Softimos.FullStackBattles.DTO;
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Reflection;

namespace Softimos.FullStackBattles.Database
{
    /// <summary>
    /// EF Core context class for the database used in the solution.
    /// </summary>
    /// <seealso cref="Microsoft.EntityFrameworkCore.DbContext" />
    public class CustomDatabaseContext : DbContext
    {
        /// <summary>
        /// Gets or sets the People entity.
        /// </summary>
        /// <value>
        /// The people entity.
        /// </value>
        public DbSet<Person> People { get; set; }

        /// <summary>
        /// Gets or sets the Starships entity.
        /// </summary>
        /// <value>
        /// The starships entity.
        /// </value>
        public DbSet<Starship> Starships { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomDatabaseContext"/> class.
        /// </summary>
        /// <param name="options">The options for this context.</param>
        public CustomDatabaseContext(DbContextOptions options) : base(options)
        {
        }

        /// <summary>
        /// Creates the database if it does not exist and fills it with sample data.
        /// </summary>
        public void PrepareDatabase()
        {
            Database.Migrate();
            SeedSampleData();
        }

        /// <summary>
        /// Seeds the sample data from JSON files into the database.
        /// </summary>
        private void SeedSampleData()
        {
            string previusCurrentDirectory = Directory.GetCurrentDirectory();

            try
            {
                string codeBase = Assembly.GetExecutingAssembly().CodeBase;
                UriBuilder uri = new UriBuilder(codeBase);
                string path = Uri.UnescapeDataString(uri.Path);
                var sampleDataDirectory = Path.GetDirectoryName(path) + @"\SampleData";
                Directory.SetCurrentDirectory(sampleDataDirectory);

                SeedTable<Person>("people.json", People);
                SeedTable<Starship>("starships.json", Starships);
            }
            finally
            {
                Directory.SetCurrentDirectory(previusCurrentDirectory);
            }
        }

        /// <summary>
        /// Fills the selected entity table with data from selected JSON file.
        /// </summary>
        /// <typeparam name="T">Entity type</typeparam>
        /// <param name="fileName">Name of the JSON file.</param>
        /// <param name="dbSet">The database set.</param>
        private void SeedTable<T>(string fileName, DbSet<T> dbSet) where T : class, IInt32Identity
        {
            if (!dbSet.Any())
            {
                string dataJson = File.ReadAllText(fileName);
                List<T> dataList = JsonConvert.DeserializeObject<List<T>>(dataJson);
                AddRange(dataList);
                SaveChanges();
            }
        }
    }
}
