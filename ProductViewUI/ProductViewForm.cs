using ProductViewLibrary.Models;
using ProductViewLibrary.Views;
using ProductViewLibrary;
using ProductViewLibrary.Helpers;

namespace ProductViewUI
{
    public partial class ProductViewForm : Form
    {
        List<Product>? products = GlobalConfig.Connection?.GetProduct_All();
        private List<ProductView> productViews = [];

        public ProductViewForm()
        {
            InitializeComponent();
            GenerateData();
            WireProductListData();
        }

        private void GenerateData()
        {
            List<Product>? products = GlobalConfig.Connection?.GetProduct_All();
            if (products != null && products.Count != 0)
            {
                ProductViewMapper mapper = new();
                productViews = mapper.MapList(products);
            }
        }

        private void WireProductListData()
        {
            productListGridView.DataSource = productViews;
        }

        private void ProductListGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < productListGridView.Rows.Count)
            {
                var selectedProduct = productListGridView.Rows[e.RowIndex].DataBoundItem as ProductView;

                if (selectedProduct != null)
                {
                    productDetailGridView.DataSource = new List<ProductView> { selectedProduct };
                }
            }
        }

        private void ProductViewForm_Closing(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ukončiťToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
