using P05AplikacjaZawodnicy.Core.Domains;
using P05AplikacjaZawodnicy.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P02AplikacjaZawodnicy
{
    public partial class Default : System.Web.UI.Page
    {
        static Zawodnik[] zawodnicy;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnWczytaj_Click(object sender, EventArgs e)
        {
            ZawodnicyRepository zr = new ZawodnicyRepository();

            zawodnicy=  zr.PodajZawodnikow();

            //txtWynik.Text = zawodnicy[0].Imie;
            
            lbDane.DataSource = zawodnicy;
            lbDane.DataTextField = "ImieNazwisko";
            lbDane.DataValueField = "Id";
            lbDane.DataBind();
        }

        protected void lbDane_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lbDane.SelectedValue);
            var zaznaczony= zawodnicy.FirstOrDefault(x => x.Id == id);

            txtImie.Text = zaznaczony.Imie;
            txtNazwisko.Text = zaznaczony.Nazwisko;
            txtKraj.Text = zaznaczony.Kraj;
            txtDataUrodzenia.Text
                = zaznaczony.DataUrodzenia?.ToString("dd-MM-yyyy");

            txtWaga.Text = zaznaczony.Waga.ToString();
            txtWzrost.Text = zaznaczony.Wzrost.ToString();
        }
    }
}