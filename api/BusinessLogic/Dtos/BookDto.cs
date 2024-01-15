namespace BusinessLogic.Dtos;

public class BookDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int AuthorId { get; set; }
    public string AuthorName { get; set; }
}