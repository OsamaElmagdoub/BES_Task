namespace BES_Task.Data.Models
{
    public class Department : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Manager> Managers { get; set; } = new List<Manager>();

    }
}
