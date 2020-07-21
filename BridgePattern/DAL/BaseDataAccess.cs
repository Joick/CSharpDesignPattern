using System.Collections.Generic;

namespace BridgePattern.DAL
{
    public abstract class BaseDataAccess
    {
        public abstract void Add(string data);
        public abstract void Update(int index,string data);
        public abstract void Delete(string data);
        public abstract string Get(int index);
        public abstract void List();
    }
}
