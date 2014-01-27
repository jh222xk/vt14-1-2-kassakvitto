using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kassakvitto
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.receipt.Visible = false;
        }

        protected void CalcDiscount_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                double subtotal = Double.Parse(TotalPriceBox.Text);

                Model.Receipt receipt = new Model.Receipt(subtotal);

                LabelSubtotal.Text = String.Format("Totalt {0:c}", receipt.Subtotal);
                LabelDiscount.Text = String.Format("Rabattsats {0:p0}", receipt.DiscountRate);
                LabelMoneyOff.Text = String.Format("Rabatt {0:c}", receipt.MoneyOff);
                LabelTotal.Text = String.Format("Att betala {0:c}", receipt.Total);

                this.receipt.Visible = true;

            }
        }
    }
}