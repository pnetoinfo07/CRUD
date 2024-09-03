using CRUD._01_Entidades;
using CRUD.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD._02_Repositorios
{
    public class CidadeRepository
    {
        public CidadeRepository()
        {           
        }

        public void Adicionar(Cidade cidade)
        {
            throw new Exception();
        }
        public void Remover(Cidade cidade)
        {
            throw new Exception();
        }
        public void Editar(int id, Cidade editCidade)
        {
            Cidade cidadeDoBancoDados = BuscarPorId(id);

            cidadeDoBancoDados.Nome = editCidade.Nome;
            cidadeDoBancoDados.Qtd_habitantes = editCidade.Qtd_habitantes;
        }
        public List<Cidade> Listar()
        {
            throw new Exception();
        }

        public Cidade BuscarPorId(int id)
        {
            throw new Exception();
        }
    }
}
