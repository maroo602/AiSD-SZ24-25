using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Linq;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Program do Sortowania");
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
                label2.Text = ToString(tab);
                //MessageBox.Show(ToString(tab));
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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            int[] tab2 = { 8, 7, 1, 3, 5, 2, 4 };
            Insert(tab2);
            label1.Text = ToString(tab2);
            //MessageBox.Show(ToString(tab2));
        }
        private void Insert(int[] tab2)
        {
            for (int x = 1; x < tab2.Length; x++)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] tab3 = { 8, 7, 1, 3, 5, 2, 4 };
            tab3 = QuickkSort(tab3, 0, tab3.Length - 1);
            label3.Text = ToString(tab3);
            //MessageBox.Show(ToString(tab3));
        }

        public int[] QuickkSort(int[] tab3, int lewo, int prawo)
        {
            int i = lewo;
            int j = prawo;
            int pivot = tab3[lewo];

            while (i <= j)
            {
                while (tab3[i] < pivot)
                {
                    i++;
                }

                while (tab3[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    int temp = tab3[i];
                    tab3[i] = tab3[j];
                    tab3[j] = temp;
                    i++;
                    j--;
                }
            }

            if (lewo < j)
            {
                QuickkSort(tab3, lewo, j);
            }
            if (i < prawo)
            {
                QuickkSort(tab3, i, prawo);
            }

            return tab3;
        }
        public int[] Counting(int[] tab4)
        {
            int z = tab4.Length;
            int max = tab4.Max();
            int[] tab5 = new int[max + 1];
            for (int i = 0; i < max + 1; i++)
            {
                tab5[i] = 0;
            }
            for (int i = 0; i < z; i++)
            {
                tab5[tab4[i]]++;
            }
            for (int i = 0, j = 0; i <= max; i++)
            {
                while (tab5[i] > 0)
                {
                    tab4[j] = i;
                    j++;
                    tab5[i]--;
                }
            }
            return tab4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int[] tab4 = { 8, 7, 1, 3, 5, 2, 4 };
            tab4 = Counting(tab4);
            label5.Text = ToString(tab4);
            //MessageBox.Show(ToString(tab4));
        }
        public static void MergeSort(int[] tab6)
        {
            if (tab6.Length <= 1){ 
            return;
            }

            int mid = tab6.Length / 2;

            int[] lewo = new int[mid];
            int[] prawo = new int[tab6.Length - mid];

            for (int i = 0; i < mid; i++)
                lewo[i] = tab6[i];

            for (int i = mid; i < tab6.Length; i++)
                prawo[i - mid] = tab6[i];

            MergeSort(lewo);
            MergeSort(prawo);

            Merge(tab6, lewo, prawo);
        }

        private static void Merge(int[] tab6, int[] lewo, int[] prawo)
        {
            int i = 0, j = 0, k = 0;

            while (i < lewo.Length && j < prawo.Length)
            {
                if (lewo[i] <= prawo[j])
                    tab6[k++] = lewo[i++];
                else
                    tab6[k++] = prawo[j++];
            }

            while (i < lewo.Length)
                tab6[k++] = lewo[i++];

            while (j < prawo.Length)
                tab6[k++] = prawo[j++];
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int[] tab6 = { 8, 7, 1, 3, 5, 2, 4 };
            MergeSort(tab6);
            label4.Text = ToString(tab6);
            //MessageBox.Show(ToString(tab6));
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }

}




