using Sy.Business.Repository;
using Sy.Core.ComplexTypes;
using Sy.Core.Entities;
using Sy.Forms.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sy.Forms
{
    public partial class Form1 : Form
    {
        private Repository<Product, Guid> _productRepo;
        public Form1()
        {
            InitializeComponent();
            gRbGiris.Visible = true;
            lbliSim.Visible = false;
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            frm.ShowDialog();
            if (StockSettings.UserInfo == null)
            {
                gRbGiris.Visible = true;
                lbliSim.Visible = false;
            }
            else
            {
                gRbGiris.Visible = false;
                lbliSim.Visible = true;
                lbliSim.Text = StockSettings.UserInfo.Display;
            }
        }

        private void btnKayıtOl_Click(object sender, EventArgs e)
        {
            RegisterForm frm = new RegisterForm();
            frm.ShowDialog();
           
        }

        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductForm frm = new ProductForm();
            frm.Show();
        }
    }
}
