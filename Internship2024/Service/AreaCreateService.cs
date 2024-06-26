﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Internship2024.Model;

namespace Internship2024.Service
{
    class AreaCreateService : IAreaCreateService
    {
        private readonly IAreaCreateRepository  _repository;

        public AreaCreateService(IAreaCreateRepository repository)
        {
            _repository = repository;
        }

      

        public void CreateArea(AreaCreate area)
        {
            _repository.CreateArea(area);
        }

        public string GetUniqueCodeFromRepo()
        {
           string uCode =  _repository.GetUniqueCodeFromDatabase();
           return uCode;
        }
    }
}
