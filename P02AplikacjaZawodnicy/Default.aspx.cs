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
        private static Zawodnik[] zawodnicy;
        private Uzytkownik zalogowany = new Uzytkownik() { Id = 1 };
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnWczytaj_Click(object sender, EventArgs e)
        {
            Odswiez();
        }

        private void Odswiez()
        {
            ZawodnicyRepository zr = new ZawodnicyRepository();

            zawodnicy = zr.PodajZawodnikow();

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

        protected void btnZapisz_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lbDane.SelectedValue);
            Zawodnik zaznaczony = zawodnicy.FirstOrDefault(x => x.Id == id);

            zaznaczony.Imie = txtImie.Text;
            zaznaczony.Nazwisko = txtNazwisko.Text;
            zaznaczony.Kraj = txtKraj.Text;
            zaznaczony.Waga = Convert.ToInt32(txtWaga.Text);
            zaznaczony.Wzrost = Convert.ToInt32(txtWzrost.Text);
            zaznaczony.DataUrodzenia = Convert.ToDateTime(txtDataUrodzenia.Text);
           
            // nasz poprzedni intrefejs dzialal tak, ze gdy zazden trener nie byl wybrany
            // to ustawial idTrenera na 0  dlatego 
            // teraz doajmy ta opcje tutaj (bo nie mamy jeszcze gotowej opcji zmiany trenera) 
            if (zaznaczony.Id_trenera == null)
                zaznaczony.Id_trenera = 0;

            ZawodnicyRepository zr = new ZawodnicyRepository();
            zr.EdytujZawodnika(zaznaczony, zalogowany);

            Odswiez();

        }

        protected void btnUsun_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lbDane.SelectedValue);
            Zawodnik zaznaczony = zawodnicy.FirstOrDefault(x => x.Id == id);

            ZawodnicyRepository zr = new ZawodnicyRepository();
            zr.UsunZawodnika(zaznaczony, zalogowany);
            Odswiez();
        }

        protected void btnCzysc_Click(object sender, EventArgs e)
        {
            //txtImie.Text = "";
            //txtNazwisko.Text = "";
            //txtKraj.Text = "";
            //txtWaga.Text = "";
            foreach (var item in pnlSzczegolyZawodnika.Controls)
                if(item is TextBox)
                    ((TextBox)item).Text = "";
        }

        protected void btnNowy_Click(object sender, EventArgs e)
        {
            Zawodnik nowy = new Zawodnik();
            nowy.Imie = txtImie.Text;
            nowy.Nazwisko = txtNazwisko.Text;
            nowy.Kraj = txtKraj.Text;
            nowy.Waga = Convert.ToInt32(txtWaga.Text);
            nowy.Wzrost = Convert.ToInt32(txtWzrost.Text);
            nowy.DataUrodzenia = Convert.ToDateTime(txtDataUrodzenia.Text);
            nowy.Id_trenera = 0;

            ZawodnicyRepository zr = new ZawodnicyRepository();
            zr.DodajZawodnika(nowy, zalogowany);
            Odswiez();
        }
    }
}