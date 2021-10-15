using CodeFirstWeb.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CodeFirstWeb
{
    public partial class ProductList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            NorthwindContext context = new NorthwindContext();
            ProductListe.DataSource = (from x in context.Products
                                       select x).ToList();
            ProductListe.DataBind();
        }
    }
}