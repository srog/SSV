namespace CMS.Models
{
    public class ToDoItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        public int Status { get; set; }
    }
}