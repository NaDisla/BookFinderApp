using BookFinderApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BookFinderApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        Book objBook = new Book();
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnSearchBook_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitleBook.Text))
            {
                txtTitleBook.Placeholder = "Debe ingresar un título";
                txtTitleBook.PlaceholderColor = Color.Red;
            }
            else
            {
                List<Book> getAllBooks = await objBook.GenerateBooks();
                List<Book> getFilteredBooks = getAllBooks.FindAll(x => x.Title.Contains(txtTitleBook.Text));
                if(getFilteredBooks.Count == 0)
                {
                    await DisplayAlert("Libro no encontrado.","No se ha encontrado el libro indicado.","OK");
                }
                else
                {
                    ObservableCollection<Book> finalBooks = new ObservableCollection<Book>(getFilteredBooks);
                    lvwBooks.ItemsSource = finalBooks;
                    lblResults.IsVisible = true;
                    booksFrame.IsVisible = true;
                }
            }
        }
    }
}