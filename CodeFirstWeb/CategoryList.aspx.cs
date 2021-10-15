using CodeFirstWeb.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CodeFirstWeb
{
    public partial class CategoryList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void LoadCategories()
        {
            NorthwindContext context = new NorthwindContext();
            CategoryListe.DataSource = (from x in context.Categories
                                       select x).ToList();
            CategoryListe.DataBind();
        }
    }
}