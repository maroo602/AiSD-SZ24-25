namespace Algorytmyistrukturydanych
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
        string ToString(int[] tab)
        {
            string wynik = "";
            for (int i = 0; i < tab.Length; i++)
            {
                wynik += tab[i].ToString() + " ";
            }
            return wynik;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int[] tab = { 8, 7, 2, 1, 3, 5, 2 };
            for(int i = 0; i < tab.Length; i++)
            {
                for(int j = 0; j < tab.Length - 1; j++)
                {
                    int temp;
                    if (tab[j] > tab[j + 1])
                    {
                        temp = tab[j];
                        tab[j] = tab[j + 1];
                        tab[j + 1] = temp;
                    }
                }
            }

            MessageBox.Show(ToString(tab));


        }
    }
}