using Microsoft.AspNetCore.Mvc;

namespace GestaoLivraria.Controllers;

[ApiController]
public class BookController : MainAPIController
{

    // NOTE: There is no error handling in this entire API, for now...

    /// <summary>
    /// Creates a new book.
    /// </summary>
    /// <param name="request"></param>
    /// <returns> RequestCreateBookJSON </returns>
    [HttpPost("create-book")]
    [ProducesResponseType(typeof(Book), StatusCodes.Status201Created)]
    public IActionResult CreateBook([FromBody] Book request)
    {
        // Creates a new response object to return the fields
        var response = new Book
        {
            Id = request.Id,
            Author = request.Author,
            Title = request.Title,
            BookGenre = request.BookGenre,
            Price = request.Price,
            Quantity = request.Quantity
        };

        // Add this book to main array
        AddBook(response);

        return Created(string.Empty, response);
    }

    /// <summary>
    /// Returns all created books
    /// </summary>
    /// <param></param>
    /// <returns></returns>
    [HttpGet("all-books")]
    [ProducesResponseType(typeof(List<Book>), StatusCodes.Status200OK)]
    public IActionResult GetAllBooks()
    {
        // Returns the list
        return Ok(AllBooks);
    }

    // Update a book
    [HttpPut("update/{idToSearchFor}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult UpdateBookInfo([FromRoute] int idToSearchFor, [FromBody] Book updatedBookInfo)
    {
        // Search for this book, assuming it was created beforehand
        foreach (var book in AllBooks) 
        {
            if (idToSearchFor == book.Id)
            {
                // TODO: optimize this ugly code
                book.Title = updatedBookInfo.Title;
                book.Author = updatedBookInfo.Author;
                book.BookGenre = updatedBookInfo.BookGenre;
                book.Price = updatedBookInfo.Price;
                book.Quantity = updatedBookInfo.Quantity;
            }
        }
        return NoContent();
    }

    // Delete a book
    [HttpDelete("delete/{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult DeleteBook([FromRoute] int id)
    {
        // Search book (TODO: implement this search logic in a separate thing eventually)
        foreach (var book in AllBooks)
        {
            if (id == book.Id)
            {
                AllBooks.Remove(book);
                break;
            }
        }
        return NoContent();
    }
}
