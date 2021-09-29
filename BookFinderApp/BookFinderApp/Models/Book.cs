using System.Collections.Generic;

namespace BookFinderApp.Models
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string PublishedDate  { get; set; }
        public string Description { get; set; }
        public List<Book> ListBooks { get; set; }
        public List<Book> GenerateBooks()
        {
            ListBooks = new List<Book>() {
            new Book(){Title = "50 Sombras de Grey", Author = "Los Grey", Description = "Una historia muy morbosa", PublishedDate = "01/05/2000"},
            new Book(){Title = "Once Minutos", Author = "Paulo Coelho", Description = "Una joven que tarda 11 minutos en realizar sus labores desconocidas.", PublishedDate = "21/03/2010"},
            new Book(){Title = "Cien Años de Soledad", Author = "Gabriel García Márquez", Description = "El hombre que duró 100 años solo :(", PublishedDate = "20/07/1995"},
            new Book(){Title = "Amando a Pablo, odiando a Escobar", Author = "Virginia Vallejo", Description = "Las 2 caras que revelan quien realmente fue Pablo Escobar", PublishedDate = "15/10/2011"},
            new Book(){Title = "Hay un país en el mundo", Author = "Pedro Mir", Description = "La historia de un país de grandes maravillas", PublishedDate = "08/04/2016"},
            new Book(){Title = "El Cartel de los Sapos", Author = "Robert Godoy", Description = "La realidad de los grandes carteles", PublishedDate = "09/05/1990"},
            new Book(){Title = "Los estudiantes de JR", Author = "José Romero", Description = "Las grandes luchas por las que pasan los infelices estudiantes de JR :(", PublishedDate = "20/12/2000"}
            };
            return ListBooks;
        }
    }
}
