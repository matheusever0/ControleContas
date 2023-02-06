using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleContas.Entity.Interfaces.UnitOfWork
{
    public interface IUnidadeTrabalhoApplication : IDisposable
    {

        Task SalvarMudancasEmBancoAsync();

        void IniciarTransacao();

        void EncerrarTransacao();
    }
}
