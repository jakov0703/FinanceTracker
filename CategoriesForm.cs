using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceTracker
{
    public partial class CategoriesForm : Form
    {
        public CategoriesForm()
        {
            InitializeComponent();
        }

        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            using (var ctx = new RWA2425_jvrbanjac22_DBEntities())
            {
                var data = ctx.Categories
                    .Select(c => new { c.CategoryId, c.Name, c.Type, c.IsActive })
                    .OrderBy(c => c.Name)
                    .ToList();

                dataGridViewCategories.DataSource = data;
            }

            if (dataGridViewCategories.Columns["CategoryId"] != null)
                dataGridViewCategories.Columns["CategoryId"].Visible = false;
        }
    }
}
