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

namespace vaja3
{
    public partial class game : Form
    {
        public game(bool isHost, string ip = null)
        {
            InitializeComponent();
            MessageReciver.DoWork += MessageReciver_DoWork;
            CheckForIllegalCrossThreadCalls = false;

            if (isHost)
            {
                try
                {
                    PlayerChar = 'X';
                    OpponentChar = 'O';
                    server = new TcpListener(System.Net.IPAddress.Any, 5732);
                    server.Start();
                    socket = server.AcceptSocket();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                PlayerChar = 'O';
                OpponentChar = 'X';
                try
                {
                    client = new TcpClient(ip, 5732);
                    socket = client.Client;
                    MessageReciver.RunWorkerAsync();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Close();
                }
            }
        }

        private void MessageReciver_DoWork(object? sender, DoWorkEventArgs e)
        {
            try
            {
                if (checkState())
                    return;
                freezeBoard();
                label1.Text = "opponent's turn!";
                ReceiveMove();
                label1.Text = "your turn!";
                if (!checkState())
                    unFreezeBoard();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private char PlayerChar;
        private char OpponentChar;
        private Socket socket;
        private BackgroundWorker MessageReciver = new BackgroundWorker();
        private TcpListener server = null;
        private TcpClient client;

        private bool checkState()
        {
            try
            {

                if (button1.Text == button2.Text && button2.Text == button3.Text && button3.Text != "")
                {
                    if (button1.Text[0] == PlayerChar)
                    {
                        label1.Text = "you won";
                        MessageBox.Show("you won");
                        freezeBoard();
                    }
                    else
                    {
                        label1.Text = "you lost";
                        MessageBox.Show("you lost");
                    }
                    return true;
                }
                if (button4.Text == button5.Text && button5.Text == button6.Text && button6.Text != "")
                {
                    if (button4.Text[0] == PlayerChar)
                    {
                        label1.Text = "you won";
                        MessageBox.Show("you won");
                        freezeBoard();
                    }
                    else
                    {
                        label1.Text = "you lost";
                        MessageBox.Show("you lost");
                    }
                    return true;
                }
                if (button7.Text == button8.Text && button8.Text == button9.Text && button9.Text != "")
                {
                    if (button7.Text[0] == PlayerChar)
                    {
                        label1.Text = "you won";
                        MessageBox.Show("you won");
                        freezeBoard();
                    }
                    else
                    {
                        label1.Text = "you lost";
                        MessageBox.Show("you lost");
                    }
                    return true;
                }
                if (button1.Text == button4.Text && button4.Text == button7.Text && button7.Text != "")
                {
                    if (button1.Text[0] == PlayerChar)
                    {
                        label1.Text = "you won";
                        MessageBox.Show("you won");
                        freezeBoard();
                    }
                    else
                    {
                        label1.Text = "you lost";
                        MessageBox.Show("you lost");
                    }
                    return true;
                }
                if (button2.Text == button5.Text && button5.Text == button8.Text && button8.Text != "")
                {
                    if (button2.Text[0] == PlayerChar)
                    {
                        label1.Text = "you won";
                        MessageBox.Show("you won");
                        freezeBoard();
                    }
                    else
                    {
                        label1.Text = "you lost";
                        MessageBox.Show("you lost");
                    }
                    return true;
                }
                if (button3.Text == button6.Text && button6.Text == button9.Text && button9.Text != "")
                {
                    if (button3.Text[0] == PlayerChar)
                    {
                        label1.Text = "you won";
                        MessageBox.Show("you won");
                        freezeBoard();
                    }
                    else
                    {
                        label1.Text = "you lost";
                        MessageBox.Show("you lost");
                    }
                    return true;
                }
                if (button1.Text == button5.Text && button5.Text == button9.Text && button9.Text != "")
                {
                    if (button1.Text[0] == PlayerChar)
                    {
                        label1.Text = "you won";
                        MessageBox.Show("you won");
                        freezeBoard();
                    }
                    else
                    {
                        label1.Text = "you lost";
                        MessageBox.Show("you lost");
                    }
                    return true;
                }
                if (button3.Text == button5.Text && button5.Text == button7.Text && button7.Text != "")
                {
                    if (button3.Text[0] == PlayerChar)
                    {
                        label1.Text = "you won";
                        MessageBox.Show("you won");
                        freezeBoard();
                    }
                    else
                    {
                        label1.Text = "you lost";
                        MessageBox.Show("you lost");
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return false;
        }
        private void freezeBoard()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }
        private void unFreezeBoard()
        {
            if(button1.Text == "")
                button1.Enabled = true;
            if (button2.Text == "")
                button2.Enabled = true;
            if (button3.Text == "")
                button3.Enabled = true;
            if (button4.Text == "")
                button4.Enabled = true;
            if (button5.Text == "")
                button5.Enabled = true;
            if (button6.Text == "")
                button6.Enabled = true;
            if (button7.Text == "")
                button7.Enabled = true;
            if (button8.Text == "")
                button8.Enabled = true;
            if (button9.Text == "")
                button9.Enabled = true;
        }
        private void ReceiveMove()
        {
            try
            {

                byte[] buffer = new byte[1];
                socket.Receive(buffer);
                if (buffer[0] == 1)
                {
                    button1.Text = OpponentChar.ToString();
                }
                if (buffer[0] == 2)
                {
                    button2.Text = OpponentChar.ToString();
                }
                if (buffer[0] == 3)
                {
                    button3.Text = OpponentChar.ToString();
                }
                if (buffer[0] == 4)
                {
                    button4.Text = OpponentChar.ToString();
                }
                if (buffer[0] == 5)
                {
                    button5.Text = OpponentChar.ToString();
                }
                if (buffer[0] == 6)
                {
                    button6.Text = OpponentChar.ToString();
                }
                if (buffer[0] == 7)
                {
                    button7.Text = OpponentChar.ToString();
                }
                if (buffer[0] == 8)
                {
                    button8.Text = OpponentChar.ToString();
                }
                if (buffer[0] == 9)
                {
                    button9.Text = OpponentChar.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] num = { 1 };
                socket.Send(num);
                button1.Text = PlayerChar.ToString();
                MessageReciver.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] num = { 2 };
                socket.Send(num);
                button2.Text = PlayerChar.ToString();
                MessageReciver.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] num = { 3 };
                socket.Send(num);
                button3.Text = PlayerChar.ToString();
                MessageReciver.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] num = { 4 };
                socket.Send(num);
                button4.Text = PlayerChar.ToString();
                MessageReciver.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] num = { 5 };
                socket.Send(num);
                button5.Text = PlayerChar.ToString();
                MessageReciver.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] num = { 6 };
                socket.Send(num);
                button6.Text = PlayerChar.ToString();
                MessageReciver.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] num = { 7 };
                socket.Send(num);
                button7.Text = PlayerChar.ToString();
                MessageReciver.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] num = { 8 };
                socket.Send(num);
                button8.Text = PlayerChar.ToString();
                MessageReciver.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] num = { 9 };
                socket.Send(num);
                button9.Text = PlayerChar.ToString();
                MessageReciver.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void game_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                MessageReciver.WorkerSupportsCancellation = true;
                MessageReciver.CancelAsync();
                if (server != null)
                {
                    server.Stop();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
