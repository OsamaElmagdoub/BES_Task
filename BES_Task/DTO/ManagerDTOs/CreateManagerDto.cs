namespace BES_Task.DTO.ManagerDTOs
{
    public class CreateManagerDto
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int DepartmentId { get; set; }
    }
}
