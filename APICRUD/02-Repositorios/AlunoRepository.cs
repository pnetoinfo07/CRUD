using CRUD._01_Entidades;
using CRUD.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD._02_Repositorios
{
    public class AlunoRepository
    {
        private readonly string ConnectionString;
        public AlunoRepository(IConfiguration configuration)
        {
            ConnectionString = configuration.GetConnectionString("DefaultConnection");
        }
        public void Adicionar(Aluno aluno)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string comandInsert = @"INSERT INTO Alunos(Nome,Idade, Peso) 
                                    VALUES (@Nome,@Idade, @Peso)";

                using (var command = new SQLiteCommand(comandInsert, connection))
                {
                    command.Parameters.AddWithValue("@Nome", aluno.Nome);
                    command.Parameters.AddWithValue("@Idade", aluno.Idade);
                    command.Parameters.AddWithValue("@Peso", aluno.Peso);
                    command.ExecuteNonQuery();
                }
            }
        }
        public void Remover(Aluno aluno)
        {
            throw new Exception();
        }
        public void Editar(int id, Aluno editAluno)
        {
            throw new Exception();
        }
        public List<Aluno> Listar()
        {
            throw new Exception();
        }
        public Aluno BuscarPorId(int id)
        {
            throw new Exception();
        }
    }
}
