﻿using career.DAL.Utilities.Results;
using career.DTO.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace career.BLL.Abstract
{
    public interface ICountService
    {
        IDataResult<CountResponse> Count();
    }
}
