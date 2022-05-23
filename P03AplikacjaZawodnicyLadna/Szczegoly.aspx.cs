using P05AplikacjaZawodnicy.Core.Domains;
using P05AplikacjaZawodnicy.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P03AplikacjaZawodnicyLadna
{
    public partial class Szczegoly : System.Web.UI.Page
    {
        static Zawodnik zawodnik = new Zawodnik();
        private Uzytkownik zalogowany = new Uzytkownik() { Id = 1 };
        private string idZawodnikaParam;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                idZawodnikaParam = Request["mojeId"];
                if (idZawodnikaParam != null)
                {
                    int id = Convert.ToInt32(idZawodnikaParam);

                    ZawodnicyRepository zr = new ZawodnicyRepository();
                    zawodnik = zr.PodajZawodnika(id);

                    txtImie.Text = zawodnik.Imie;
                    txtNazwisko.Text = zawodnik.Nazwisko;
                    txtKraj.Text = zawodnik.Kraj;
                    txtDataUr.Text = zawodnik.DataUrodzenia?.ToString("yyyy-MM-dd");
                    txtWzrost.Text = Convert.ToString(zawodnik.Wzrost);
                    txtWaga.Text = Convert.ToString(zawodnik.Waga);   
                }
                

            }
        }






        protected void btnZapisz_Click(object sender, EventArgs e)
        {
            zawodnik.Imie = txtImie.Text;
            zawodnik.Nazwisko = txtNazwisko.Text;
            zawodnik.Kraj = txtKraj.Text;

            if (!string.IsNullOrWhiteSpace(txtDataUr.Text))
                zawodnik.DataUrodzenia = Convert.ToDateTime(txtDataUr.Text);
             
            zawodnik.Wzrost = Convert.ToInt32(txtWzrost.Text);
            zawodnik.Waga = Convert.ToInt32(txtWaga.Text);
            
            if (zawodnik.Id_trenera == null)
                zawodnik.Id_trenera = 0;

            ZawodnicyRepository zr = new ZawodnicyRepository();

            if (idZawodnikaParam != null)
            {
                zr.EdytujZawodnika(zawodnik, zalogowany);
            }
            else
            {
                zr.DodajZawodnika(zawodnik, zalogowany);
            }

            Response.Redirect("Default.aspx");
        }

        protected void btnUsun_Click(object sender, EventArgs e)
        {
            ZawodnicyRepository zr = new ZawodnicyRepository();
            zr.UsunZawodnika(zawodnik, zalogowany);
            
            Response.Redirect("Default.aspx");
        }

    }
}