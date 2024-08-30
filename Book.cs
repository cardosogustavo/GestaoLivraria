﻿namespace GestaoLivraria;

enum Genre
{
    Ficction,
    Romance,
    Mystery
}

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public string BookGenre { get; set; } = string.Empty;
    public double Price { get; set; }
    public int Quantity { get; set; }

}
