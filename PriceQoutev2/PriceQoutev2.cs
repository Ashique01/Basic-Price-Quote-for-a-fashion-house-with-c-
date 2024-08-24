using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PriceQoutev2
{
    public partial class PriceQoutev2 : Form
    {
        public PriceQoutev2()
        {
            InitializeComponent();
        }

        double BaseGoodQuality, BaseBetterQuality, BaseBestQuality, PackageStandard, PackagePremium;
        double basePrice, pkgPrice, tradeIn, subTotal, salesTax, totalPrice;

       
        private void PriceQoutev2_Load(object sender, EventArgs e)
        {
            BaseGoodQuality = 500;
            BaseBetterQuality = 1200;
            BaseBestQuality = 2000;

            PackageStandard = 500;
            PackagePremium = 1500;

            basePrice = 0;
            pkgPrice = 0;
            tradeIn = '0';
        }
        private void goodQuality_CheckedChanged(object sender, EventArgs e)
        {
            lblBasePrice.Text = BaseGoodQuality.ToString("c");
            basePrice = BaseGoodQuality;
        }

        private void betterQualty_CheckedChanged(object sender, EventArgs e)
        {
            lblBasePrice.Text = BaseBetterQuality.ToString("c");
            basePrice = BaseBetterQuality;
        }
        private void bestQuality_CheckedChanged(object sender, EventArgs e)
        {
            lblBasePrice.Text = BaseBestQuality.ToString("c");
            basePrice = BaseBestQuality;
        }
        private void standardPkg_CheckedChanged(object sender, EventArgs e)
        {
            lblPkgPrice.Text = PackageStandard.ToString("C");
            pkgPrice = PackageStandard;
        }

        private void premiumPkg_CheckedChanged(object sender, EventArgs e)
        {
            lblPkgPrice.Text = PackagePremium.ToString("c");
            pkgPrice = PackagePremium;
        }

        private void btnClearInput_Click(object sender, EventArgs e)
        {
            RdogoodQuality.Checked = false;
            RdobetterQualty.Checked = false;
            RdobestQuality.Checked = false;

            RdostandardPkg.Checked = false;
            RdopremiumPkg.Checked = false;

            txtName.Text = "";

            lblBasePrice.Text = "";
            lblPkgPrice.Text = "";

            TxTradeIn.Text = "0";

            lblSubTotal.Text = "";
            lblSalesTax.Text = "";
            lblTotalPrice.Text = "";

            basePrice = 0;
            pkgPrice = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void picCompute_Click(object sender, EventArgs e)
        {
            tradeIn = double.Parse(TxTradeIn.Text);

            subTotal = basePrice + pkgPrice - tradeIn;
            salesTax = subTotal * 0.1;
            totalPrice = subTotal + salesTax;

            TxTradeIn.Text = tradeIn.ToString("c");
            lblSubTotal.Text = subTotal.ToString("c");
            lblSalesTax.Text = salesTax.ToString("c");
            lblTotalPrice.Text = totalPrice.ToString("c");


        }



    }
}
