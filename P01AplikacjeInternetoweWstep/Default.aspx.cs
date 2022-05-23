using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P01AplikacjeInternetoweWstep
{
    public partial class Default : System.Web.UI.Page
    {
        public string Napis;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPrzycisk_Click(object sender, EventArgs e)
        {
            string s = "ala ma kota";
            Napis = s;

            s = s.ToUpper();

            Response.Write(s);
            lblWynik.Text = s;


        }
    }
}