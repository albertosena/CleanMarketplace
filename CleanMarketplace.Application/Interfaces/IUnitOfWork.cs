using CleanMarketplace.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMarketplace.Application.Interfaces
{
    public interface IUnitOfWork
    {
        IProdutoRepository Produtos { get; }
    }
}
