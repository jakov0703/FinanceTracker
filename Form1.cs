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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (var ctx = new RWA2425_jvrbanjac22_DBEntities()) // naziv konteksta, vidi u .edmx
                {
                    var usersCount = ctx.Users.Count();
                    var catsCount = ctx.Categories.Count();
                    var txCount = ctx.Transactions.Count();

                    MessageBox.Show($"Connected!\nUsers: {usersCount}\nCategories: {catsCount}\nTransactions: {txCount}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB error: " + ex.Message);
            }
        }
    }
}
