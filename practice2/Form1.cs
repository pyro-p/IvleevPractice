namespace practice2;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Task1
    /// </summary>
    Stack<int> stack = new Stack<int>();

    private void ButtonStackPush_Click(object sender, EventArgs e)
    {
        int.TryParse(textBoxStack.Text, out int value);
        stack.Push(value);
    }

    private void ButtonStackPop_Click(object sender, EventArgs e)
    {
        textBoxStack.Text = stack.Pop().ToString();
    }

    private void ButtonStackPrint_Click(object sender, EventArgs e)
    {
        textBoxStack.Text = "";
        foreach (var item in stack)
        {
            textBoxStack.Text = textBoxStack.Text.Insert(0, item.ToString() + " ");
        }
    }

    /// <summary>
    /// Task2
    /// </summary>
    int[] arr;
    static int half = 0;
    int step;
    (int[], int[]) buffs;
    (int[], int[]) buffs1;
    (int[], int[]) buffs2;

    private void ButtonSortGenerate_Click(object sender, EventArgs e)
    {
        textBoxSortSource.Text = "";
        step = 1;

        arr = new int[4];
        Random r = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = r.Next(10);
            textBoxSortSource.Text += arr[i] + " ";
        }
    }

    private void ButtonSortStep_Click(object sender, EventArgs e)
    {
        switch (step)
        {
            case 1:
                textBoxSortOutput.Text = "";
                if (arr == null)
                    return;

                buffs = Split(arr);
                break;
            case 2:
                textBoxSortOutput.Text = "";
                buffs1 = Split(buffs.Item1);
                textBoxSortOutput.Text += "| ";
                buffs2 = Split(buffs.Item2);
                break;
            case 3:
                textBoxSortOutput.Text = "";
                buffs1.Item1 = Merge(buffs1.Item1, buffs1.Item2);
                textBoxSortOutput.Text += "| " + buffs2.Item1[0] + " | " + buffs2.Item2[0];
                break;
            case 4:
                textBoxSortOutput.Text = "";
                textBoxSortOutput.Text += buffs1.Item1[0] + " " + buffs1.Item1[1] + " | ";
                buffs1.Item2 = Merge(buffs2.Item1, buffs2.Item2);
                break;
            case 5:
                textBoxSortOutput.Text = "";
                Merge(buffs1.Item1, buffs1.Item2);
                break;
        }
        step++;
    }

    (int[], int[]) Split(int[] array)
    {
        half = array.Length / 2;
        int[] buffA = new int[half];
        for (int i = 0; i < half; i++)
        {
            buffA[i] = array[i];
            textBoxSortOutput.Text += array[i] + " ";
        }

        textBoxSortOutput.Text += "| ";

        int[] buffB = new int[array.Length - half];
        for (int i = half; i < array.Length; i++)
        {
            buffB[i - half] = array[i];
            textBoxSortOutput.Text += array[i] + " ";
        }
        return (buffA, buffB);
    }

    int[] Merge(int[] buffA, int[] buffB)
    {
        int[] buffC = new int[buffA.Length + buffB.Length];
        int indexA = 0, indexB = 0;

        for (int i = 0; i < buffC.Length; i++)
        {
            if (indexA < buffA.Length && indexB < buffB.Length)
            {
                if (buffA[indexA] < buffB[indexB])
                {
                    buffC[i] = buffA[indexA];
                    indexA++;
                    textBoxSortOutput.Text += buffC[i] + " ";
                }
                else
                {
                    buffC[i] = buffB[indexB];
                    indexB++;
                    textBoxSortOutput.Text += buffC[i] + " ";
                }
            }
            else if (indexA == buffA.Length && indexB < buffB.Length)
            {
                buffC[i] = buffB[indexB];
                indexB++;
                textBoxSortOutput.Text += buffC[i] + " ";
            }
            else if (indexA < buffA.Length && indexB == buffB.Length)
            {
                buffC[i] = buffA[indexA];
                indexA++;
                textBoxSortOutput.Text += buffC[i] + " ";
            }
            else
            {
                buffC[i] = 0;
            }
        }
        return buffC;
    }

    /// <summary>
    /// Task3
    /// </summary>
    static List<List<int>> matrix;
    static bool check = false;

    static void AddEdge(int x, int y)
    {
        matrix[x][y] = 1;
        matrix[y][x] = 1;
    }

    static void DFS(int start, List<bool> visited, int lookup)
    {
        if (check)
            return;
        visited[start] = true;

        for (int i = 0; i < matrix[start].Count; i++)
        {
            if (matrix[start][i] == 1 && (!visited[i]))
            {
                if (i == lookup)
                    check = true;
                DFS(i, visited, lookup);
            }
        }
    }

    private void ButtonGraphSearch_Click(object sender, EventArgs e)
    {
        textBoxGraphMatrix.Text = "";
        textBoxGraphOutput.Text = "";

        int verts = 8;

        matrix = new List<List<int>>(verts);
        for (int i = 0; i < verts; i++)
        {
            matrix.Add(new List<int>(verts));
            for (int j = 0; j < verts; j++)
            {
                matrix[i].Add(0);
            }
        }

        AddEdge(0, 1);
        AddEdge(0, 2);
        AddEdge(1, 3);
        AddEdge(1, 4);
        AddEdge(2, 5);
        AddEdge(2, 6);
        AddEdge(3, 7);

        for (int i = 0; i < matrix.Count; i++)
        {
            for (int j = 0; j < matrix[0].Count; j++)
            {
                textBoxGraphMatrix.Text += matrix[i][j] + " ";
            }
            textBoxGraphMatrix.Text += "\r\n";
        }

        List<bool> visited = new List<bool>(verts);
        for (int i = 0; i < verts; i++)
        {
            visited.Add(false);
        }

        int.TryParse(textBoxGraphSearch.Text, out int value);
        check = false;
        DFS(0, visited, value);

        for (int i = 0; i < visited.Count; i++)
        {
            textBoxGraphOutput.Text += i + ": " + visited[i] + "\r\n";
        }
    }
}