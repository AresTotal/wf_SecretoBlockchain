using System.Net.Sockets;
using System.Net;
using System.Text;

namespace wf_SecretoBlockchain
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await AsyncServer();
        }

        private async Task AsyncServer()
        {
            await Task.Run(() => Server());
        }

        private static List<Socket> activeConnections = new List<Socket>();
        private static object lockObject = new object();
        Thread clientThread;
        private void Server()
        {
            string ip = "127.0.0.1"; // IP-àäðåñ ñåðâåðà
            textBox1.Text = ip;
            if (textBox1.Text != null)
            {
                ip = textBox1.Text;
            }

            int port = 8080; // Ïîðò ñåðâåðà
            textBox2.Text = port.ToString();
            if (textBox2.Text != null)
            {
                port = int.Parse(textBox2.Text);
            }

            // Ñîçäàåì TCP ñîêåò
            var tcpListener = new TcpListener(IPAddress.Parse(ip), port);

            try
            {
                tcpListener.Start();
                Logs.Items.Add("Ñåðâåð çàïóùåí.");

                while (true)
                {
                    var clientSocket = tcpListener.AcceptSocket();
                    ClientsLogs.Items.Add(clientSocket.RemoteEndPoint.ToString());
                    lock (lockObject)
                    {
                        activeConnections.Add(clientSocket); // Äîáàâëÿåì êëèåíòà â ñïèñîê
                    }

                    clientThread = new Thread(() => HandleClient(clientSocket));
                    clientThread.Start();
                }
            }
            catch (Exception ex)
            {
                Logs.Items.Add("Îøèáêà: " + ex.Message);
            }
            finally
            {
                tcpListener.Stop();
            }
        }

        private void HandleClient(Socket clientSocket)
        {
            try
            {
                while (true)
                {
                    byte[] buffer = new byte[1024];
                    int bytesRead = clientSocket.Receive(buffer);
                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    Logs.Items.Add(message);

                    lock (lockObject)
                    {
                        foreach (var connection in activeConnections)
                        {
                            if (connection != clientSocket && connection.Connected)
                            {
                                connection.Send(Encoding.UTF8.GetBytes(message));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logs.Items.Add("Îøèáêà îáðàáîòêè êëèåíòà: " + ex.Message);
            }
            finally
            {
                // Çàêðûâàåì ñîåäèíåíèå ñ êëèåíòîì è óäàëÿåì åãî èç ñïèñêà àêòèâíûõ ïîäêëþ÷åíèé
                lock (lockObject)
                {
                    activeConnections.Remove(clientSocket);
                    clientSocket.Close();
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            clientThread.Abort();
        }
    }
}
