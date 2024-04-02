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
        }

       
        public void CreateArea()
        {
            AreaCreate create = new AreaCreate
            {
                UniqueCode = _areaCreateView.UniqueCode,
                AreaName = _areaCreateView.AreaName,
                AreaCode = _areaCreateView.AreaCode,
                DepartmentName = _areaCreateView.DepartmentName,
                Description = _areaCreateView.Description,
                IsActive = _areaCreateView.IsActive,
                IsForDispensing = _areaCreateView.IsForDispensing
            };

            _areaCreateService.CreateArea(create);
        }
        
        
        
    }
    
   

}