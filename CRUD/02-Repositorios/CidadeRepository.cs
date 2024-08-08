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
        public SimuladorBD bd { get; set; }

        public CidadeRepository(SimuladorBD bdPreenchido)
        {
            bd = bdPreenchido;
        }

        public void Adicionar(Cidade cidade)
        {
            bd.Cidades.Add(cidade);
        }
        public void Remover(Cidade cidade)
        {
            bd.Cidades.Remove(cidade);
        }
        public void Editar()
        {

        }
        public List<Cidade> Listar()
        {
            return bd.Cidades.ToList();
        }

        public Cidade BuscarPorId(int id)
        {
            foreach (Cidade c in bd.Cidades)
            {
                if (id == c.Id)
                {
                    return c;
                }
            }
            return null;
        }
    }
}
