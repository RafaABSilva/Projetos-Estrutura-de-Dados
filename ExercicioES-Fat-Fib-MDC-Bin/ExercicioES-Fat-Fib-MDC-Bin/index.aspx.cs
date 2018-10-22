using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        ltrFat.Text = "<h1>:)</h1>";
        ltrFibo.Text = "<h1>:)</h1>";
        ltrMDC.Text = "<h1>:)</h1>";
        ltrDB.Text = "<h1>:)</h1>";
    }

    private double fatorial(double n) {
        if (n == 1) {
            return 1;
        } else {
            return fatorial(n - 1) * n;
        }
    }

    private double fibonacci(double n) {
        if (n == 1) {
            return 0;
        } else if (n == 2) {
            return 1;
        }else{
            return fibonacci(n - 1) + fibonacci(n - 2);
        }
    }

    protected void btnFat_Click(object sender, EventArgs e) {
        ltrFat.Text = "<h1>"+Convert.ToString(fatorial(Convert.ToInt32(txtFat.Text)))+"</h1>";
    }

    protected void btnFibo_Click(object sender, EventArgs e) {
        ltrFibo.Text = "<h1>" + Convert.ToString(fibonacci(Convert.ToInt32(txtFibo.Text))) + "</h1>";
    }

    protected void btnMDC_Click(object sender, EventArgs e) {

    }

    protected void btnDB_Click(object sender, EventArgs e) {

    }
}