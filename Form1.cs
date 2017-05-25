using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets; 

namespace TCP_attempt3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Polacz_Click(object sender, EventArgs e)
        {
            string host = Adres.Test;
            int port = System.Convert.ToInt32(Port_Number.Value);

            try { TcpClient klient = new TcpClient(host, port);
                info_o_polaczeniu.Items.Add("Nawiązano połączenie z " + host + " na porcie " + port);
                klient.Close; 
            }
            catch { info_o_polaczeniu.Items.Add("Błąd: " + "Nie udało się nawiązać połączenia!");
                MessageBox.Show(Exception.ToString(), "Błąd");
            }
        }
    }
}
