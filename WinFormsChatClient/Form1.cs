using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WinFormsChatClient
{
    public partial class ClientForm : Form
    {
        public static string chatHistory = "";

        public string userName = "Дефолтное имя"; // Имя подключившегося
        public string host = "127.0.0.1"; // Айпи подключения --> куда
        public int port = 7777; // Порт

        public bool isConnected = false;

        public Thread receiveThread; // Поток принятия сообщений
        public TcpClient client; // Наш клиент
        public NetworkStream stream; // Сетевой поток

        public ClientForm()
        {
            InitializeComponent();

            updateTimer.Enabled = true;
        }

        // Отправка сообщений
        public void SendMessage()
        {
            try
            {
                string message = userInputText.Text;
                // Выводим то, что написали в чат
                chatHistory += Environment.NewLine + userName + ": " + message;
                userInputText.Text = "";
                // Шифруем и отправляем то, что мы написали в чат
                byte[] data = Encoding.Unicode.GetBytes(message);
                stream.Write(data, 0, data.Length);

            }catch(Exception)
            {
                MessageBox.Show("Сначала напишите сообщение!");
            }
        }
        // Отправка кода с ошибкой на сервер
        public void SendErrorCode(string errorCode)
        {
            try
            {
                string message = errorCode;
                // Шифруем и отправляем то, что мы написали в чат
                byte[] data = Encoding.Unicode.GetBytes(message);
                stream.Write(data, 0, data.Length);
            }
            catch(Exception)
            {
                // Просто знаем, что исключение
            }
        }

        // Получение сообщений
        public void ReceiveMessage()
        {
            while (true)
            {
                try
                {
                    byte[] data = new byte[64]; // Буфер для получаемых данных
                    StringBuilder builder = new StringBuilder();
                    int bytes = 0;
                    do
                    {
                        bytes = stream.Read(data, 0, data.Length);
                        builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                    }
                    while (stream.DataAvailable);

                    string message = builder.ToString();
                    chatHistory += Environment.NewLine + (message); // Вывод сообщения
                }
                catch (Exception ex)
                {
                    Disconnect();
                    break;
                }
            }
        }

        // Подключение к серверу
        public void ConnectToServer()
        {
            client = new TcpClient();

            host = inputIPText.Text.ToString();
            port = Convert.ToInt32(inputPortText.Text);
            userName = inputNameText.Text.ToString();

            try
            {
                client.Connect(host, port); // Подключение клиента
                stream = client.GetStream(); // Получаем поток

                string message = userName;
                byte[] data = Encoding.Unicode.GetBytes(message);
                stream.Write(data, 0, data.Length);

                // Запускаем новый поток для получения данных
                receiveThread = new Thread(new ThreadStart(ReceiveMessage));
                receiveThread.Start(); // Старт потока

                isConnected = true;
                chatHistory += Environment.NewLine + ("У нас новенький --> " + userName);
            }
            catch (Exception ex)
            {
                // В случае ошибки предупреждаем
                MessageBox.Show("Ошибка при подключении: " + ex.Message);
            }
        }

        // Отключение от сервера
        public void Disconnect()
        {
            try
            {
                SendErrorCode("{stopcode:0}");
                if (stream != null)
                    stream.Close();// Отключение потока
                if (client != null)
                    client.Close();// Отключение клиента
                isConnected = false;
            }
            catch(Exception)
            {
                // Ошибка при дисконнекте, потом подумаем что делать
                isConnected = false;
            }
        }

        // Нажатие на кнопку отправить
        private void buttonSend_Click(object sender, EventArgs e)
        {
            SendMessage();
            ScrollToDown();
        }

        // Нажатие на кнопку подключиться
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            ConnectToServer();
        }

        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Disconnect();
        }

        private void ScrollToDown()
        {
            messagesText.SelectionStart = messagesText.TextLength;
            messagesText.ScrollToCaret();
        }
        private void ScrollToUp()
        {
            messagesText.SelectionStart = messagesText.TextLength - messagesText.TextLength + 1;
            messagesText.ScrollToCaret();
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            messagesText.Text = chatHistory;

            ScrollToDown();

            if (isConnected)
                buttonConnect.Enabled = false;
            else
                buttonConnect.Enabled = true;
        }

        private void buttonScroll_Click(object sender, EventArgs e)
        {
            ScrollToDown();
        }
        private void buttonScrollUp_Click(object sender, EventArgs e)
        {
            ScrollToUp();
        }
    }
}
