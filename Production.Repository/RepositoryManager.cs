using Production.Contracts;
using Production.Entities.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production.Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private AdventureWorks2019Context _adventureContext;
        private IProductRepository _productRepository;

        public RepositoryManager(AdventureWorks2019Context adventureContext, IProductRepository productRepository)
        {
            _adventureContext = adventureContext;
            _productRepository = productRepository;
        }
        
        public IProductRepository ProductRepository
        {
            get
            {
                if(_productRepository == null)
                {
                    _productRepository = new ProductRepository(_adventureContext);
                }
                return _productRepository;
            }
        }

        public void Save()
        {
            _adventureContext.SaveChanges();
        }
    }
}
