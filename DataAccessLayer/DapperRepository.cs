using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Dapper;
using System.Reflection;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;

namespace DataAccessLayer
{
    public class DapperRepository<T>: IRepository<T> where T : class, IDomainObject
    {
        private readonly string _connectionstring;
        private readonly string _tablename;
        private readonly List<PropertyInfo> _properties; 
        
        public DapperRepository(string connectionstring) 
        {
            _connectionstring = connectionstring;
            _tablename = typeof(T).Name + "s";
            _properties = typeof(T).GetProperties().Where(p => p.Name != "ID").ToList();

        }
        public void Add(T entity)
        {
            using (IDbConnection db = new SqlConnection(_connectionstring))
            {
                var columns = string.Join(", ", _properties.Select(p => p.Name));
                var values = string.Join(", ", _properties.Select(p => $"@{p.Name}"));
                var sqlQuery = $"INSERT INTO {_tablename} ({columns}) VALUES({values})";
                db.Execute(sqlQuery, entity);

            }
        }

        public void Update(T entity)
        {
            using (IDbConnection db = new SqlConnection(_connectionstring))
            {
                var setProperties = string.Join(", ", _properties.Select(p => $"{p.Name} = @{p.Name}"));
                var sqlQuery = $"UPDATE {_tablename} SET {setProperties} WHERE ID = @ID";
                db.Execute(sqlQuery, entity);
            }
        }

        public void Delete(int id)
        {
            using (IDbConnection db = new SqlConnection(_connectionstring))
            {
                var sqlQuery = $"DELETE FROM {_tablename} WHERE Id = @id";
                db.Execute(sqlQuery, new { id });
            }
        }
        public T? ReadByID(int id) 
        {
            using (IDbConnection db = new SqlConnection(_connectionstring))
            {
                return db.Query<T>($"SELECT * FROM {_tablename} WHERE ID = @id", new { id }).FirstOrDefault();
            }
        }
        public IEnumerable<T> GetAll()
        {
            using (IDbConnection db = new SqlConnection(_connectionstring))
            {
                return db.Query<T>($"SELECT * FROM {_tablename}").ToList();
            }
        }
    }
}
