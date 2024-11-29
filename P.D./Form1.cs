using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
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

        private void button1_Click(object sender, EventArgs e)
        {
            int[] tab = { 8, 7, 1, 3, 5, 2, 4 };
            int xd = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = 0; j < tab.Length - 1; j++)
                {
                    if (tab[j] > tab[j + 1])
                    {
                        xd = tab[j];
                        tab[j] = tab[j + 1];
                        tab[j + 1] = xd;

                    }
                }
            }
            string ToString(int[] tab)
            {
                string wynik = " ";
                for (int i = 0; i < tab.Length; i++)
                {
                    wynik += tab[i] + " ";

                }
                return wynik;
            }
            MessageBox.Show(ToString(tab));
        }
        
        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        int[] tab2 = { 8, 7, 1, 3, 5, 2, 4 };

        private void button2_Click(object sender, EventArgs e)
        {
                int n = tab2.Length;
                for (int x = 1; x < n; ++x)
                {
                    int c = tab2[x];
                    int z = x - 1;

                    while (z >= 0 && tab2[z] > c)
                    {
                        tab2[z + 1] = tab2[z];
                        z = z - 1;
                    }
                    tab2[z + 1] = c;
                }
            label1.Text = ToString(tab2);
        }

        string ToString(int[] tab2)
        {
            string wynik = "";
            for (int i = 0; i < tab2.Length; i++)
            {
                wynik += tab2[i] + " ";
            }
            return wynik;
        }

    }

}
