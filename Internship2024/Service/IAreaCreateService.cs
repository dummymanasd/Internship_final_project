using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Internship2024.Model;

namespace Internship2024.Service
{
    public interface IAreaCreateService
    {
        void CreateArea(pl_areaRow _areaRow);

        string GetUniqueCodeFromRepo();
    }
    
}
