using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDBApp
{
    interface IRepository<T>
    {
        T GetItem(int id);

        IEnumerable<T> GetAllItems();

        void AddItem(T item);

        void DeleteItem(int ID);

        void UpdateItem(T item);
    }
}
