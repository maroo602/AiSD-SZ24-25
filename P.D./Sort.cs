using System.Runtime.InteropServices.JavaScript;
using System.Text.Json.Serialization;
using System.Xml.Linq;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int[] tab1 = null;
        string ToString(int[] tab1)
        {
            string wynik = "";
            for (int i = 0; i < tab1.Length; i++)
            {
                wynik += tab1[i] + " ";
            }
            return wynik;
        }
        private void GenTab(int rozmiar)
        {
            Random random = new Random();
            tab1 = new int[rozmiar];
            for (int i = 0; i < tab1.Length; i++)
            {
                tab1[i] = random.Next(1, 101);
            }
        }
        private void BubbleSort()
        {
            int xd = 0;
            for (int i = 0; i < tab1.Length; i++)
            {
                for (int j = 0; j < tab1.Length - 1; j++)
                {
                    if (tab1[j] > tab1[j + 1])
                    {
                        xd = tab1[j];
                        tab1[j] = tab1[j + 1];
                        tab1[j + 1] = xd;
                    }

                }
            }
        }
        public void InsertSort()
        {
            for (int i = 0; i < tab1.Length; i++)
            {
                int k = tab1[i];
                int j = i - 1;
                while (j >= 0 && tab1[j] > k)
                {
                    tab1[j + 1] = tab1[j];
                    j = j - 1;
                }
                tab1[j + 1] = k;
            }
        }

        public void QuickSort(int lewo, int prawo)
        {
            int i = lewo;
            int j = prawo;
            int pivot = tab1[(lewo + prawo) / 2];
            while (i <= j)
            {
                while (tab1[i] < pivot)
                {
                    i++;
                }
                while (tab1[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int xd = tab1[i];
                    tab1[i] = tab1[j];
                    tab1[j] = xd;
                    i++;
                    j--;
                }
            }
            if (lewo < j)
            {
                QuickSort(lewo, j);
            }
            if (i < prawo)
            {
                QuickSort(i, prawo);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenTab(10);
            label5.Text = ToString(tab1);
            BubbleSort();
            label1.Text = ToString(tab1);
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            GenTab(10);
            label6.Text = ToString(tab1);
            InsertSort();
            label3.Text = ToString(tab1);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            GenTab(10);
            label7.Text = ToString(tab1);
            QuickSort(0, tab1.Length - 1);
            label4.Text = ToString(tab1);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
