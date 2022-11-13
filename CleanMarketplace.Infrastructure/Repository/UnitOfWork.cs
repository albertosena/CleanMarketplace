using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanMarketplace.Application.Interfaces;

namespace CleanMarketplace.Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(IProdutoRepository produtoRepository)
        {
            Produtos = produtoRepository;
        }

        public IProdutoRepository Produtos { get; set; }
    }
}
