namespace TodoApi.DTOs
{
    public class ItemDTO
    {

        public long Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
