using System;

namespace Kalkulator
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Obliczenie noweObl = new Obliczenie();

            //string myString = myInt.ToString();
            Label3.Text = "";
            noweObl.dzialanie = DropDownList1.Text;
            
            //Label2.Text = noweObl.dzialanie;
            string s = TextBox1.Text;
            bool pusty = String.IsNullOrEmpty(TextBox1.Text);
            if (pusty)
            {
                Label3.Text = "Wpisz pierwsza liczbe !!!";
            }
            else {
                Label3.Text = "";
                noweObl.liczba1 = Convert.ToInt32(TextBox1.Text);
            }

            pusty = String.IsNullOrEmpty(TextBox2.Text);
            if (pusty)
            {
                Label3.Text = "Wpisz druga liczbe !!!";
            }
            else {
                Label3.Text = "";
                noweObl.liczba2 = Convert.ToInt32(TextBox2.Text);
            }

            //Label2.Text = dzialanie;

            //a = 0;
            // int liczba1 = int.Parse(s);
            //double liczba1 = double.Parse(TextBox1.Text);
            //
            //double  liczba2 = double.Parse(TextBox2.Text);

            int wynik = 0;
          
            switch (noweObl.dzialanie)
            {
                case "+": wynik = noweObl.liczba1 + noweObl.liczba2; break;
                case "-": wynik = noweObl.liczba1 - noweObl.liczba2; break;
                case "*": wynik = noweObl.liczba1 * noweObl.liczba2; break;
                case "/":
                    {
                        if (noweObl.liczba2 == 0) { Label3.Text = "Wprowadz liczbe inna od 0 "; wynik = 0; }
                        else
                        {
                            wynik = noweObl.liczba1 / noweObl.liczba2;
                        }
                    }
                    break;
                default: { Label3.Text = "Niepoprawne dane wejsciowe !!!"; } break;

            }


            Label4.Text = wynik.ToString();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Label2.Text = Label4.Text;
        }
    }
}