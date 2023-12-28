﻿using GulYapan.API.Domain.Entity.Sql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GulYapanAPI.Application.Repositorys
{
    public interface ITBLEFATCARISReadRepository:IReadRepositoryNetsis<TBLEFATCARI>
    {
        Task<bool> EInvoiceRecipient(Expression<Func<TBLEFATCARI, bool>> metod);
    }
}
