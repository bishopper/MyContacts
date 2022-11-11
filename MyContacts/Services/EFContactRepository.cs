using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyContacts.Services
{
    internal class EFContactRepository
    {
        // Contact_DBEntities db  = new Contact_DBEntities();
        public bool Delete(int contactId)
        {
            throw new NotImplementedException();
        }

        public bool Insert(string name, string family, string mobile, string email, int age, string address)
        {
            throw new NotImplementedException();
        }

        public DataTable Search(string parameter)
        {
            throw new NotImplementedException();
        }

        public DataTable SelectAll()
        {
            throw new NotImplementedException();
        }

        public DataTable SelectRow(int contactId)
        {
            throw new NotImplementedException();
        }

        public bool Update(int contactId, string name, string family, string mobile, string email, int age, string address)
        {
            throw new NotImplementedException();
        }
    }
}
