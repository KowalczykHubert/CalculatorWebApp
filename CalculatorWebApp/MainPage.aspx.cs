using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculatorWebApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //metoda dodająca działania do historii
        private void dodajDzialanie(string pierwsza, string druga, int dzialanie, string wynik)
        {
            string ukrytaWartosc = pierwsza + ";" + druga + ";" + dzialanie.ToString() + ";" + wynik;
            string widocznaWartosc = pierwsza + " ";
            if (dzialanie == 0) widocznaWartosc += "+ ";
            if (dzialanie == 1) widocznaWartosc += "- ";
            if (dzialanie == 2) widocznaWartosc += "* ";
            if (dzialanie == 3) widocznaWartosc += "/ ";
            widocznaWartosc += druga;

            ListItem element = new ListItem(widocznaWartosc, ukrytaWartosc);
            Historia.Items.Add(element);
        }
        protected void Oblicz_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(LiczbaPierwsza.Text);
                double num2 = Convert.ToDouble(LiczbaDruga.Text);
                int dzialanie = Convert.ToInt32(Dzialanie.SelectedValue);
                // Wybór rodzaju działania
                switch (dzialanie)
                {
                    case 0:
                        double wynik = (num1 + num2);
                        Wynik.Text = wynik.ToString();
                        dodajDzialanie(LiczbaPierwsza.Text, LiczbaDruga.Text, dzialanie, wynik.ToString());
                        break;

                    case 1:
                        wynik = (num1 - num2);
                        Wynik.Text = wynik.ToString();
                        dodajDzialanie(LiczbaPierwsza.Text, LiczbaDruga.Text, dzialanie, wynik.ToString());
                        break;
                    case 2:
                        wynik = (num1 * num2);
                        Wynik.Text = wynik.ToString();
                        dodajDzialanie(LiczbaPierwsza.Text, LiczbaDruga.Text, dzialanie, wynik.ToString());
                        break;
                    case 3:
                        if (num2 == 0)
                        {
                            Wynik.Text = "Nie dzielimy przez 0";
                        }
                        else
                        {
                            wynik = (num1 / num2);
                            Wynik.Text = wynik.ToString();
                            dodajDzialanie(LiczbaPierwsza.Text, LiczbaDruga.Text, dzialanie, wynik.ToString());
                        }
                        break;
                    default:
                        Wynik.Text = "Coś tam";
                        break;
                }
            }
            // Obsługa wyjątków (dzielenie przez zero)
            catch (Exception ex)
            {
                Wynik.Text = "Błąd formatu wprowadzonej liczby!";
            }



        }
        // Metoda odtwarzająca działanie z historii działań
        protected void Odtworz_Click(object sender, EventArgs e)
        {
            string opisDzialania = Historia.SelectedValue;
            string[] pola = opisDzialania.Split(';');

            LiczbaPierwsza.Text = pola[0];
            LiczbaDruga.Text = pola[1];
            Dzialanie.Text = pola[2];
            Wynik.Text = pola[3];
        }

       
    }
}
