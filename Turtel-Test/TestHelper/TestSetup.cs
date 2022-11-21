using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RobotSwarms.HICCUP;
using Turtel_App.ServerApp.Certification;

namespace RobotSwarms.TestHelper
{
    internal class TestSetup : IDisposable
    {
        public static TestSetup Empty { get { return new TestSetup(); } }
        public static TestSetup Seeded
        {
            get; set;
        }


        private List<DbContext> dbContexts = new List<DbContext>();

        public readonly Guid StartSystem;
        public ICollection<Guid?> Systems { get; private set; }

        private static readonly object syncRoot = new();
        private static volatile bool initialized;

        private TestSetup()
        {

            {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                var assembly = typeof(InMemoryDbContext).Assembly;
                var assemblyTypes = assembly.GetTypes();

                var query = from Type type in assemblyTypes
                            where type.IsClass && !type.IsAbstract && !type.IsInterface && type.IsSubclassOf(typeof(DbContext))
                            select type;

                foreach (Type type in query)
                {
                    if (type == null) continue;
                    DbContext? dbContext = Activator.CreateInstance(type) as DbContext;

                    if (dbContext == null) throw new Exception($"DbContext of type {type.FullName} could not be instantiated. There is no parameterless constructor");

                    lock (syncRoot)
                    {
                        // Initializor at this point not really neccessary.
                        if (!initialized)
                        {
                            dbContext.Database.EnsureDeleted();
                            dbContext.Database.EnsureCreated();
                            dbContexts.Add(dbContext);
                        }
                    }
                }
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            }
        }

        public void Dispose()
        {
            foreach (DbContext context in dbContexts)
            {
                context.Dispose();
            }
        }
    }
}
