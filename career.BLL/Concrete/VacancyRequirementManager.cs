﻿using AutoMapper;
using career.BLL.Abstract;
using career.DAL.DataAccess;
using career.DTO.VacancyRequirementDto;
using career.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace career.BLL.Concrete
{
    public class VacancyRequirementManager : IVacancyRequirementService
    {
        IMapper _mapper;
        IUnitOfWork _unitOfWork;
        public VacancyRequirementManager(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public void DeleteVacancyRequirement(int id)
        {
        }
    }
}
