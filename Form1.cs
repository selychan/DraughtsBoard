namespace DraughtsBoard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Button[,] buttons = new Button[9, 9];
            int top = 0;
            int left = 0;
            for (int i = 0; i < buttons.GetUpperBound(0); i++) //dizinin ilk boyutunun �st s�n�r�n� verir.8*8 lik tahtam�z i�in 8 �st s�n�r�n� vermesi gerekti�inden 9*9 luk dizi kullan�r�sz.
    
            {
                for(int j=0; j < buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i,j].Height = 50;
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;
                    left += 50;
                    if ((i + j) % 2 == 0)
                    {
                        buttons[i,j].BackColor= Color.Black;
                    }    
                    else
                    {
                        buttons[i,j].BackColor= Color.White;
                    }
                    this.Controls.Add(buttons[i, j]);
                }
                top += 50;
                left = 0;
            }
            
        }
    }
}