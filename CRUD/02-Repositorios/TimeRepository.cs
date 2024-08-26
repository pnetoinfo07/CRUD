using CRUD.Entidades;
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
        public SimuladorBD bd { get; set; }
        private const string ConnectionString = "Data Source=CRUD.db";

        public TimeRepository(SimuladorBD bdPreenchido)
        {
            bd = bdPreenchido;
        }

        public void Adicionar(Time time)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string comandInsert = @"INSERT INTO Times(Nome,AnoCriacao) 
                                    VALUES (@Nome,@AnoCriacao)";

                using (var command = new SQLiteCommand(comandInsert, connection))
                {
                    command.Parameters.AddWithValue("@Nome", time.Nome);
                    command.Parameters.AddWithValue("@AnoCriacao", time.AnoCriacao);
                    command.ExecuteNonQuery();
                }
            }
        }
        public void Remover(int id)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string deleteCommand = "DELETE FROM Times WHERE Id = @Id";
                using (var command = new SQLiteCommand(deleteCommand, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
            }
        }
        public void Editar(int id, Time editTime)
        {
            Time timeDoBancoDados = BuscarPorId(id);

            timeDoBancoDados.Nome = editTime.Nome;
            timeDoBancoDados.AnoCriacao = editTime.AnoCriacao;
        }
        public List<Time> Listar()
        {
            return bd.Times.ToList();
        }
        public Time BuscarPorId(int id)
        {
            foreach (Time t in bd.Times)
            {
                if (id == t.Id)
                {
                    return t;
                }
            }
            return null;
        }
    }
}
