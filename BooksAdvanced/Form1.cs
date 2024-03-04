using LibraryStoreProcedure.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksAdvanced
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.CountryId = (int)cmbCountry.SelectedValue;
            book.Title = txtTitle.Text;
            book.Author = txtAuthor.Text;
            book.Price = decimal.Parse(txtPrice.Text);
            book.Description = txtDescription.Text;

            BookRepo bookrepo = new BookRepo();
            bookrepo.AddBook(book);
        }

        private void Form1_Load(object sender, EventArgs e)
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
    }
}
