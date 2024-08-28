using CRUD._01_Entidades;
using CRUD._02_Repositorios;
using CRUD.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD._03_Aplicacao
{
    public class AlunoService
    {
        public AlunoRepository repository { get; set; }
        public AlunoService()
        {
            repository = new AlunoRepository();
        }
        public void Adicionar(Aluno aluno)
        {
            repository.Adicionar(aluno);
        }

        public void Remover(Aluno aluno)
        {
            repository.Remover(aluno);
        }

        public List<Aluno> Listar()
        {
            return repository.Listar();
        }
        public Aluno BuscarTimePorId(int id)
        {
            return repository.BuscarPorId(id);
        }
        public void Editar(int id, Aluno editAluno)
        {
            repository.Editar(id, editAluno);   
        }
    }
}
