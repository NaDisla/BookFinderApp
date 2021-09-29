using System.Collections.Generic;

namespace BookFinderApp.Models
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string PublishedDate  { get; set; }
        public List<Book> ListBooks { get; set; }
        public List<Book> GenerateBooks()
        {
            ListBooks = new List<Book>() {
            new Book(){Title = "50 Sombras de Grey", Author = "Los Grey", PublishedDate = "01/05/2000"},
            new Book(){Title = "Once Minutos", Author = "Paulo Coelho", PublishedDate = "21/03/2010"},
            new Book(){Title = "Cien Años de Soledad", Author = "Gabriel García Márquez", PublishedDate = "20/07/1995"},
            new Book(){Title = "Amando a Pablo, odiando a Escobar", Author = "Virginia Vallejo", PublishedDate = "15/10/2011"},
            new Book(){Title = "Hay un país en el mundo", Author = "Pedro Mir", PublishedDate = "08/04/2016"},
            new Book(){Title = "El Cartel de los Sapos", Author = "Robert Godoy", PublishedDate = "09/05/1990"},
            new Book(){Title = "Los estudiantes de JR", Author = "José Romero", PublishedDate = "20/12/2000"}
            };
            return ListBooks;
        }
    }
}
