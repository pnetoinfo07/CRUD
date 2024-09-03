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
        public SimuladorBD bd { get; set; }
        private const string ConnectionString = "Data Source=CRUD.db";
        public AlunoRepository(SimuladorBD bdPreenchido)
        {
            bd = bdPreenchido;
        }
        public AlunoRepository()
        {
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
            bd.Alunos.Remove(aluno);
        }
        public void Editar(int id, Aluno editAluno)
        {
            Aluno alunoDoBancoDados = BuscarPorId(id);

            alunoDoBancoDados.Nome = editAluno.Nome;
            alunoDoBancoDados.Idade = editAluno.Idade;
            alunoDoBancoDados.Peso = editAluno.Peso;
        }
        public List<Aluno> Listar()
        {
            return bd.Alunos.ToList();
        }
        public Aluno BuscarPorId(int id)
        {
            foreach (Aluno a in bd.Alunos)
            {
                if (id == a.Id)
                {
                    return a;
                }
            }
            return null;
        }
    }
}
