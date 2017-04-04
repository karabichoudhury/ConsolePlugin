using System.Collections.Generic;

namespace WcfRestfulService.Domain
{
    public sealed class EntityServer
    {
        private static List<Entity> _entities;
        private static EntityServer _instance;
        private static readonly object LockMechanism = new object();
        private int _id;

        private EntityServer()
        {
            Intialize();
        }

        public static EntityServer Instance
        {
            get
            {
                if (_instance == null)
                    lock (LockMechanism)
                    {
                        _instance = new EntityServer();
                    }
                return _instance;
            }
        }

        public List<Entity> Entities
        {
            get { return _entities; }
        }

        private static void Intialize()
        {
            _entities = new List<Entity>
            {
                new Entity {Id = 1, Name = "Entity 1", Age = 30, Exp = "8"},
                new Entity {Id = 2, Name = "Entity 2", Age = 25, Exp = "5"},
                new Entity {Id = 3, Name = "Entity 3", Age = 33, Exp = "10"},
                new Entity {Id = 4, Name = "Entity 4", Age = 40, Exp = "15"}
            };
        }

        public List<Entity> FilteredEntities(int id)
        {
            return _entities.FindAll(e => e.Id == id);
        }
    }
}