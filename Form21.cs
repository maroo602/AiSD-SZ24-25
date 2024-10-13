using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PO01
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
            MessageBox.Show("");

        }


        private void button2_Click(object sender, EventArgs e)
        {
            string ToString(int[] tab)
            {
                string wynik = "";
                for (int i = 0; i < tab.Length; i++)
                {
                    wynik += tab[i] + "";

                }
                return wynik;
            }
            MessageBox.Show(ToString(int[] tab));
        }
    }
    }
