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
            MessageBox.Show("Sortowanie");
            label9.Text = "Sortowanie 5 metodami: Bubble, Insert, Quick, Counting, Merge.";
            this.Text = "Sortowanie";
        }

        private int[] tab1 = null;
        private string ToString(int[] tab1)
        {
            string wynik = " ";
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
        private void InsertSort()
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
        private void QuickSort(int lewo, int prawo)
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
        private void CountingSort()
        {
            int max = tab1.Max();
            int[] tab2 = new int[max + 1];
            for (int i = 0; i < max + 1; i++)
            {
                tab2[i] = 0;
            }
            for (int i = 0; i < tab1.Length; i++)
            {
                tab2[tab1[i]]++;
            }
            for (int i = 0, j = 0; i <= max; i++)
            {
                while (tab2[i] > 0)
                {
                    tab1[j] = i;
                    j++;
                    tab2[i]--;
                }
            }
        }
        private void MergeSort(int[] tab1)
        {
            if (tab1.Length <= 1)
            {
                return;
            }

            int mid = tab1.Length / 2;

            int[] lewo = new int[mid];
            int[] prawo = new int[tab1.Length - mid];

            for (int i = 0; i < mid; i++)
            {
                lewo[i] = tab1[i];
            }
            for (int i = mid; i < tab1.Length; i++)
            {
                prawo[i - mid] = tab1[i];
            }

            MergeSort(lewo);
            MergeSort(prawo);

            Merge(tab1, lewo, prawo);
        }

        private void Merge(int[] tab1, int[] lewo, int[] prawo)
        {
            int i = 0, j = 0, k = 0;

            while (i < lewo.Length && j < prawo.Length)
            {
                if (lewo[i] <= prawo[j])
                    tab1[k++] = lewo[i++];
                else
                    tab1[k++] = prawo[j++];
            }

            while (i < lewo.Length)
                tab1[k++] = lewo[i++];

            while (j < prawo.Length)
                tab1[k++] = prawo[j++];
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

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GenTab(10);
            label8.Text = ToString(tab1);
            CountingSort();
            label2.Text = ToString(tab1);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            GenTab(10);
            label10.Text= ToString(tab1);
            MergeSort(tab1);
            label11.Text= ToString(tab1);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
