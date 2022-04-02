using SmartCity.Dominio.Entidades;
using SmartCity.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCity.Aplicacao
{
    public class EstacaoRecargaApp : IEstacaoRecargaApp
    {
        IEstacaoRecarga _estacaoRecargaRepoInterface;
        public EstacaoRecargaApp(IEstacaoRecarga estacaoRecargaRepoInterface)
        {
            _estacaoRecargaRepoInterface = estacaoRecargaRepoInterface;
        }
        public void Adicionar(EstacaoRecarga obj)
        {
            _estacaoRecargaRepoInterface.Adicionar(obj);
        }

        public void Atualizar(EstacaoRecarga obj)
        {
            _estacaoRecargaRepoInterface.Atualizar(obj);
        }
        public void Excluir(EstacaoRecarga obj)
        {
            _estacaoRecargaRepoInterface.Excluir(obj);
        }
        public IReadOnlyList<EstacaoRecarga> Listar()
        {
            return _estacaoRecargaRepoInterface.Listar();
        }

        public EstacaoRecarga RecuperarPorId(Guid id)
        {
            return _estacaoRecargaRepoInterface.RecuperarPorId(id);
        }
    }
}
