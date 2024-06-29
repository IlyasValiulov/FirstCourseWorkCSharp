namespace Курсовая;

public class HeapVisiualizator
{
    private int parentwidth;
    private int parentheight;
    private int stepwidth = 224;
    private int stepheight = 100;
    private int massiveside = 30;
    public HeapVisiualizator(int width)
    {
        parentwidth = width / 2;
        parentheight = 60;
    }
    public void VisiulationHeap(Heap _heap, Graphics g)
    {
        if (_heap == null) return;

        //отрисовка массива
        Pen pen = new Pen(Brushes.Black, 2);
        int massiveleft = 2;
        int massiveup = 5;       
        for (int i = 1; i <= _heap.MaxCount; i++)
        {
            g.DrawRectangle(pen, massiveleft + i * massiveside, massiveup, massiveside, massiveside);
            g.DrawString((i-1).ToString(), new Font("Arial", 10), Brushes.Black, massiveleft + i*massiveside + 5, massiveup + massiveside + 2);
            if (i - 1 < _heap.heapSize)
            {
                string number = _heap.list[i - 1].ToString();
                DrawNumberInMassive(g, new Font("Arial", 12), number, massiveleft + i * massiveside, massiveup);
            }
        }
        
        if (_heap.heapSize == 0) return;

        //отрисовка дерева
        Font font = new Font("Arial", 20);
        g.DrawEllipse(new Pen(Brushes.Black, 2), parentwidth, parentheight, 50, 50);
        DrawNumberInEllipse(g, font, _heap.list[0].ToString(), parentwidth, parentheight);

        int parent = 0;
        int leftchild = parent * 2 + 1;
        int rightchild = parent * 2 + 2;
        
        int leftwidth = parentwidth - stepwidth;
        int levelheight = parentheight + stepheight;
        while (leftchild < _heap.heapSize) {
            int elwidth = leftwidth;
            for (int j = leftchild; j <= rightchild; j++)
            {
                if (j >= _heap.heapSize) break;
                g.DrawEllipse(pen, elwidth, levelheight, 50, 50);
                string number = _heap.list[j].ToString();
                DrawNumberInEllipse(g, font, number, elwidth, levelheight);
                DrawLine(g, j, elwidth, levelheight);
                elwidth += 2 * stepwidth;
            }
            leftchild = rightchild + 1;
            rightchild = rightchild * 2 + 2;
            stepwidth /= 2;
            stepheight -= 5;
            leftwidth -= stepwidth;
            levelheight += stepheight;
        }
    }
    public void DrawNumberInMassive(Graphics g, Font font, string number, int left, int up)
    {
        if (number.Length == 1)
            g.DrawString(number, font, Brushes.Black, left + 8, up + 7);
        else if (number.Length == 2)
            g.DrawString(number, font, Brushes.Black, left + 3, up + 7);
        else
            g.DrawString(number, font, Brushes.Black, left - 2, up + 7);
    }
    private void DrawLine(Graphics g, int index, int elwidth, int levelheight)
    {
        if (index % 2 != 0)
            g.DrawLine(new Pen(Brushes.Black, 2), elwidth + stepwidth + 25, levelheight - stepheight + 55, elwidth + 25, levelheight - 5);
        else
            g.DrawLine(new Pen(Brushes.Black, 2), elwidth - stepwidth + 25, levelheight - stepheight + 55, elwidth + 25, levelheight - 5);
    }
    private void DrawNumberInEllipse(Graphics g, Font font, string number, int elwidth, int levelheight)
    {
        if (number.Length == 1)
            g.DrawString(number, font, Brushes.Black, elwidth + 15, levelheight + 10);
        else if (number.Length == 2)
            g.DrawString(number, font, Brushes.Black, elwidth + 7, levelheight + 10);
        else
            g.DrawString(number, font, Brushes.Black, elwidth - 2, levelheight + 10);
    }
}
