using System.Drawing;
using System.Runtime.Intrinsics.X86;

namespace practice1;

public partial class Form1 : Form
{
    int[] arr;
    int[,] arr2D;
    int task;

    public Form1()
    {
        InitializeComponent();
    }

    private void Button1_Click(object sender, EventArgs e)
    {
        task = 1;
        labelTask.Text = "Дан целочисленный одномерный массив размера N.\r\n" +
            "Серия – это последовательность элементов массива,\r\n" +
            "идущих друг за другом. Каждый элемент серии делился\r\n" +
            "нацело на предыдущий. Серия должна содержать\r\n" +
            "минимум 2 элемента. Длина серии – количество\r\n" +
            "элементов в серии. Найти серию с максимальной длиной.\r\n" +
            "Вывести с какой позиции начинается серия и ее длину.";
    }

    private void Button2_Click(object sender, EventArgs e)
    {
        task = 2;
        labelTask.Text = "Дан целочисленный одномерный массив размера N.\r\n" +
            "Переставить в обратном порядке элементы массива,\r\n" +
            "расположенные между его минимальным и максимальным\r\n" +
            "элементами.";
    }

    private void Button3_Click(object sender, EventArgs e)
    {
        task = 3;
        labelTask.Text = "Дан целочисленный одномерный массив размера N.\r\n" +
            "Вставить 2 после каждого четного элемента массива\r\n" +
            "(четный по значению, а не по порядковому номеру).";
    }

    private void Button4_Click(object sender, EventArgs e)
    {
        task = 4;
        labelTask.Text = "Дан целочисленный одномерный массив размера N.\r\n" +
            "Удалить из массива все четные элементы (четный по\r\n" +
            "значению, а не по порядковому номеру). ";
    }

    private void Button5_Click(object sender, EventArgs e)
    {
        task = 5;
        labelTask.Text = "Дан целочисленный двумерный массив размера N*N.\r\n" +
            "Добавить в массив столбец 0 после каждого столбца,\r\n" +
            "в котором есть хотя бы один элемент, больший по модулю\r\n" +
            "среднего арифметического положительных элементов\r\n" +
            "массива.";
    }

    private void Button6_Click(object sender, EventArgs e)
    {
        task = 6;
        labelTask.Text = "Дан целочисленный двумерный массив размера N*N.\r\n" +
            "Упорядочить элементы в матрице по убыванию\r\n" +
            "(слева направо, сверху-вниз)";
    }

    private void ButtonRun_Click(object sender, EventArgs e)
    {
        switch (task)
        {
            case 1:
                Task1();
                break;
            case 2:
                Task2();
                break;
            case 3:
                Task3();
                break;
            case 4:
                Task4();
                break;
            case 5:
                Task5();
                break;
            case 6:
                Task6();
                break;

        }
    }

    private void ButtonOneDim_Click(object sender, EventArgs e)
    {
        textBoxArray.Text = "";
        Random r = new Random();
        if (int.TryParse(textBoxColumns.Text, out int len))
        {
            arr = new int[len];
        }
        else { return; }

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = r.Next(int.Parse(textBoxMax.Text));
            textBoxArray.Text += arr[i] + " ";
        }
    }

    private void ButtonTwoDim_Click(object sender, EventArgs e)
    {
        textBoxArray.Text = "";
        Random r = new Random();
        if (int.TryParse(textBoxColumns.Text, out int len))
        {
            arr2D = new int[len, len];
        }
        else { return; }

        for (int i = 0; i < arr2D.GetLength(0); i++)
        {
            for (int j = 0; j < arr2D.GetLength(1); j++)
            {
                arr2D[i,j] = r.Next(int.Parse(textBoxMax.Text));
                textBoxArray.Text += arr2D[i,j] + " ";
            }
            textBoxArray.Text += "\r\n";
        }
    }

    void Task1()
    {
        textBoxOutput.Text = "";
        int? pos = null;
        int len = 0;
        int tmpLen = 0;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i; j < arr.Length - 1; j++)
            {
                if (arr[j] != 0 && arr[j + 1] != 0 && arr[j + 1] % arr[j] == 0)
                {
                    tmpLen++;
                    if (tmpLen >= len)
                    {
                        len = tmpLen + 1;
                        pos = i;
                    }
                }
                else
                {
                    tmpLen = 0;
                    if (j + 1 < arr.Length - 1)
                    {
                        i = j;
                    }
                    else
                    {
                        continue;
                    }
                    break;
                }
            }
        }

        if (pos != null)
        {
            textBoxOutput.Text = pos.ToString() + " " + len.ToString();
        }
    }

    void Task2()
    {
        textBoxOutput.Text = "";
        int maxVal = int.MinValue;
        int minVal = int.MaxValue;

        int maxIdx = int.MinValue;
        int minIdx = int.MinValue;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > maxVal)
            {
                maxVal = arr[i];
                maxIdx = i;
            }
            if (arr[i] < minVal)
            {
                minVal = arr[i];
                minIdx = i;
            }
        }

        if (minIdx < 0 || maxIdx < 0) return;

        if (minIdx > maxIdx)
        {
            int tmp = minIdx;
            minIdx = maxIdx;
            maxIdx = tmp;
        }

        for (int i = minIdx + 1, j = maxIdx - 1; i < maxIdx / 2 + 1; i++, j--)
        {
            int tmp = arr[i];
            arr[i] = arr[j];
            arr[j] = tmp;
        }

        for (int i = 0; i < arr.Length; i++)
        {
            textBoxOutput.Text += arr[i] + " ";
        }
    }

    void Task3()
    {
        textBoxOutput.Text = "";
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
            {
                for (int j = arr.Length - 1; j > i; j--)
                {
                    if (j - 1 != i)
                    {
                        arr[j] = arr[j - 1];
                    }
                    else
                    {
                        arr[j] = 2;
                    }
                }
                i++;
            }
        }

        for (int i = 0; i < arr.Length; i++)
        {
            textBoxOutput.Text += arr[i] + " ";
        }
    }
    
    void Task4()
    {
        textBoxOutput.Text = "";
        int len = arr.Length;

        for (int i = 0; i < len; i++)
        {
            if (arr[i] % 2 == 0)
            {
                len--;
                for (int j = i; j < len; j++)
                {
                    arr[j] = arr[j + 1];
                }
                i--;
            }
        }

        for (int i = 0; i < len; i++)
        {
            textBoxOutput.Text += arr[i] + " ";
        }
    }

    void Task5()
    {
        textBoxOutput.Text = "";
        int sum = 0;
        int count = 0;
        for (int i = 0; i < arr2D.GetLength(0); i++)
        {
            for (int j = 0; j < arr2D.GetLength(1); j++)
            {
                if (arr2D[i,j] > 0)
                {
                    sum += arr2D[i,j];
                    count++;
                }
            }
        }

        int row = 0;
        for (int j = row; j < arr2D.GetLength(1); j++)
        {
            for (int i = 0; i < arr2D.GetLength(0); i++)
            {
                if (Math.Abs(arr2D[i, j]) > (sum / count))
                {
                    AddCol(j + 1);

                    if (j < arr2D.GetLength(0) - 1)
                        j++;

                    row++;
                }
            }
        }


        for (int i = 0; i < arr2D.GetLength(0); i++)
        {
            for (int j = 0; j < arr2D.GetLength(1); j++)
            {
                textBoxOutput.Text += arr2D[i, j] + " ";
            }
            textBoxOutput.Text += "\r\n";
        }
    }

    void Task6()
    {
        textBoxOutput.Text = "";
        bool sorted = false;
        int tmp;

        while (!sorted)
        {
            sorted = true;
            for (int i = 0; i < arr2D.GetLength(0); i++)
            {
                for (int j = 0; j < arr2D.GetLength(1); j++)
                {
                    if (j + 1 != arr2D.GetLength(1) && arr2D[i, j] < arr2D[i, j + 1])
                    {
                        tmp = arr2D[i, j];
                        arr2D[i, j] = arr2D[i, j + 1];
                        arr2D[i, j + 1] = tmp;
                        sorted = false;
                    }
                    else if (j + 1 == arr2D.GetLength(1) && i + 1 != arr2D.GetLength(1) && arr2D[i, j] < arr2D[i + 1, 0])
                    {
                        tmp = arr2D[i, j];
                        arr2D[i, j] = arr2D[i + 1, 0];
                        arr2D[i + 1, 0] = tmp;
                        sorted = false;
                    }
            }
            }
        }

        for (int i = 0; i < arr2D.GetLength(0); i++)
        {
            for (int j = 0; j < arr2D.GetLength(1); j++)
            {
                textBoxOutput.Text += arr2D[i, j] + " ";
            }
            textBoxOutput.Text += "\r\n";
        }
    }

    void AddCol(int col)
    {
        if (col == arr2D.GetLength(0))
            return;

        for (int i = 0; i < arr2D.GetLength(0); i++)
        {
            for (int j = arr2D.GetLength(1) - 1; j > col; j--)
            {
                arr2D[i, j] = arr2D[i, j - 1];
            }
        }

        for (int i = 0; i < arr2D.GetLength(0); i++)
        {
            arr2D[i, col] = 0;
        }
    }
}
