﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandsDal _brandDal;

        public BrandManager(IBrandsDal brandDal)
        {
            _brandDal = brandDal;
        }

        public List<Brand> GetAll()
        {
          
            return _brandDal.GetAll();
        }

        
        public Brand GetById(int brandId)
        {
            return _brandDal.Get(c => c.BrandId == brandId);
        }
    }
}
