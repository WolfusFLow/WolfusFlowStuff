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
using System.IO;
using System.Threading;
using System.Net;




//Прослушивает подключения от TCP-клиентов сети
// TcpListener TCPMesLis;
//Интерфейс сокетов
// Socket MSocket;
//Обеспечивает базовый поток данных для доступа к сети
// NetworkStream MNetStrm; 


namespace Chat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        TcpListener TCPMesLis = null;
        Socket MSocket = null;
        NetworkStream MNetStrm = null;





        void MessageServer()
        {
            TCPMesLis = new TcpListener(8888);// открываем порт
            TCPMesLis.Start();// начинаем сканирование

            while (true)
            {
                try
                {

                    MSocket = TCPMesLis.AcceptSocket();//Принимаем запрос на подключение
                    MNetStrm = new NetworkStream(MSocket);//связываем

                    byte[] buffer = new byte[1024];//считываем
                    MNetStrm.Read(buffer, 0, 1024);
                    MemoryStream ms = new MemoryStream(buffer);
                    
                    string s = Encoding.UTF8.GetString(buffer, 0, buffer.Length);

                    //tempRichText.LoadFile(ms, RichTextBoxStreamType.RichText);//сохраняем в текстовое поле (временное )
                    SetText( "Mda...:"+ s + Environment.NewLine);
                    //Его можно объявить и сразу проинициализировать в переменных класса, как RichTextBox tempRichText = new RichTextBox();
                    //tempRichText.Text += "Hello!" + Environment.NewLine;//Добавляем перевод строки + текстовое сообщение
                    //ChatBox.Text += tempRichText.Text;//Выводим сообщение
                    /* еще один способ получить информацию.
                    * В этом случае необходимо учесть, что к текстовой информации может
                    * добавляться информация о стиле тексте, шрифте и т.д.*/
                    //for (int i = 0; i < buffer.Length; i++)
                    //    ChatBox.Text += (char)buffer[i];

                }
                catch (Exception ex) { }//сюда можно внести обработку исключений.
            }


        }


        //Link https://msdn.microsoft.com/ru-ru/library/ms171728%28v=vs.110%29.aspx
        // This delegate enables asynchronous calls for setting
        // the text property on a TextBox control.
        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (!tempRichText.InvokeRequired)
            {
                this.tempRichText.Text = text;
            }
            else
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
        }



        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Text_To_Send_Click(object sender, EventArgs e)
        {

            try
            {
                //Предоставляет клиентские подключения для сетевых служб протокола TCP.                    
                TcpClient Client;
                Client = new TcpClient("10.0.75.52", 8888);//открыли подключение
                NetworkStream ClientMNetworkS = Client.GetStream();//получили поток (для записи)
                //MemoryStream ClientMemoryS = new MemoryStream();


                byte[] b = Encoding.UTF8.GetBytes(ChatMessage.Text);
                //ChatBox.Items.Add
                //ChatBox.Text += "You" + ChatMessage.Text;
                ChatBox.Items.Add("You" + ChatMessage.Text);
                //Вы:" + ChatMessage.Text;//скопировали в чат-окно свое сообщение
                //сюда можно добавить сопроводительную информацию (с какого IP было отправлено, либо с какой учетной записи и т.д.)
                //подобные изменения проводятся с ChatMessage
                //ChatMessage.SaveFile(ClientMemoryS, RichTextBoxStreamType.RichText);//сохранили информацию в MemoryStream
                ClientMNetworkS.Write(b, 0, b.Length);//записали
                //закрываем потоки, подключения
                ClientMNetworkS.Close();
                Client.Close();
                //отправленное сообщение очищаем
                ChatMessage.Clear();
            }
            catch (Exception ex)
            {//если порт не прослушивается на сервере (не было ответа), либо произошла стороння ситуация - уведомим ошибкой
                MessageBox.Show(ex.Message);
            }

        }



        private void Form1_Shown(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(MessageServer));
            t.Start();
            //MessageServer();
        }


    }
}