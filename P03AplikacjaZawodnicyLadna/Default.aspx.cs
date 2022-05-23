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
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ZawodnicyRepository zr = new ZawodnicyRepository();
            Zawodnik[] zawodnicy = zr.PodajZawodnikow();

             // nie bedziemy korzystac z tabelki .Net poniewaz 
             // przy bardziej skomplikowanych elemtnrach 
             // nie oplaca sie na siłę przerabianie kontrolki .net towej na wyglada taki jaki nam opodaiwada
             // zamiast tego lepiej zastosowac wstawki 

            //foreach (var z in zawodnicy)
            //{
            //    TableRow tr = new TableRow();
            //    tr.Cells.Add(new TableCell() { Text = z.Imie });
            //    tr.Cells.Add(new TableCell() { Text = z.Nazwisko });
            //    tr.Cells.Add(new TableCell() { Text = z.Kraj });
            //    tr.Cells.Add(new TableCell() { Text = z.DataUrodzenia.ToString() });

            //    Table1.Rows.Add(tr);
            //}

        //    Table1.Rows.Add(new TableRow() { })
        }
    }
}