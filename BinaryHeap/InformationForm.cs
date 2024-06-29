namespace Курсовая;
/// <summary>
/// Форма информация
/// </summary>
public partial class InformationForm : Form
{
    public InformationForm()
    {
        InitializeComponent();
        richTextBox.AppendText("Двоичная куча\n");
        richTextBox.AppendText("Двоичная куча - это двоичное дерево для которого выполнены несколько условий:\n");
        richTextBox.AppendText("\t1) Значение в любой вершине не меньше, чем значения её потомков. Такие кучи" +
            "нызывают max-heap. Кучи, где потомки не больше вершины - это min-heap\n");
        richTextBox.AppendText("\t2) Глубина всех листьев (расстояние до корня) различается не более чем на 1 слой\n");
        richTextBox.AppendText("\t3) Последний слой заполняется слева направо без пропусков\n");
        richTextBox.AppendText("\n");
        richTextBox.AppendText("Удобная структура данных для сортирующего дерева — массив. корневой элемент — A[0]," +
            " а потомки элемента A[i] — A[2i+1] и A[2i+2]. При таком способе хранения условия 2 и 3 выполнены автоматически.\n");
        richTextBox.AppendText("Высота кучи определяется как высота двоичного дерева. То есть она равна количеству рёбер в самом " +
            "длинном простом пути, соединяющем корень кучи с одним из её листьев. Высота кучи есть " +
            "O(logN), где N — количество узлов дерева.\n");

        richTextBox1.AppendText("Алгоритм добавления в бинарную кучу\n\n");
        richTextBox1.AppendText("Алгоритм добавления элемента в бинарную кучу (на примере мин-кучи) выглядит следующим образом:" +
            "\r\n\r\n1) Добавьте новый элемент в конец кучи (массива).\r\n\r2) Сравните новый элемент со своим родительским узлом. " +
            "Если новый элемент меньше родительского, поменяйте их местами.\r\n\r3) Повторите шаг 2, пока новый элемент не станет " +
            "больше или равен своему родительскому узлу или пока он не окажется в корне дерева.\n\n");
        richTextBox1.AppendText("Описание работы программы:\n\n");
        richTextBox1.AppendText("При запуске программы пользователь увидит окно с нескольками кнопками.\n" +
            "\t1) \"Add Element\" - при нажатии на данную кнопку откроется форма InputData" +
            "\n\n\t2) \"Skip Back\" - в начало работы алгоритма" +
            "\n\n\t3) \"Back Step\" - шаг назад" + "\n\t4) \"Forward Step\" - шаг вперед" +
            "\n\n\t5) \"Skip Forward\" - в конец работы алгоритма\n");
        richTextBox1.AppendText("В меню \"Файл\" можно загрузить или сохранить в файл бинарное дерево\n");
        richTextBox1.AppendText("Форма InputData:\n Открывается при нажатии на кнопку \"Add Element\". " +
            "На форме присутвуют три элемента:\n" +
            "\t1) Поле ввода \"numeric\" - используется для ввода числа в диапазоне от -99 до 100 включительно\n\n" +
            "\t2) Кнопка \"Добавить\" - при нажатии кнопки выбранный элемент добавляется в кучу\n\n" +
            "\t3) Кнопка \"Отмена\" - при нажатии кнопки вы возвращаетесь на главную форму без добавление какого либо элемента\n\n\n" +
            "Создатель программы: Валиулов Ильяс\t @hgvstr\t 10.05.2024");
        //richTextBox1.MouseWheel += richTextBox1_MouseWheel;
    }

    private void buttonClose_Click(object sender, EventArgs e)
    {
        Close();
    }
    void richTextBox1_MouseWheel(object sender, MouseEventArgs e)
    {
        if (e.Delta > 0)
        {
            if (richTextBox1.SelectionStart > 20)
            {
                richTextBox1.SelectionStart -= 20;
                richTextBox1.ScrollToCaret();
            }
        }
        else
        {
            richTextBox1.SelectionStart += 20;
            richTextBox1.ScrollToCaret();
        }
    }
}
