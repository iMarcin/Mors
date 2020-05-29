using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace morsowania
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        
        static string mors(string wyraz)
        {
            string wynik = "";
            for (int i = 0; i < wyraz.Length; i++)
            {
                if (wyraz[i] == 'a' || wyraz[i] == 'A') { wynik += "•-/"; }
                if (wyraz[i] == 'b' || wyraz[i] == 'B') { wynik += "-•••/"; }
                if (wyraz[i] == 'c' || wyraz[i] == 'C') { wynik += "-•-•/"; }
                if (wyraz[i] == 'd' || wyraz[i] == 'D') { wynik += "-••/"; }
                if (wyraz[i] == 'e' || wyraz[i] == 'E') { wynik += "•/"; }
                if (wyraz[i] == 'f' || wyraz[i] == 'F') { wynik += "••-•/"; }
                if (wyraz[i] == 'g' || wyraz[i] == 'G') { wynik += "--•/"; }
                if (wyraz[i] == 'h' || wyraz[i] == 'H') { wynik += "••••/"; }
                if (wyraz[i] == 'i' || wyraz[i] == 'I') { wynik += "••/"; }
                if (wyraz[i] == 'j' || wyraz[i] == 'J') { wynik += "•---/"; }
                if (wyraz[i] == 'k' || wyraz[i] == 'K') { wynik += "-•--/"; }
                if (wyraz[i] == 'l' || wyraz[i] == 'L') { wynik += "•-••/"; }
                if (wyraz[i] == 'm' || wyraz[i] == 'M') { wynik += "--/"; }
                if (wyraz[i] == 'n' || wyraz[i] == 'N') { wynik += "-•/"; }
                if (wyraz[i] == 'o' || wyraz[i] == 'O') { wynik += "---/"; }
                if (wyraz[i] == 'p' || wyraz[i] == 'P') { wynik += "•--•/"; }
                if (wyraz[i] == 'q' || wyraz[i] == 'Q') { wynik += "--•-/"; }
                if (wyraz[i] == 'r' || wyraz[i] == 'R') { wynik += "•-•/"; }
                if (wyraz[i] == 's' || wyraz[i] == 'S') { wynik += "•••/"; }
                if (wyraz[i] == 't' || wyraz[i] == 'T') { wynik += "-/"; }
                if (wyraz[i] == 'u' || wyraz[i] == 'U') { wynik += "••-/"; }
                if (wyraz[i] == 'v' || wyraz[i] == 'V') { wynik += "•••-/"; }
                if (wyraz[i] == 'w' || wyraz[i] == 'W') { wynik += "•--/"; }
                if (wyraz[i] == 'x' || wyraz[i] == 'X') { wynik += "-••-/"; }
                if (wyraz[i] == 'y' || wyraz[i] == 'Y') { wynik += "-•--/"; }
                if (wyraz[i] == 'z' || wyraz[i] == 'Z') { wynik += "--••/"; }
                if (wyraz[i] == '1') { wynik += "•----/"; }
                if (wyraz[i] == '2') { wynik += "••--/"; }
                if (wyraz[i] == '3') { wynik += "•••--/"; }
                if (wyraz[i] == '4') { wynik += "•••-/"; }
                if (wyraz[i] == '5') { wynik += "•••••/"; }
                if (wyraz[i] == '6') { wynik += "-••••/"; }
                if (wyraz[i] == '7') { wynik += "--•••/"; }
                if (wyraz[i] == '8') { wynik += "---••/"; }
                if (wyraz[i] == '9') { wynik += "----•/"; }
                if (wyraz[i] == '0') { wynik += "-----/"; }
                if (wyraz[i] == '.') { wynik += "•-•-•-/"; }
                if (wyraz[i] == ',') { wynik += "--••--/"; }
                if (wyraz[i] == '\'') { wynik += "•----•/"; }
                if (wyraz[i] == '\"') { wynik += "•-••-•/"; }
                if (wyraz[i] == '_') { wynik += "••--•-/"; }
                if (wyraz[i] == ':') { wynik += "---•••/"; }
                if (wyraz[i] == ';') { wynik += "-•-•-•/"; }
                if (wyraz[i] == '?') { wynik += "••--••/"; }
                if (wyraz[i] == '!') { wynik += "-•-•--/"; }
                if (wyraz[i] == '-') { wynik += "-••••-/"; }
                if (wyraz[i] == '+') { wynik += "•-•-•/"; }
                if (wyraz[i] == '/') { wynik += "--••-•/"; }
                if (wyraz[i] == '(') { wynik += "-•--•/"; }
                if (wyraz[i] == ')') { wynik += "-•--•-/"; }
                if (wyraz[i] == '=') { wynik += "-•••-/"; }
                if (wyraz[i] == '@') { wynik += "•--•-•/"; }
                if (wyraz[i] == ' ') { wynik += "   "; }
                if (i == wyraz.Length)
                {
                    wynik.Remove(wynik.Length - 1);
                }
            }
            return wynik;
        }
        static string odmorsuj(string wyraz)
        {
            string wynik = "";
            string znak = "";
            for (int i = 0; i < wyraz.Length; i++)
            {

                if(wyraz[i]=='/')
                {
                    if(znak==" ") { wynik += " "; }
                    else if (znak == ".-") { wynik += "a"; }
                    else if (znak == "-..") { wynik += "b"; }
                    else if (znak == "-.-.") { wynik += "c"; }
                    else if (znak == "-..") { wynik += "d"; }
                    else if (znak == ".") { wynik += "e"; }
                    else if (znak == "..-.") { wynik += "f"; }
                    else if (znak == "--.") { wynik += "g"; }
                    else if (znak == "....") { wynik += "h"; }
                    else if (znak == "..") { wynik += "i"; }
                    else if (znak == ".---") { wynik += "j"; }
                    else if (znak == "-.-") { wynik += "k"; }
                    else if (znak == ".-..") { wynik += "l"; }
                    else if (znak == "--") { wynik += "m"; }
                    else if (znak == "-.") { wynik += "n"; }
                    else if (znak == "---") { wynik += "o"; }
                    else if (znak == ".--.") { wynik += "p"; }
                    else if (znak == "--.-") { wynik += "q"; }
                    else if (znak == ".-.") { wynik += "r"; }
                    else if (znak == "...") { wynik += "s"; }
                    else if (znak == "-") { wynik += "t"; }
                    else if (znak == "..-") { wynik += "u"; }
                    else if (znak == "...-") { wynik += "v"; }
                    else if (znak == ".--") { wynik += "w"; }
                    else if (znak == "-..-") { wynik += "x"; }
                    else if (znak == "-.--") { wynik += "y"; }
                    else if (znak == "--..") { wynik += "z"; }
                    else if (znak == ".----") { wynik += "1"; }
                    else if (znak == "..---") { wynik += "2"; }
                    else if (znak == "...--") { wynik += "3"; }
                    else if (znak == "....-") { wynik += "4"; }
                    else if (znak == ".....") { wynik += "5"; }
                    else if (znak == "-....") { wynik += "6"; }
                    else if (znak == "--...") { wynik += "7"; }
                    else if (znak == "---..") { wynik += "8"; }
                    else if (znak == "----.") { wynik += "9"; }
                    else if (znak == "-----") { wynik += "0"; }
                    else if (znak == ".-.-.-") { wynik += "."; }
                    else if (znak == "--..--") { wynik += ","; }
                    else if (znak == ".----.") { wynik += "'"; }
                    else if (znak == ".-..-.") { wynik += "\""; }
                    else if (znak == "..--.-") { wynik += "_"; }
                    else if (znak == "---...") { wynik += ":"; }
                    else if (znak == "-.-.-.") { wynik += ";"; }
                    else if (znak == "..--..") { wynik += "?"; }
                    else if (znak == "-.-.--") { wynik += "!"; }
                    else if (znak == "-....-") { wynik += "-"; }
                    else if (znak == ".-.-.") { wynik += "+"; }
                    else if (znak == "-..-.") { wynik += "/"; }
                    else if (znak == "-.--.") { wynik += "("; }
                    else if (znak == "-.--.-") { wynik += ")"; }
                    else if (znak == "-...-") { wynik += "="; }
                    else if (znak == ".--.-.") { wynik += "@"; }
                    else return "bład w morsie";
                    znak = "";
                }else 
                znak += wyraz[i];
                if(i==wyraz.Length-1)
                {
                    if (znak == " ") { wynik += " "; }
                    else if (znak == ".-") { wynik += "a"; }
                    else if (znak == "-..") { wynik += "b"; }
                    else if (znak == "-.-.") { wynik += "c"; }
                    else if (znak == "-..") { wynik += "d"; }
                    else if (znak == ".") { wynik += "e"; }
                    else if (znak == "..-.") { wynik += "f"; }
                    else if (znak == "--.") { wynik += "g"; }
                    else if (znak == "....") { wynik += "h"; }
                    else if (znak == "..") { wynik += "i"; }
                    else if (znak == ".---") { wynik += "j"; }
                    else if (znak == "-.-") { wynik += "k"; }
                    else if (znak == ".-..") { wynik += "l"; }
                    else if (znak == "--") { wynik += "m"; }
                    else if (znak == "-.") { wynik += "n"; }
                    else if (znak == "---") { wynik += "o"; }
                    else if (znak == ".--.") { wynik += "p"; }
                    else if (znak == "--.-") { wynik += "q"; }
                    else if (znak == ".-.") { wynik += "r"; }
                    else if (znak == "...") { wynik += "s"; }
                    else if (znak == "-") { wynik += "t"; }
                    else if (znak == "..-") { wynik += "u"; }
                    else if (znak == "...-") { wynik += "v"; }
                    else if (znak == ".--") { wynik += "w"; }
                    else if (znak == "-..-") { wynik += "x"; }
                    else if (znak == "-.--") { wynik += "y"; }
                    else if (znak == "--..") { wynik += "z"; }
                    else if (znak == ".----") { wynik += "1"; }
                    else if (znak == "..---") { wynik += "2"; }
                    else if (znak == "...--") { wynik += "3"; }
                    else if (znak == "....-") { wynik += "4"; }
                    else if (znak == ".....") { wynik += "5"; }
                    else if (znak == "-....") { wynik += "6"; }
                    else if (znak == "--...") { wynik += "7"; }
                    else if (znak == "---..") { wynik += "8"; }
                    else if (znak == "----.") { wynik += "9"; }
                    else if (znak == "-----") { wynik += "0"; }
                    else if (znak == ".-.-.-") { wynik += "."; }
                    else if (znak == "--..--") { wynik += ","; }
                    else if (znak == ".----.") { wynik += "'"; }
                    else if (znak == ".-..-.") { wynik += "\""; }
                    else if (znak == "..--.-") { wynik += "_"; }
                    else if (znak == "---...") { wynik += ":"; }
                    else if (znak == "-.-.-.") { wynik += ";"; }
                    else if (znak == "..--..") { wynik += "?"; }
                    else if (znak == "-.-.--") { wynik += "!"; }
                    else if (znak == "-....-") { wynik += "-"; }
                    else if (znak == ".-.-.") { wynik += "+"; }
                    else if (znak == "-..-.") { wynik += "/"; }
                    else if (znak == "-.--.") { wynik += "("; }
                    else if (znak == "-.--.-") { wynik += ")"; }
                    else if (znak == "-...-") { wynik += "="; }
                    else if (znak == ".--.-.") { wynik += "@"; }
                    else return "bład w morsie";
                }
            }
            return wynik;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("twój tekst w morsie to: " + mors(textBox1.Text));

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(odmorsuj(textBox1.Text)== "bład w morsie")
                MessageBox.Show(odmorsuj(textBox1.Text));
            else
                MessageBox.Show("twój tekst to: " + odmorsuj(textBox1.Text));
        }
    }
}
