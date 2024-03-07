using LibraryStoreProcedure.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BooksAdvanced
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblCount.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Insert();
        }

        private void Insert()
        {
            if ((int)cmbCountry.SelectedValue < 0)
            {
                MessageBox.Show("Choose a country");
                lblError.Visible = true;
                lblError.Text = "Error";
            }
            else
            {
                Book book = new Book();
                book.CountryId = (int)cmbCountry.SelectedValue;
                book.Title = txtTitle.Text;
                book.Author = txtAuthor.Text;
                book.Price = decimal.Parse(txtPrice.Text);
                book.Description = txtDescription.Text;

                BookRepo bookrepo = new BookRepo();
                bookrepo.AddBook(book);
                lblError.Visible = false;
                FillListBoxWithBooks();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillCountries();
            /*FillListBoxWithBooks();*/
        }

        private void FillCountries()
        {
            List<Country> countriesWithText = new List<Country>();
            countriesWithText.Add(new Country { Id = -1, Name = "Select Country" });

            Countryrepo countryrepo = new Countryrepo();
            List<Country> countrylist = countryrepo.GetCountries();

            countriesWithText.AddRange(countrylist);

            this.cmbCountry.Items.Clear();
            cmbCountry.DisplayMember = "Name";
            cmbCountry.ValueMember = "Id";
            this.cmbCountry.DataSource = countriesWithText;
        }

        private void FillListBoxWithBooks()
        {
            List<Book> booklist = new List<Book>();
            BookRepo bookrepo = new BookRepo();
            booklist = bookrepo.GetBooks();
            lstBooks.Items.Clear();
            foreach (Book book in booklist) 
            {
                lstBooks.Items.Add(book);
            }
            /*lblCount.Text = "Number of records: " + lstBooks.Items.Count.ToString();*/
        }

        private void lstBooks_SelectedIndexChanged(object sender, EventArgs e)
        {            
            Book book = new Book();
            book = (Book)lstBooks.SelectedItem;
            if (book != null) 
            {
                cmbCountry.SelectedIndex = book.CountryId;
                txtTitle.Text = book.Title;
                txtAuthor.Text = book.Author;
                txtPrice.Text = book.Price.ToString();
                txtDescription.Text = book.Description;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbCountry.SelectedIndex = 0;
            txtTitle.Text = "";
            txtAuthor.Text = "";
            txtPrice.Text = "";
            txtDescription.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book = (Book)lstBooks.SelectedItem; 
            if (book != null) 
            {
                BookRepo bookrepo = new BookRepo();
                bookrepo.DeleteBook(book);
            }
            FillListBoxWithBooks();
            /*lstBooks.Refresh();*/
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book = (Book)lstBooks.SelectedItem;
            book.CountryId = (int)cmbCountry.SelectedIndex;
            book.Title = txtTitle.Text;
            book.Author = txtAuthor.Text;
            book.Price = decimal.Parse(txtPrice.Text);
            book.Description = txtDescription.Text;

            if(book != null) 
            {
                book.Id =int.Parse(lblIdInvisible.Text);
                BookRepo bookrepo = new BookRepo(); 
                bookrepo.UpdateBook(book);
            }
            FillListBoxWithBooks();
        }

       /* private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }*/

        private void btnShow_Click(object sender, EventArgs e)
        {
            FillListBoxWithBooks();
        }

        private void btnSearchBy_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.Title = txtSearch.Text;
            book.Id = int.Parse(txtSearch.Text);
            book.CountryId = int.Parse(txtSearch.Text);
            BookRepo bookrepo = new BookRepo(); 
            
            if (rdbById.Checked) 
            {
                bookrepo.SearchBookByValue(book);
                FillListBoxWithBooks();
            }
            
            MessageBox.Show("Hola");
        }





            /*if (txtIdSearch.Text != "" || (txtNameSearch.Text != "") || (txtCounreySearch.Text != ""))
            {
                lstBooks.Items.Clear();
                lstBooks.Items.Add(book);
                FillListBoxWithBooks();
                bookrepo.SearchBookByValue(book);
            }*/
    }
}
