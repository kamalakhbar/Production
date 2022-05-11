using Production.Contracts;
using Production.Entities.Context;
using Production.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production.Repository
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(AdventureWorks2019Context adventure) : base(adventure)
        {

        }
    }
}
