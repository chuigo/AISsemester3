using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Model;

namespace DataAccessLayer
{
    public class EntityRepository<T>  : IRepository<T> where T : class, IDomainObject
    {
        private readonly DBContext _context;
        private readonly DbSet<T> _dbSet;
        public EntityRepository(DBContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public void Add(T entity) 
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }
        public void Update(T entity) 
        {
            _dbSet.Update(entity);
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public void Delete(int id) 
        {
            var entity = _dbSet.Find(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                _context.SaveChanges();
            }
        }
        public T? ReadByID(int id) 
        {
            return _dbSet.FirstOrDefault(x => x.ID == id);
        }
        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }
    }
}
