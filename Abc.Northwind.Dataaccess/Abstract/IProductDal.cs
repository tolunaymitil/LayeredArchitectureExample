﻿using Abc.Core.DataAccess;
using Abc.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abc.Northwind.Dataaccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
    }
}
