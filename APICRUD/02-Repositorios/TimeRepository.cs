using CRUD.Entidades;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Repositorios
{
    public class TimeRepository
    {
        private readonly string ConnectionString;
        public TimeRepository(IConfiguration configuration)
        {
            ConnectionString = configuration.GetConnectionString("DefaultConnection");
        }    
        public void Adicionar(Time time)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<Time>(time);
        }
        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Time time = BuscarPorId(id);
            connection.Delete<Time>(time);
        }
        public void Editar(Time time)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Time>(time);
        }
        public List<Time> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Time>().ToList();
        }
        public Time BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Time>(id);
        }
    }
}
