using System.Net.Sockets;
using System.Net;
using System.Text;
using Sodium;
using System.IO;
using System.Security.Policy;

namespace wf_SecretoClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Chain _chain = new Chain();

        static byte[]? publicKey;
        static byte[]? privateKey;
        static byte[]? nonce;
        static byte[]? sharedKey;

        private void Form1_Load(object sender, EventArgs e)
        {
            publicKey = GenerateKeyPair().PublicKey;
            privateKey = GenerateKeyPair().PrivateKey;
        }

        NetworkStream stream;

        private static readonly Encoding encoding = Encoding.UTF8;

        private void button1_Click(object sender, EventArgs e)
        {
            string ip = "127.0.0.1"; // IP-адрес сервера
            textBox1.Text = ip;
            if (textBox1.Text != null)
            {
                ip = textBox1.Text;
            }

            int port = 8080; // Порт сервера
            textBox2.Text = port.ToString();
            if (textBox2.Text != null)
            {
                port = int.Parse(textBox2.Text);
            }

            //Публичный ключ
            textBox4.Text = ConvertByteToString(publicKey);

            //Приватный ключ
            textBox5.Text = ConvertByteToString(privateKey);

            // Создаем TCP клиент
            TcpClient client = new TcpClient(ip, port);

            Logs.Items.Add("Подключено к серверу.");

            // Получаем поток для отправки и приема данных
            stream = client.GetStream();

            try
            {
                // Создаем отдельный поток для приема сообщений от сервера
                var receiveThread = new System.Threading.Thread(() =>
                {
                    while (true)
                    {
                        byte[] data = new byte[256];
                        int bytes = stream.Read(data, 0, data.Length);
                        string responseData = Encoding.UTF8.GetString(data, 0, bytes);
                        string[] parts = responseData.Split('|');
                        string encryptedMessage = parts[0];
                        string nonceBase64 = parts[1];
                        nonce = Convert.FromBase64String(nonceBase64);
                        textBox6.Text = nonceBase64;
                        string decryptedText = Decrypt(encryptedMessage, sharedKey, nonce);
                        Logs.Items.Add("Сообщение от сервера: " + decryptedText);
                    }
                });
                receiveThread.Start();
            }
            catch (Exception ex)
            {
                Logs.Items.Add("Ошибка: " + ex.Message);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string ip = "127.0.0.1"; // IP-адрес сервера
            textBox1.Text = ip;
            if (textBox1.Text != null)
            {
                ip = textBox1.Text;
            }

            int port = 8080; // Порт сервера
            textBox2.Text = port.ToString();
            if (textBox2.Text != null)
            {
                port = int.Parse(textBox2.Text);
            }

            //Публичный ключ
            textBox4.Text = ConvertByteToString(publicKey);

            //Приватный ключ
            textBox5.Text = ConvertByteToString(privateKey);

            // Создаем TCP клиент
            TcpClient client = new TcpClient(ip, port);

            Logs.Items.Add("Подключено к серверу.");

            // Получаем поток для отправки и приема данных
            stream = client.GetStream();

            try
            {
                // Создаем отдельный поток для приема сообщений от сервера
                var receiveThread = new System.Threading.Thread(() =>
                {
                    while (true)
                    {
                        byte[] data = new byte[256];
                        int bytes = stream.Read(data, 0, data.Length);
                        string responseData = Encoding.UTF8.GetString(data, 0, bytes);
                        string[] parts = responseData.Split('|');
                        string encryptedMessage = parts[0];
                        string nonceBase64 = parts[1];
                        nonce = Convert.FromBase64String(nonceBase64);
                        textBox6.Text = nonceBase64;
                        string decryptedText = Decrypt(encryptedMessage, sharedKey, nonce);
                        Logs.Items.Add("Сообщение от сервера: " + decryptedText);
                    }
                });
                receiveThread.Start();
            }
            catch (Exception ex)
            {
                Logs.Items.Add("Ошибка: " + ex.Message);
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                string message = textBox3.Text;

                string encryptedMessage = Encrypt(message, sharedKey);

                _chain.Add(encryptedMessage);

                textBox6.Text = ConvertByteToString(nonce);

                string nonceBase64 = Convert.ToBase64String(nonce);

                // Конвертируем сообщение в байты
                byte[] data = Encoding.UTF8.GetBytes(encryptedMessage + "|" + nonceBase64);

                // Отправляем данные на сервер
                stream.Write(data, 0, data.Length);

                // Закрываем соединение
                //stream.Close();
                //client.Close();
            }
            catch (Exception ex)
            {
                Logs.Items.Add("Ошибка: " + ex.Message);
            }
        }
        static string Encrypt(string message, byte[] sharedKey)
        {
            nonce = SecretBox.GenerateNonce();
            byte[] messageBytes = System.Text.Encoding.UTF8.GetBytes(message);
            byte[] encryptedMessage = SecretBox.Create(messageBytes, nonce, sharedKey);
            string encryptedMessageBase64 = Convert.ToBase64String(encryptedMessage);

            return encryptedMessageBase64;
        }

        static string Decrypt(string encryptedMessage, byte[] sharedKey, byte[] nonce)
        {
            try
            {
                byte[] encryptedBytes = Convert.FromBase64String(encryptedMessage);
                byte[] decryptedBytes = SecretBox.Open(encryptedBytes, nonce, sharedKey);
                string decryptedText = Encoding.UTF8.GetString(decryptedBytes);

                return decryptedText;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при расшифровке сообщения: " + ex.Message);
                return null;
            }
        }
        static byte[] GeneratePublicKey()
        {
            // Генерация ключевой пары Curve25519
            KeyPair keyPair = PublicKeyBox.GenerateKeyPair();

            // Возврат публичного ключа в формате байтов
            return keyPair.PublicKey;
        }
        static byte[] GeneratePrivateKey()
        {
            // Генерация ключевой пары Curve25519
            KeyPair keyPair = PublicKeyBox.GenerateKeyPair();

            // Возврат приватного ключа в формате байтов
            return keyPair.PrivateKey;
        }
        static KeyPair GenerateKeyPair()
        {
            KeyPair keyPair = PublicKeyBox.GenerateKeyPair();

            // Возврат приватного и публичного ключа в формате байтов
            return keyPair;
        }
        private static string ConvertByteToString(byte[] data)
        {
            return Convert.ToBase64String(data);
        }
        private static byte[] ConvertStringToByte(string data)
        {
            return Convert.FromBase64String(data);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            privateKey = ConvertStringToByte(textBox5.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            publicKey = ConvertStringToByte(textBox4.Text);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //nonce = ConvertStringToByte(textBox6.Text);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            //sharedKey = ConvertStringToByte(textBox7.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //sharedKey = ScalarMult.Mult(privateKey, publicKey);

            sharedKey = ConvertStringToByte("qcfnHrAY8s2iOFt90zDKtSJbmzR0PvJn5FejIQUb7yQ=");

            textBox7.Text = Convert.ToBase64String(sharedKey);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 53)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 244)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        bool dashboardVisible = false;
        private void button4_Click(object sender, EventArgs e)
        {
            if (!dashboardVisible)
            {
                dashboard.Visible = true;
                dashboardVisible = true;
            }
            else
            {
                dashboard.Visible = false;
                dashboardVisible = false;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        bool settingsVisible = false;
        private void button5_Click(object sender, EventArgs e)
        {
            if (!settingsVisible)
            {
                settings.Visible = true;
                settingsVisible = true;
            }
            else
            {
                settings.Visible = false;
                settingsVisible = false;
            }
        }

        bool aboutVisible = false;
        private void button6_Click(object sender, EventArgs e)
        {
            if (!aboutVisible)
            {
                about.Visible = true;
                aboutVisible = true;
            }
            else
            {
                about.Visible = false;
                aboutVisible = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //sharedKey = ScalarMult.Mult(privateKey, publicKey);

            sharedKey = ConvertStringToByte("qcfnHrAY8s2iOFt90zDKtSJbmzR0PvJn5FejIQUb7yQ=");

            textBox7.Text = Convert.ToBase64String(sharedKey);
        }
    }
}
