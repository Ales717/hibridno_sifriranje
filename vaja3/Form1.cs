namespace vaja3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            game newGame = new game(false, "127.0.0.1");
            Visible = false;
            if(!newGame.IsDisposed)
                newGame.ShowDialog();
            Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            game newgame = new game(true);
            Visible=false;
            if (!newgame.IsDisposed)
                newgame.ShowDialog();
            Visible=true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vsPc vspc = new vsPc();
            Visible = false;
            if (!vspc.IsDisposed)
                vspc.ShowDialog();
            Visible = true;
        }
    }
}