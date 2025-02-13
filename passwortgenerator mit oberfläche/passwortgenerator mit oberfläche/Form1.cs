/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passwortgenerator_mit_oberfläche
{
    public partial class Form1 : Form
    {
        private int trackBarWert = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private string CreatePassword( int trackBarWert, bool specChar)
        
        {
            string result = "";     // speichert das zu erstellende Passwort
            int anzDigits = 0;      // Anzahl der Ziffern im Passwort (2..4)
            int PWChar = 0;         // ein Passwortzeichen
            Random rnd = new Random();


            // Anzahl Ziffern abhängig von Länge bestimmen
            if (trackBarWert > 11)
                    anzDigits = 4;
                else if (trackBarWert > 6)
                    anzDigits = 3;
                else
                    anzDigits = 2;

                // Länge PW ohne Ziffern
                int PWLen = trackBarWert - anzDigits;

                // Passwörter erstmal ohne Ziffern erstellen
                int i = 0;
                while (i < PWLen)
                {
                    if (!specChar)
                        PWChar = rnd.Next(65, 122);  // ohne Sonderzeichen und ohne Ziffer
                    else
                        PWChar = rnd.Next(35, 122);  // ohne Sonderzeichen aber mit Ziffern

                    // Zeichen ggf. ausschließen und Schleife ohne Erhöhung weiterlaufen lassen
                    if ((PWChar >= 91 && PWChar <= 96) || (PWChar >= 48 && PWChar <= 57))
                        continue;

                    // Passwort zusammenbauen
                    result = result + (char)(PWChar);
                    i++;
                

                // jetzt die Ziffern an beliebiger Position einfügen
                for (i = 0; i < anzDigits; i++)
                {
                    // zufällige Position im aktuellen Passwort bestimmen
                    int pos = rnd.Next(0, result.Length);
                    // Zufallsziffern 1..9 an Position einfügen 
                    result = result.Insert(pos, rnd.Next(1, 10).ToString());
                }
            }
            return result;
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            bool specialCharacters = checkBox1.Checked; // Prüft, ob Sonderzeichen gewünscht sind
            string password = CreatePassword(trackBarWert, specialCharacters);
            Passwörter.Items.Add(password);

            CreatePassword();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Passwörter.Items.Clear();
        }

        private void Passwörter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Passwortlänge_Scroll(object sender, EventArgs e)
        {
            trackBarWert = Passwortlänge.Value; // Speichert den aktuellen Wert
            label1.Text = "Wert: " + trackBarWert; // Zeigt den Wert an
            button1.Enabled = true;
            button2.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passwortgenerator_mit_oberfläche
{
    public partial class Form1 : Form
    {
        private int trackBarWert = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // Ausgelagerte Methode zur Passworterstellung
        private string CreatePassword(int trackBarWert, bool specChar)
        {
            string result = "";     // speichert das zu erstellende Passwort
            int anzDigits = 0;      // Anzahl der Ziffern im Passwort (2..4)
            int PWChar = 0;         // ein Passwortzeichen
            Random rnd = new Random();

            // Anzahl Ziffern abhängig von Länge bestimmen
            if (trackBarWert > 11)
                anzDigits = 4;
            else if (trackBarWert > 6)
                anzDigits = 3;
            else
                anzDigits = 2;

            // Länge PW ohne Ziffern
            int PWLen = trackBarWert - anzDigits;

            // Passwörter erstmal ohne Ziffern erstellen
            int i = 0;
            while (i < PWLen)
            {
                if (!specChar)
                    PWChar = rnd.Next(65, 122);  // ohne Sonderzeichen und ohne Ziffer
                else
                    PWChar = rnd.Next(35, 122);  // mit Sonderzeichen

                // Zeichen ggf. ausschließen und Schleife ohne Erhöhung weiterlaufen lassen
                if ((PWChar >= 91 && PWChar <= 96) || (PWChar >= 48 && PWChar <= 57))
                    continue;

                // Passwort zusammenbauen
                result = result + (char)(PWChar);
                i++;
            }

            // jetzt die Ziffern an beliebiger Position einfügen
            for (i = 0; i < anzDigits; i++)
            {
                // zufällige Position im aktuellen Passwort bestimmen
                int pos = rnd.Next(0, result.Length);
                // Zufallsziffern 1..9 an Position einfügen 
                result = result.Insert(pos, rnd.Next(1, 10).ToString());
            }

            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool specialCharacters = checkBox1.Checked;
            string password = CreatePassword(trackBarWert, specialCharacters);
            Passwörter.Items.Add(password);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Passwörter.Items.Clear();
        }

        private void Passwortlänge_Scroll(object sender, EventArgs e)
        {
            trackBarWert = Passwortlänge.Value; // Speichert den aktuellen Wert
            label1.Text = "Wert: " + trackBarWert; // Zeigt den Wert an
            button1.Enabled = true;
            button2.Enabled = true;
        }
    }
}
