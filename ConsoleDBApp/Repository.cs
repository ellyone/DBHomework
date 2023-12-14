using ConsoleDBApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDBApp
{
    public class DBRepository<T> : IRepository<T> where T : BaseItem
    {
        private DataContext _dataContext;

        public DBRepository()
        {
            _dataContext = new DataContext();
        }

        public DBRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public T GetItem(int ID)
        {
            return _dataContext.Set<T>().FirstOrDefault(x => x.ID == ID);
        }

        public IEnumerable<T> GetAllItems()
        {
            return _dataContext.Set<T>();
        }

        public void AddItem(T item)
        {
            _dataContext.Set<T>().Add(item);
            _dataContext.SaveChanges();
        }

        public void UpdateItem(T item)
        {
            _dataContext.Set<T>().Update(item);
            _dataContext.SaveChanges();
        }

        public void DeleteItem(int id) 
        { 
            _dataContext.Remove(id);
            _dataContext.SaveChanges();
        }
    }
}
