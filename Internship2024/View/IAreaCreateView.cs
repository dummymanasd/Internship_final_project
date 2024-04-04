using System.Collections.Generic;
using Internship2024.Model;
using Internship2024.Presenter;

namespace Internship2024.View
{
    public interface IAreaCreateView
    {
        string  UniqueCode { get; set; }

        string AreaName {
            get;
            set;
        }
        
        string AreaCode {
            get;
            set;
        }
        string Description {
            get;
            set;
        }
        // string DepartmentID {
        //     get;
        //     set;
        // }
        bool IsActive {
            get;
            set;
        }
        bool IsForDispensing {
            get;
            set;
        }
        AreaCreatePresenter Presenter { get; set; }

        void DisplayDepartments(List<Department> departments);
    }
}