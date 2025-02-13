using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passwortgenerator_mit_oberfläche
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
            // Methode erzeugt ein Passwort mit der Länge len und mit/ohne Sonderzeichen
            static string CreatePassword(int len, bool specChar, Random rnd)
            {
                string result = "";     // speichert das zu erstellende Passwort
                int anzDigits = 0;      // Anzahl der Ziffern im Passwort (2..4)
                int PWChar = 0;         // ein Passwortzeichen

                if (len < 4 || len > 16)
                    throw new Exception("ungültige Passwortlänge");
                else
                {
                    // Anzahl Ziffern abhängig von Länge bestimmen
                    if (len > 11)
                        anzDigits = 4;
                    else if (len > 6)
                        anzDigits = 3;
                    else
                        anzDigits = 2;

                    // Länge PW ohne Ziffern
                    int PWLen = len - anzDigits;

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
                    }

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
        }
    }

