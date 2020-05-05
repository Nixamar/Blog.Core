﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Blog.Core.IRepository;
using Blog.Core.IRepository.Base;
using Blog.Core.IServices;
using Blog.Core.Model.Models;
using Blog.Core.Services.BASE;

namespace Blog.Core.Services
{
    public class AdvertisementServices : BaseServices<Advertisement>, IAdvertisementServices
    {
        private readonly IBaseRepository<Advertisement> _dal;

        public AdvertisementServices(IBaseRepository<Advertisement> dal)
        {
            base.BaseDal = dal;
            _dal = dal;
        }

        public void ReturnExp()
        {

            int a = 1;
            int b = 0;

            int c = a / b;
        }

        //public IAdvertisementRepository dal = new AdvertisementRepository();
        //public int Sum(int i, int j)
        //{
        //    return base.Sum(i, j);

        //}


        //public int Add(Advertisement model)
        //{
        //    return base.Add(model);
        //}

        //public bool Delete(Advertisement model)
        //{
        //    return base.Delete(model);
        //}

        //public List<Advertisement> Query(Expression<Func<Advertisement, bool>> whereExpression)
        //{
        //    return base.Query(whereExpression);

        //}

        //public bool Update(Advertisement model)
        //{
        //    return base.Update(model);
        //}

    }
}
