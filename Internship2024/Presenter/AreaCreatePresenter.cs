using System;
using Internship2024.Model;
using Internship2024.Service;
using Internship2024.View;

namespace Internship2024.Presenter
{
    public class AreaCreatePresenter
    {
        private readonly IAreaCreateService _areaCreateService;
        private readonly IAreaCreateView _areaCreateView;

        public AreaCreatePresenter(IAreaCreateView view, IAreaCreateService service
            )
        {
            _areaCreateView = view;
            _areaCreateService = service;
            view.Presenter = this;
            
            string uniqueCode = _areaCreateService.GetUniqueCodeFromRepo();
            _areaCreateView.UniqueCode = uniqueCode;
            LoadDepartments();
        }

       
        public void CreateArea(pl_areaRow _areaRow)
        {
            // AreaCreate create = new AreaCreate
            // {
            //     UniqueCode = _areaCreateView.UniqueCode,
            //     AreaName = _areaCreateView.AreaName,
            //     AreaCode = _areaCreateView.AreaCode,
            //     DepartmentName = _areaCreateView.DepartmentName,
            //     Description = _areaCreateView.Description,
            //     IsActive = _areaCreateView.IsActive,
            //     IsForDispensing = _areaCreateView.IsForDispensing
            // };

            try
            {
                _areaCreateService.CreateArea(_areaRow);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            // _areaCreateService.CreateArea(create);
        }
        
        public void LoadDepartments()
        {
            var departments = _areaCreateService.LoadDepartmentsFromDB();
            _areaCreateView.DisplayDepartments(departments);
        }
        
        
    }
    
   

}