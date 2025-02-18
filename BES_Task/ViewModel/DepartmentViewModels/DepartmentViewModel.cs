using BES_Task.ViewModel.ManagerViewModels;
using System.ComponentModel.DataAnnotations;

namespace BES_Task.ViewModel.DepartmentViewModels
{
    public class DepartmentViewModel
    {

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<ManagerViewModel> Managers { get; set; } = new ();
    }
}
