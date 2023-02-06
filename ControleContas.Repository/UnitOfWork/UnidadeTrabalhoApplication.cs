using ControleContas.Repository.Context.Application;
using System;
using ControleContas.Entity.Interfaces.UnitOfWork;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleContas.Repository.UnitOfWork
{
    public class UnidadeTrabalhoApplication : IUnidadeTrabalhoApplication, IDisposable
    {
        private readonly ApplicationContext contexto;

        public UnidadeTrabalhoApplication(ApplicationContext _contexto)
        {
            contexto = _contexto;
        }

        public void Dispose() => contexto.DisposeAsync();

        public void EncerrarTransacao()
        {
            throw new NotImplementedException();
        }

        public void IniciarTransacao()
        {
            throw new NotImplementedException();
        }

        public async Task SalvarMudancasEmBancoAsync()
        {
            try
            {
                await contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
