using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Factory : IFactory
    {
        private readonly Dictionary<Type, IStore> _stores = new Dictionary<Type, IStore>();
        public Factory()
        {
            _stores.Add(typeof(DatabaseStore), new DatabaseStore());
            _stores.Add(typeof(FileStore), new FileStore());
        }

        public IStore GetStore(Type storeType)
        {
            if (_stores.ContainsKey(storeType))
            {
                return _stores[storeType];
            }
            else
            {
                throw new NotImplementedException("Storetype is not supported");
            }
        }
    }
}
