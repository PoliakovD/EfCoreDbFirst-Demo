using System.ComponentModel.DataAnnotations.Schema;

namespace EfCoreDbFirst.Data.Models;

[Table("table_books")]
public record Book
{
    [Column("id")]
    public int Id { get; set; }
    [Column("title")]
    public string Title { get; set; }
    [Column("year_of_publication")]
    public int YearOfPublication { get; set; }
    [Column("author_id")]
    public int AuthorId { get; set; }
}