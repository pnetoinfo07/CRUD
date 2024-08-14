using CRUD._01_Entidades;
using CRUD._02_Repositorios;
using CRUD.Entidades;
using CRUD.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD._03_Aplicacao
{
    public class CidadeService
    {
        public SimuladorBD bd { get; set; }
        public CidadeRepository repository { get; set; }

        public CidadeService(SimuladorBD bdPreenchido)
        {
            bd = bdPreenchido;
            repository = new CidadeRepository(bd);
        }

        public void Adicionar(Cidade cidade)
        {
            repository.Adicionar(cidade);
        }

        public void Remover(Cidade cidade)
        {
            repository.Remover(cidade);
        }

        public List<Cidade> Listar()
        {
            return repository.Listar();
        }
        public Cidade BuscarTimePorId(int id)
        {
            return repository.BuscarPorId(id);
        }
        public void Editar(int id, Cidade editCidade)
        {
            repository.Editar(id, editCidade);
        }
    }
}
