using System.Drawing;
using System.Runtime.Intrinsics.X86;

namespace practice1;

public partial class Form1 : Form
{
    int[] arr;
    int arrLen;
    int[,] arr2D;
    int arr2DCols;
    int arr2DRows;
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
            "Переставить обратном порядке элементы массива, расположенные\r\n" +
            "наибольшим отрицательным и наименьшим положительным.\r\n";
    }

    private void Button3_Click(object sender, EventArgs e)
    {
        task = 3;
        labelTask.Text = "Дан целочисленный одномерный массив размера N.\r\n" +
            "Вставить -1 после каждого отрицательного элемента массива.\r\n";
    }

    private void Button4_Click(object sender, EventArgs e)
    {
        task = 4;
        labelTask.Text = "Дан целочисленный одномерный массив размера N.\r\n" +
            "Удалить из массива все отрицательный элементы.";
    }

    private void Button5_Click(object sender, EventArgs e)
    {
        task = 5;
        labelTask.Text = "Дан целочисленный двумерный массив размера N*N.\r\n" +
            "Добавить в массив строку 1 после каждой строки, в которой\r\n" +
            "есть хотя бы один элемент, меньший по модулю среднего\r\n" +
            "арифметического четных элементов массива";
    }

    private void Button6_Click(object sender, EventArgs e)
    {
        task = 6;
        labelTask.Text = "Дан целочисленный двумерный массив размера N*N.\r\n" +
            "Упорядочить элементы в матрице по возрастанию\r\n" +
            "(слева направо, сверху - вниз)";
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
        if (int.TryParse(textBoxColumns.Text, out arrLen))
        {
            arr = new int[arrLen * 2];
        }
        else { return; }
        int.TryParse(textBoxMax.Text, out int max);

        for (int i = 0; i < arrLen; i++)
        {
            arr[i] = r.Next(0 - max, max);
            textBoxArray.Text += arr[i] + " ";
        }
    }

    private void ButtonTwoDim_Click(object sender, EventArgs e)
    {
        textBoxArray.Text = "";
        Random r = new Random();
        if (int.TryParse(textBoxColumns.Text, out arr2DCols))
        {
            arr2DRows = arr2DCols;
            arr2D = new int[arr2DRows * 2, arr2DCols * 2];
        }
        else { return; }

        for (int i = 0; i < arr2DRows; i++)
        {
            for (int j = 0; j < arr2DCols; j++)
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
        int maxVal = 0;
        int minVal = int.MaxValue;

        int maxIdx = -1;
        int minIdx = -1;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < 0 && arr[i] < maxVal)
            {
                maxVal = arr[i];
                maxIdx = i;
            }
            if (arr[i] > 0 && arr[i] < minVal)
            {
                minVal = arr[i];
                minIdx = i;
            }
        }

        if (minIdx == -1 || maxIdx == -1) return;

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
        for (int i = 0; i < arrLen; i++)
        {
            if (arr[i] < 0 && arrLen + 1 != arr.Length)
            {
                for (int j = arrLen; j > i; j--)
                {
                    arr[j] = arr[j - 1];
                }
                arr[++i] = -1;
                arrLen++;
            }
        }

        for (int i = 0; i < arrLen; i++)
        {
            textBoxOutput.Text += arr[i] + " ";
        }
    }
    
    void Task4()
    {
        textBoxOutput.Text = "";

        for (int i = 0; i < arrLen; i++)
        {
            if (arr[i] < 0)
            {
                arrLen--;
                for (int j = i; j < arrLen; j++)
                {
                    arr[j] = arr[j + 1];
                }
                i--;
            }
        }

        for (int i = 0; i < arrLen; i++)
        {
            textBoxOutput.Text += arr[i] + " ";
        }
    }

    void Task5()
    {
        textBoxOutput.Text = "";
        int sum = 0;
        int count = 0;
        for (int i = 0; i < arr2DRows; i++)
        {
            for (int j = 0; j < arr2DCols; j++)
            {
                if (arr2D[i,j] % 2 == 0)
                {
                    sum += arr2D[i,j];
                    count++;
                }
            }
        }

        for (int i = 0; i < arr2DRows; i++)
        {
            for (int j = 0; j < arr2DCols; j++)
            {
                if (i < arr2DRows && Math.Abs(arr2D[i, j]) < (sum / count))
                {
                    AddRow(i + 1);

                    if (i < arr2DRows - 1)
                    {
                        i += 2;
                        j = -1;
                    }
                }
            }
        }


        for (int i = 0; i < arr2DRows; i++)
        {
            for (int j = 0; j < arr2DCols; j++)
            {
                textBoxOutput.Text += arr2D[i, j] + " ";
            }
            textBoxOutput.Text += "\r\n";
        }
    }

    void AddRow(int row)
    {
        if (arr2DRows >= arr2D.GetLength(0))
            return;
        arr2DRows++;

        for (int i = arr2DRows - 1; i > row; i--)
        {
            for (int j = 0; j < arr2DCols; j++)
            {
                arr2D[i, j] = arr2D[i - 1, j];
            }
        }

        for (int i = 0; i < arr2DRows; i++)
        {
            arr2D[row, i] = 1;
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
            for (int i = 0; i < arr2DRows; i++)
            {
                for (int j = 0; j < arr2DCols; j++)
                {
                    if (j + 1 != arr2DCols && arr2D[i, j] > arr2D[i, j + 1])
                    {
                        tmp = arr2D[i, j];
                        arr2D[i, j] = arr2D[i, j + 1];
                        arr2D[i, j + 1] = tmp;
                        sorted = false;
                    }
                    else if (j + 1 == arr2DCols && i + 1 != arr2DCols && arr2D[i, j] > arr2D[i + 1, 0])
                    {
                        tmp = arr2D[i, j];
                        arr2D[i, j] = arr2D[i + 1, 0];
                        arr2D[i + 1, 0] = tmp;
                        sorted = false;
                    }
            }
            }
        }

        for (int i = 0; i < arr2DRows; i++)
        {
            for (int j = 0; j < arr2DCols; j++)
            {
                textBoxOutput.Text += arr2D[i, j] + " ";
            }
            textBoxOutput.Text += "\r\n";
        }
    }
}
