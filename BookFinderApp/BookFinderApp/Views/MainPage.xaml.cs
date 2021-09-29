using BookFinderApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        private void btnSearchBook_Clicked(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtTitleBook.Text))
            {
                txtTitleBook.Placeholder = "Debe ingresar un título";
                txtTitleBook.PlaceholderColor = Color.Red;
            }
            else
            {
                ObservableCollection<Book> getBooks = new ObservableCollection<Book>(objBook.GenerateBooks());
                lvwBooks.ItemsSource = getBooks;
                lblResults.IsVisible = true;
                booksFrame.IsVisible = true;
            }
        }
    }
}