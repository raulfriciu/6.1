using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace ClienteTemperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Ejecutar_Click(object sender, EventArgs e)
        {
            Socket server;
            //Crear el IPEndPoint de nuestro cliente al servidor por el puerto al que nos queremos conectar
            IPAddress direc = IPAddress.Parse("192.168.56.102");
            IPEndPoint ipep = new IPEndPoint(direc, 9050);

            //crear el socket
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                server.Connect(ipep);
                this.BackColor = Color.Green;

                    if (Celsius.Checked)
                    {
                        string temperatura = "1/" + Temperatura.Text;
                        //enviamos al servidor la temperatura
                        byte[] msg = System.Text.Encoding.ASCII.GetBytes(temperatura);
                        server.Send(msg);

                        //recibimos la respuesta del servidor
                        byte[] msg2 = new byte[512];
                        server.Receive(msg2);
                        temperatura = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                        MessageBox.Show("La temperatura en Farenheit es " + temperatura);
                    }
                if (Fahrenheit.Checked)
                {
                    string temperatura = "2/" + Temperatura.Text;
                    //enviamos al servidor la temperatura
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(temperatura);
                    server.Send(msg);

                    //recibimos la respuesta del servidor
                    byte[] msg2 = new byte[512];
                    server.Receive(msg2);
                    temperatura = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                    MessageBox.Show("La temperatura en Farenheit es " + temperatura);
                }
            
              this.BackColor = Color.Gray;
              server.Shutdown(SocketShutdown.Both);
              server.Close();
            }
            catch(SocketException)
            {
                MessageBox.Show("No se pudo conectar al servidor");
            }
        }   
    }
}
