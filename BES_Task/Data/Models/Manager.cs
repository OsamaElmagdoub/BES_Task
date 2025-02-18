namespace BES_Task.Data.Models
{
    public class Manager : BaseModel
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
