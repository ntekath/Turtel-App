using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RobotSwarms.HICCUP;

namespace RobotSwarms.TestHelper
{
    internal class TestSetup : IDisposable
    {
        IExplorationRobotControl? explorationRobotControl;
        public IExplorationRobotControl ExplorationRobotControl { get { if (explorationRobotControl == null) throw new Exception("No Implementation for Interface IExplorationRobotControl found."); return explorationRobotControl; } }

        IDetect? detect;
        public IDetect Detect { get { if (detect == null) throw new InvalidOperationException("No Implementation for Interface IDetect found."); return detect; } }

        public static TestSetup Empty { get { return new TestSetup(); } }
        public static TestSetup Seeded
        {
            get
            {
                var setup = new TestSetup();
                Guid?[] cells = new Guid?[16];

                for (int iCell = 1; iCell < cells.Length; iCell++)
                    cells[iCell] = Guid.NewGuid();
                cells[0] = setup.StartSystem;
                cells[2] = null; cells[8] = null; cells[12] = null; cells[14] = null;

#pragma warning disable CS8629 // Nullable value type may be null.
                setup.Detect.NeighboursDetected(cells[0].Value, cells[1], cells[2], cells[3], cells[4]);
                setup.Detect.NeighboursDetected(cells[1].Value, cells[6], cells[7], cells[0], cells[5]);
                setup.Detect.NeighboursDetected(cells[6].Value, null, cells[9], cells[1], cells[8]);
                setup.Detect.NeighboursDetected(cells[3].Value, cells[0], cells[10], cells[11], cells[12]);
                setup.Detect.NeighboursDetected(cells[11].Value, cells[3], cells[13], cells[14], cells[15]);

                setup.Detect.OreDetected(cells[1].Value, 15);
                setup.Detect.OreDetected(cells[4].Value, 4);
                setup.Detect.OreDetected(cells[5].Value, 7);
                setup.Detect.OreDetected(cells[7].Value, 22);
#pragma warning restore CS8629 // Nullable value type may be null.

                setup.Systems = cells;

                return setup;
            }
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
                var assembly = typeof(IExplorationRobotControl).Assembly;
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

            {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
#pragma warning disable CS8604 // Possible null reference argument.
                var assembly = typeof(IExplorationRobotControl).Assembly;
                var assemblyTypes = assembly.GetTypes();

                var ERCImplementationQuery = from Type type in assemblyTypes
                                             where type.IsAssignableTo(typeof(IExplorationRobotControl)) && !type.IsInterface
                                             select type;

                if (ERCImplementationQuery.Count() <= 0 || ERCImplementationQuery.Count() > 1) this.explorationRobotControl = null;
                else this.explorationRobotControl = Activator.CreateInstance(ERCImplementationQuery.FirstOrDefault()) as IExplorationRobotControl;

                var detectImplementationQuery = from Type type in assemblyTypes
                                                where type.IsAssignableTo(typeof(IDetect)) && !type.IsInterface
                                                select type;

                if (detectImplementationQuery.Count() <= 0 || detectImplementationQuery.Count() > 1) this.detect = null;
                else this.detect = Activator.CreateInstance(detectImplementationQuery.FirstOrDefault()) as IDetect;
#pragma warning restore CS8602 // Dereference of a possibly null reference.
#pragma warning restore CS8604 // Possible null reference argument.
            }

            if (explorationRobotControl != null)
                StartSystem = explorationRobotControl.ResetSystem();
            Systems = Array.Empty<Guid?>();
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
