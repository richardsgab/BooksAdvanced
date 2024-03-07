namespace BooksAdvanced
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblError = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lstBooks = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.lblIdInvisible = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchBy = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.rdbById = new System.Windows.Forms.RadioButton();
            this.rdbByTitle = new System.Windows.Forms.RadioButton();
            this.rdbByCountry = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Firebrick;
            this.lblError.Location = new System.Drawing.Point(74, 380);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(52, 18);
            this.lblError.TabIndex = 29;
            this.lblError.Text = "label1";
            this.lblError.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(77, 459);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(173, 39);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(613, 487);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(114, 41);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Delete Entry";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lstBooks
            // 
            this.lstBooks.FormattingEnabled = true;
            this.lstBooks.Location = new System.Drawing.Point(377, 217);
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.Size = new System.Drawing.Size(350, 238);
            this.lstBooks.TabIndex = 26;
            this.lstBooks.SelectedIndexChanged += new System.EventHandler(this.lstBooks_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(77, 412);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(173, 32);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Insert";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(74, 341);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(86, 16);
            this.lblDescription.TabIndex = 24;
            this.lblDescription.Text = "Description";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(74, 285);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(43, 16);
            this.lblPrice.TabIndex = 23;
            this.lblPrice.Text = "Price";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(74, 240);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(51, 16);
            this.lblAuthor.TabIndex = 22;
            this.lblAuthor.Text = "Author";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(74, 194);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(38, 16);
            this.lblTitle.TabIndex = 21;
            this.lblTitle.Text = "Title";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(74, 119);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(67, 18);
            this.lblCountry.TabIndex = 20;
            this.lblCountry.Text = "Country";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(194, 240);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(100, 20);
            this.txtAuthor.TabIndex = 19;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(194, 285);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 18;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(194, 338);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 20);
            this.txtDescription.TabIndex = 17;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(194, 191);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 16;
            // 
            // cmbCountry
            // 
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(194, 119);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(121, 21);
            this.cmbCountry.TabIndex = 15;
            // 
            // lblIdInvisible
            // 
            this.lblIdInvisible.AutoSize = true;
            this.lblIdInvisible.Location = new System.Drawing.Point(194, 82);
            this.lblIdInvisible.Name = "lblIdInvisible";
            this.lblIdInvisible.Size = new System.Drawing.Size(0, 13);
            this.lblIdInvisible.TabIndex = 30;
            this.lblIdInvisible.Visible = false;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(613, 359);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 20);
            this.lblCount.TabIndex = 31;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(77, 513);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(173, 33);
            this.btnUpdate.TabIndex = 32;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(374, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Search Book by";
            // 
            // btnSearchBy
            // 
            this.btnSearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBy.Location = new System.Drawing.Point(377, 172);
            this.btnSearchBy.Name = "btnSearchBy";
            this.btnSearchBy.Size = new System.Drawing.Size(155, 29);
            this.btnSearchBy.TabIndex = 37;
            this.btnSearchBy.Text = "Search and Show";
            this.btnSearchBy.UseVisualStyleBackColor = true;
            this.btnSearchBy.Click += new System.EventHandler(this.btnSearchBy_Click);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(377, 487);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(121, 41);
            this.btnShow.TabIndex = 38;
            this.btnShow.Text = "Show Books";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(377, 119);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(225, 20);
            this.txtSearch.TabIndex = 39;
            // 
            // rdbById
            // 
            this.rdbById.AutoSize = true;
            this.rdbById.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbById.Location = new System.Drawing.Point(377, 65);
            this.rdbById.Name = "rdbById";
            this.rdbById.Size = new System.Drawing.Size(37, 19);
            this.rdbById.TabIndex = 43;
            this.rdbById.TabStop = true;
            this.rdbById.Text = "Id";
            this.rdbById.UseVisualStyleBackColor = true;
            // 
            // rdbByTitle
            // 
            this.rdbByTitle.AutoSize = true;
            this.rdbByTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbByTitle.Location = new System.Drawing.Point(445, 65);
            this.rdbByTitle.Name = "rdbByTitle";
            this.rdbByTitle.Size = new System.Drawing.Size(53, 19);
            this.rdbByTitle.TabIndex = 44;
            this.rdbByTitle.TabStop = true;
            this.rdbByTitle.Text = "Title";
            this.rdbByTitle.UseVisualStyleBackColor = true;
            // 
            // rdbByCountry
            // 
            this.rdbByCountry.AutoSize = true;
            this.rdbByCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbByCountry.Location = new System.Drawing.Point(529, 65);
            this.rdbByCountry.Name = "rdbByCountry";
            this.rdbByCountry.Size = new System.Drawing.Size(73, 19);
            this.rdbByCountry.TabIndex = 45;
            this.rdbByCountry.TabStop = true;
            this.rdbByCountry.Text = "Country";
            this.rdbByCountry.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 571);
            this.Controls.Add(this.rdbByCountry);
            this.Controls.Add(this.rdbByTitle);
            this.Controls.Add(this.rdbById);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnSearchBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblIdInvisible);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lstBooks);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.cmbCountry);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox lstBooks;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.Label lblIdInvisible;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchBy;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton rdbById;
        private System.Windows.Forms.RadioButton rdbByTitle;
        private System.Windows.Forms.RadioButton rdbByCountry;
    }
}

