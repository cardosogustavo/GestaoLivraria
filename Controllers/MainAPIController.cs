using Microsoft.AspNetCore.Mvc;

namespace GestaoLivraria.Controllers;
[Route("library/[controller]")]
[ApiController]
public class MainAPIController : ControllerBase
{

    // List of ints to hold all the books
    protected static List<Book> AllBooks = [];

    // Method to add the Book to the list
    protected void AddBook(Book book) => AllBooks.Add(book);
}
