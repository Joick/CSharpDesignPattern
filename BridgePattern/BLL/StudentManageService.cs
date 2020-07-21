using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using BridgePattern.DAL;

namespace BridgePattern.BLL
{
    public class StudentManageService
    {
        public BaseDataAccess dataAccess { get; set; }

        public virtual void Add(string data)
        {
            dataAccess.Add(data);
        }

        public virtual void Update(int index,string data)
        {
            dataAccess.Update(index,data);
        }

        public virtual void Delete(string data)
        {
            dataAccess.Delete(data);
        }

        public virtual string Get(int index)
        {
            return dataAccess.Get(index);
        }

        public virtual void List()
        {
            dataAccess.List();
        }
    }
}
