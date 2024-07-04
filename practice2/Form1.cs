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
    CircularList<int> circularList = new CircularList<int>();

    private void ButtonCircularListAdd_Click(object sender, EventArgs e)
    {
        int.TryParse(textBoxCircularList.Text, out int value);
        circularList.Add(value);
    }

    private void ButtonCircularListRemove_Click(object sender, EventArgs e)
    {
        int.TryParse(textBoxCircularList.Text, out int value);
        circularList.Remove(value);
    }

    private void ButtonCircularListPrint_Click(object sender, EventArgs e)
    {
        textBoxCircularList.Text = "";
        foreach (var item in circularList)
        {
            textBoxCircularList.Text += item.ToString() + " ";
        }
    }

    /// <summary>
    /// Task2
    /// </summary>
    int[] arr;
    static List<int[]> steps = new List<int[]>();
    int step = 0;

    public const int RUN = 4;

    private void ButtonSortGenerate_Click(object sender, EventArgs e)
    {
        step = 0;
        textBoxSortSource.Text = "";
        steps.Clear();

        arr = new int[10];
        Random r = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = r.Next(-10, 10);
            textBoxSortSource.Text += arr[i] + " ";
        }
    }

    private void ButtonSortStep_Click(object sender, EventArgs e)
    {
        textBoxSortOutput.Text = "";
        TimSort(arr, arr.Length);

        for (int i = 0; i < arr.Length; i++)
        {
            textBoxSortOutput.Text += steps[step][i] + " ";
        }
        step++;
    }

    public static void InsertionSort(int[] arr, int left, int right)
    {
        for (int i = left + 1; i <= right; i++)
        {
            int temp = arr[i];
            int j = i - 1;
            while (j >= left && arr[j] > temp)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = temp;
            int[] tmpArr = new int[arr.Length];
            arr.CopyTo(tmpArr, 0);
            steps.Add(tmpArr);
        }
    }

    public static void Merge(int[] arr, int l, int m, int r)
    {
        int len1 = m - l + 1;
        int len2 = r - m;
        int[] left = new int[len1];
        int[] right = new int[len2];

        for (int x = 0; x < len1; x++)
        {
            left[x] = arr[l + x];
        }

        for (int x = 0; x < len2; x++)
        {
            right[x] = arr[m + 1 + x];
        }

        int i = 0;
        int j = 0;
        int k = l;

        while (i < len1 && j < len2)
        {
            if (left[i] <= right[j])
            {
                arr[k] = left[i];
                i++;
                int[] tmpArr = new int[arr.Length];
                arr.CopyTo(tmpArr, 0);
                steps.Add(tmpArr);
            }
            else
            {
                arr[k] = right[j];
                j++;
                int[] tmpArr = new int[arr.Length];
                arr.CopyTo(tmpArr, 0);
                steps.Add(tmpArr);
            }
            k++;
        }

        while (i < len1)
        {
            arr[k] = left[i];
            k++;
            i++;
        }

        while (j < len2)
        {
            arr[k] = right[j];
            k++;
            j++;
        }
    }

    public static void TimSort(int[] arr, int n)
    {
        for (int i = 0; i < n; i += RUN)
        {
            InsertionSort(arr, i, Math.Min((i + RUN - 1), (n - 1)));
        }

        for (int size = RUN; size < n; size = 2 * size)
        {
            for (int left = 0; left < n; left += 2 * size)
            {
                int mid = left + size - 1;
                int right = Math.Min((left + 2 * size - 1), (n - 1));
                
                if (mid < right)
                {
                    Merge(arr, left, mid, right);
                }
            }
        }
    }

    /// <summary>
    /// Task3
    /// </summary>
    int vert;
    List<int>[] adjList;
    int verts;
    bool[] visited;

    public void AddEdge(int u, int v) { adjList[u].Add(v); }

    public void BFS(int startNode, int lookup)
    {
        Queue<int> queue = new Queue<int>();
        visited = new bool[verts];

        visited[startNode] = true;
        queue.Enqueue(startNode);

        while (queue.Count != 0)
        {
            int currentNode = queue.Dequeue();
            textBoxGraphOutput.Text += currentNode + " ";

            foreach (int neighbor in adjList[currentNode])
            {
                if (!visited[neighbor])
                {
                    if (neighbor == lookup)
                        return;
                    visited[neighbor] = true;
                    queue.Enqueue(neighbor);
                }
            }
        }
    }

    private void ButtonGraphSearch_Click(object sender, EventArgs e)
    {
        textBoxGraphList.Text = "";
        textBoxGraphOutput.Text = "";

        verts = 5;
        adjList = new List<int>[verts];
        for (int i = 0; i < verts; ++i)
        {
            adjList[i] = new List<int>();
        }

        AddEdge(0, 1);
        AddEdge(0, 2);
        AddEdge(1, 3);
        AddEdge(1, 4);
        AddEdge(2, 4);

        int.TryParse(textBoxGraphSearch.Text, out int value);
        BFS(0, value);

        for (int i = 0; i < adjList.Length; i++)
        {
            textBoxGraphList.Text += i + ": ";
            for (int j = 0; j < adjList[i].Count; j++)
            {
                textBoxGraphList.Text += adjList[i][j] + " ";
            }
            textBoxGraphList.Text += "\r\n";
        }

        textBoxGraphOutput.Text = "0: ";
        for (int i = 0; i < visited.Length; i++)
        {
            if (visited[i] == true)
            {
                textBoxGraphOutput.Text += i + " ";
            }
        }
    }
}