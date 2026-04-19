using EfCoreDbFirst.Data;
using EfCoreDbFirst.Data.Models;

namespace EfCoreDbFirst;

class Program
{
    static void Main(string[] args)
    {
        // Microsoft.EntityFrameworkCore
        // Npgsql.EntityFrameworkCore.PostgreSQL
        
        
        // Microsoft.Extensions.Configuration
        // Microsoft.Extensions.Configuration.Json
        
        var db = new MyPostgresContext();
        
        //CREATE 
        var newAuthor = new Author()
        {
            first_name = "John",
            last_name = "Doe",
        };
        //
        // db.table_authors.Add(newAuthor);
        //
        // db.SaveChanges();
        
        //UPDATE
        
        // var firstAuthor = db.table_authors.FirstOrDefault();
        //
        // firstAuthor.first_name = "FirstName";
        //
        // db.table_authors.Update(firstAuthor);
        //
        // db.SaveChanges();
        
        //DELETE
        
        var authorToDelete = db.table_authors
            .FirstOrDefault(a => a.first_name == newAuthor.first_name 
                                 && a.last_name == newAuthor.last_name);
        
        db.table_authors.Remove(authorToDelete);
        
        db.SaveChanges();
        
        
        
        // READ
        var authors = db.table_authors.ToList();
        
        foreach (var author in authors) Console.WriteLine(author);
        //
        // var books = db.Books.ToList();
        // foreach (var book in books) Console.WriteLine(book);
        
        
        
    }
}