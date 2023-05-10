using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyScore
{
    public partial class Array_Plus : Form
    {
        public Array_Plus()
        {
            InitializeComponent();
        }

        int[] arr = { 1, 3, 5, 18, 21, 45, 48, 52, 68, 78, 81, 90, 95, 121, 150, 215, 350, 815 };
        string[] HeroNameList = { "Steven Rogers", "Anthony Edward Stark", "Wanda Maximoff", "Peter Quill", "Rocket Raccoon", "Groot", "Scott Lang", "Stephen Vincent Strange" };


        double Input;

        private void btnInputOdd_Click(object sender, EventArgs e)
        {
            String result = "";
            Input = double.Parse(txtInput.Text);
            if (Input % 2 == 0)
            {
                result = $"你卜卦的值為{Input}，是個偶數。";
                txtResult.Text = result;
            }
            else if (Input % 2 == 1)
            {
                result = $"你卜卦的值為{Input}，是個奇數。";
                txtResult.Text = result;
            }
            else
            {
                result = $"你不要唬嚨我，要問數字和整數才有解啊!";
                txtResult.Text = result;
            }
        }
                                  
                
        private void btnXmasTree_Click(object sender, EventArgs e)
        {
            int height =10;
            string result = " ";
            height = Convert.ToInt32(txtRow.Text);            
            char[,] Xtree = new char[height, height * 2];
            
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < height * 2; j++)
                {
                    Xtree[i, j] = ' ';
                    result = $"{Xtree[i, j]}";
                }
                txtResult.Text = result;
            }

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Xtree[(height-i-1), (height+j-i-1)] = '*';
                    Xtree[(height-i-1), (height+j+i)] = '*';
                }
            }
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < height * 2; j++)
                {

                }
            }


        }

        private void btnMultiTable_Click(object sender, EventArgs e)
        {
            string result = "";
            int[,] nine = new int[10, 10];

            for (int i = 1; i < 10; i++) 
            {
                for (int j = 1; j < 10; j++) 
                {
                    nine[i, j] = (i + 1) * (j + 1);
                    result += $"| {i}*{j}={i*j} | \n";
                }
                
            }
            txtResult.Text = result;
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtResult.Text = null;
        }

        private void btn0around1_Click_1(object sender, EventArgs e)
        {
            string result = "";
            int[,] array0around = new int[10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                    if (i == 0 || j == 0 || i == 9 || j == 9)
                    {
                        array0around[i, j] = 0;
                    }
                    else
                    {
                        array0around[i, j] = 1;

                    }
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    result += array0around[i, j] + " ";

                }
                txtResult.Text = result;
            }
        }

        private void btn1around0_Click_1(object sender, EventArgs e)
        {
            string result = "";
            int[,] array1around = new int[10, 10];


            for (int i = 0; i < 10; i++)
            {
                array1around[i, 0] = 1;
                array1around[i, 9] = 1;
                array1around[0, i] = 1;
                array1around[9, i] = 1;
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    result += array1around[i, j] + " ";

                }
                txtResult.Text = result;

            }
        }

        private void btn01Mix_Click_1(object sender, EventArgs e)
        {
            string result = "";
            int[,] arrayMix = new int[10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    arrayMix[i, j] = (i + j) % 2;
                    result += $"{arrayMix[i, j]} \n";
                    txtResult.Text = result;
                }

            }
        }

        void GenericSwap<NS>(ref NS N1, ref NS N2)
        {
            NS T = N1;
            N1 = N2;
            N2 = T;
        }

        private void btnSwap_Click_1(object sender, EventArgs e)
        {
            int n1 = 100;
            int n2 = 200;
            string result = "";
            GenericSwap<int>(ref n1, ref n2);
            result = $"【換位前】 \n n1 = 100, n2 = 200  \n 【換位後】 \n n1 = {n1}, n2 = {n2}。";
            txtResult.Text = result;
        }

        private void btnOddNum_Click_1(object sender, EventArgs e)
        {
            String result = "";
            int CarNum = 0; //基數
            int OddNum = 0; //偶數
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    OddNum++;
                }
                else
                {
                    CarNum++;
                }
                result = $"掐指一算，此陣列有{CarNum}個基數，{OddNum}個偶數。";
                txtResult.Text = result;
            }
        }

        private void btnMinNum_Click_1(object sender, EventArgs e)
        {
            String result = "";
            int MinNum;

            MinNum = arr.Min();
            result = $"掐指一算，此陣列最小值為{MinNum}。";
            txtResult.Text = result;
        }

        private void btnMaxNum_Click_1(object sender, EventArgs e)
        {
            String result = "";
            int MaxNum;

            MaxNum = arr.Max();
            result = $"掐指一算，此陣列最大值為{MaxNum}。";
            txtResult.Text = result;
        }

        private void btnMinMaxNum_Click_1(object sender, EventArgs e)
        {
            String result = "";
            int MinNum;
            int MaxNum;
            MinNum = arr.Min();
            MaxNum = arr.Max();
            result = $"掐指一算，此陣列最小值為{MinNum}，最大值為{MaxNum}。";
            txtResult.Text = result;
        }

        private void btnSumNum_Click_1(object sender, EventArgs e)
        {
            String result = "";
            int SumNum;
            SumNum = arr.Sum();
            result = $"掐指一算，此陣列總和{SumNum}。";
            txtResult.Text = result;
        }

        private void btnLongName_Click_1(object sender, EventArgs e)
        {
            String result = "";
            String Longest = "";

            foreach (string s in HeroNameList)
            {
                Longest = s + " ";
            }

            //int val2 = Math.Max(HeroNameList.GetLength(1), HeroNameList.GetLength(2));
            //int winner = Math.Max(HeroNameList.GetLength(0), Math.Max(HeroNameList.GetLength(1), Math.Max(HeroNameList.GetLength(2), Math.Max(HeroNameList.GetLength(3), Math.Max(HeroNameList.GetLength(4), Math.Max(HeroNameList.GetLength(5), Math.Max(HeroNameList.GetLength(6), HeroNameList.GetLength(7))))))));

            result = $"比較過長度後，最後勝出的是{Longest}。";
            txtResult.Text = result;
        }

        private void btnC_Click_1(object sender, EventArgs e)
        {
            String Heroes = "Steven Rogers/Anthony Edward Stark/Wanda Maximoff/Peter Quill/Rocket Raccoon/Groot/Scott Lang/Stephen Vincent Strange";
            int count = 0;
            foreach (char c in Heroes)
            {
                if (c == 'c' ^ c == 'C')
                {
                    count++;
                }
                string result;
                result = $"掐指一算，復仇者聯盟裡面角色名字有'C'這個單字，一共{count}個。";
                txtResult.Text = result;

            }
        }
    }
}
