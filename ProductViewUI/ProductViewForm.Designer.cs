namespace ProductViewUI
{
    partial class ProductViewForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductViewForm));
            menuStrip = new MenuStrip();
            súborToolStripMenuItem = new ToolStripMenuItem();
            ukončiťToolStripMenuItem = new ToolStripMenuItem();
            katalógToolStripMenuItem = new ToolStripMenuItem();
            pridaťProduktToolStripMenuItem = new ToolStripMenuItem();
            pozrieťProduktyToolStripMenuItem = new ToolStripMenuItem();
            pomocníkToolStripMenuItem = new ToolStripMenuItem();
            oAplikáciiToolStripMenuItem = new ToolStripMenuItem();
            productListGridView = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            availableQuantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            authorsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productViewBindingSource = new BindingSource(components);
            splitter1 = new Splitter();
            productDetailGridView = new DataGridView();
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            iSBNDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            availableQuantityDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            publicationDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            authorsDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            categoryNameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productListGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productViewBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productDetailGridView).BeginInit();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { súborToolStripMenuItem, katalógToolStripMenuItem, pomocníkToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1200, 24);
            menuStrip.TabIndex = 3;
            menuStrip.Text = "menuStrip1";
            // 
            // súborToolStripMenuItem
            // 
            súborToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ukončiťToolStripMenuItem });
            súborToolStripMenuItem.Name = "súborToolStripMenuItem";
            súborToolStripMenuItem.Size = new Size(50, 20);
            súborToolStripMenuItem.Text = "&Súbor";
            // 
            // ukončiťToolStripMenuItem
            // 
            ukončiťToolStripMenuItem.Name = "ukončiťToolStripMenuItem";
            ukončiťToolStripMenuItem.Size = new Size(180, 22);
            ukončiťToolStripMenuItem.Text = "&Ukončiť";
            ukončiťToolStripMenuItem.Click += ukončiťToolStripMenuItem_Click;
            // 
            // katalógToolStripMenuItem
            // 
            katalógToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pridaťProduktToolStripMenuItem, pozrieťProduktyToolStripMenuItem });
            katalógToolStripMenuItem.Name = "katalógToolStripMenuItem";
            katalógToolStripMenuItem.Size = new Size(59, 20);
            katalógToolStripMenuItem.Text = "&Katalóg";
            // 
            // pridaťProduktToolStripMenuItem
            // 
            pridaťProduktToolStripMenuItem.Name = "pridaťProduktToolStripMenuItem";
            pridaťProduktToolStripMenuItem.Size = new Size(162, 22);
            pridaťProduktToolStripMenuItem.Text = "&Pridať produkt";
            // 
            // pozrieťProduktyToolStripMenuItem
            // 
            pozrieťProduktyToolStripMenuItem.Name = "pozrieťProduktyToolStripMenuItem";
            pozrieťProduktyToolStripMenuItem.Size = new Size(162, 22);
            pozrieťProduktyToolStripMenuItem.Text = "P&ozrieť produkty";
            // 
            // pomocníkToolStripMenuItem
            // 
            pomocníkToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { oAplikáciiToolStripMenuItem });
            pomocníkToolStripMenuItem.Name = "pomocníkToolStripMenuItem";
            pomocníkToolStripMenuItem.Size = new Size(73, 20);
            pomocníkToolStripMenuItem.Text = "&Pomocník";
            // 
            // oAplikáciiToolStripMenuItem
            // 
            oAplikáciiToolStripMenuItem.Name = "oAplikáciiToolStripMenuItem";
            oAplikáciiToolStripMenuItem.Size = new Size(129, 22);
            oAplikáciiToolStripMenuItem.Text = "&O aplikácii";
            // 
            // productListGridView
            // 
            productListGridView.AllowUserToAddRows = false;
            productListGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(238, 239, 245);
            productListGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            productListGridView.AutoGenerateColumns = false;
            productListGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productListGridView.BorderStyle = BorderStyle.None;
            productListGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(20, 25, 70);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle2.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            productListGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            productListGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productListGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, availableQuantityDataGridViewTextBoxColumn, authorsDataGridViewTextBoxColumn, categoryNameDataGridViewTextBoxColumn });
            productListGridView.DataSource = productViewBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle3.ForeColor = Color.RoyalBlue;
            dataGridViewCellStyle3.SelectionBackColor = Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            productListGridView.DefaultCellStyle = dataGridViewCellStyle3;
            productListGridView.Dock = DockStyle.Top;
            productListGridView.Location = new Point(0, 24);
            productListGridView.MultiSelect = false;
            productListGridView.Name = "productListGridView";
            productListGridView.ReadOnly = true;
            productListGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productListGridView.Size = new Size(1200, 124);
            productListGridView.TabIndex = 4;
            productListGridView.CellContentClick += ProductListGridView_CellClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Title";
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // availableQuantityDataGridViewTextBoxColumn
            // 
            availableQuantityDataGridViewTextBoxColumn.DataPropertyName = "AvailableQuantity";
            availableQuantityDataGridViewTextBoxColumn.HeaderText = "Available Quantity";
            availableQuantityDataGridViewTextBoxColumn.Name = "availableQuantityDataGridViewTextBoxColumn";
            availableQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // authorsDataGridViewTextBoxColumn
            // 
            authorsDataGridViewTextBoxColumn.DataPropertyName = "Authors";
            authorsDataGridViewTextBoxColumn.HeaderText = "Authors";
            authorsDataGridViewTextBoxColumn.Name = "authorsDataGridViewTextBoxColumn";
            authorsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
            categoryNameDataGridViewTextBoxColumn.HeaderText = "Name";
            categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
            categoryNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productViewBindingSource
            // 
            productViewBindingSource.DataSource = typeof(ProductViewLibrary.Views.ProductView);
            // 
            // splitter1
            // 
            splitter1.Dock = DockStyle.Top;
            splitter1.Location = new Point(0, 148);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(1200, 11);
            splitter1.TabIndex = 5;
            splitter1.TabStop = false;
            // 
            // productDetailGridView
            // 
            productDetailGridView.AllowUserToAddRows = false;
            productDetailGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(238, 239, 245);
            productDetailGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            productDetailGridView.AutoGenerateColumns = false;
            productDetailGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productDetailGridView.BorderStyle = BorderStyle.None;
            productDetailGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(20, 25, 70);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle5.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            productDetailGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            productDetailGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productDetailGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, titleDataGridViewTextBoxColumn1, iSBNDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn1, descriptionDataGridViewTextBoxColumn1, availableQuantityDataGridViewTextBoxColumn1, publicationDateDataGridViewTextBoxColumn, authorsDataGridViewTextBoxColumn1, categoryNameDataGridViewTextBoxColumn1 });
            productDetailGridView.DataSource = productViewBindingSource;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle6.ForeColor = Color.RoyalBlue;
            dataGridViewCellStyle6.SelectionBackColor = Color.ForestGreen;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            productDetailGridView.DefaultCellStyle = dataGridViewCellStyle6;
            productDetailGridView.Dock = DockStyle.Fill;
            productDetailGridView.Location = new Point(0, 159);
            productDetailGridView.MultiSelect = false;
            productDetailGridView.Name = "productDetailGridView";
            productDetailGridView.ReadOnly = true;
            productDetailGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productDetailGridView.Size = new Size(1200, 348);
            productDetailGridView.TabIndex = 6;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn1.HeaderText = "Id";
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn1
            // 
            titleDataGridViewTextBoxColumn1.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn1.HeaderText = "Title";
            titleDataGridViewTextBoxColumn1.Name = "titleDataGridViewTextBoxColumn1";
            titleDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            iSBNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn1.HeaderText = "Price";
            priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            priceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            descriptionDataGridViewTextBoxColumn1.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn1.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            descriptionDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // availableQuantityDataGridViewTextBoxColumn1
            // 
            availableQuantityDataGridViewTextBoxColumn1.DataPropertyName = "AvailableQuantity";
            availableQuantityDataGridViewTextBoxColumn1.HeaderText = "Available Quantity";
            availableQuantityDataGridViewTextBoxColumn1.Name = "availableQuantityDataGridViewTextBoxColumn1";
            availableQuantityDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // publicationDateDataGridViewTextBoxColumn
            // 
            publicationDateDataGridViewTextBoxColumn.DataPropertyName = "PublicationDate";
            publicationDateDataGridViewTextBoxColumn.HeaderText = "Publication Date";
            publicationDateDataGridViewTextBoxColumn.Name = "publicationDateDataGridViewTextBoxColumn";
            publicationDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // authorsDataGridViewTextBoxColumn1
            // 
            authorsDataGridViewTextBoxColumn1.DataPropertyName = "Authors";
            authorsDataGridViewTextBoxColumn1.HeaderText = "Authors";
            authorsDataGridViewTextBoxColumn1.Name = "authorsDataGridViewTextBoxColumn1";
            authorsDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // categoryNameDataGridViewTextBoxColumn1
            // 
            categoryNameDataGridViewTextBoxColumn1.DataPropertyName = "CategoryName";
            categoryNameDataGridViewTextBoxColumn1.HeaderText = "Category";
            categoryNameDataGridViewTextBoxColumn1.Name = "categoryNameDataGridViewTextBoxColumn1";
            categoryNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ProductViewForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 507);
            Controls.Add(productDetailGridView);
            Controls.Add(splitter1);
            Controls.Add(productListGridView);
            Controls.Add(menuStrip);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            ForeColor = Color.RoyalBlue;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "ProductViewForm";
            Text = "Product View";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)productListGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)productViewBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)productDetailGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip;
        private ToolStripMenuItem súborToolStripMenuItem;
        private ToolStripMenuItem ukončiťToolStripMenuItem;
        private ToolStripMenuItem katalógToolStripMenuItem;
        private ToolStripMenuItem pridaťProduktToolStripMenuItem;
        private ToolStripMenuItem pozrieťProduktyToolStripMenuItem;
        private ToolStripMenuItem pomocníkToolStripMenuItem;
        private ToolStripMenuItem oAplikáciiToolStripMenuItem;
        private DataGridView productListGridView;
        private BindingSource productViewBindingSource;
        private Splitter splitter1;
        private DataGridView productDetailGridView;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn availableQuantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn authorsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn availableQuantityDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn publicationDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn authorsDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn1;
    }
}