namespace Курсовая;
/// <summary>
/// Форма визуализация
/// </summary>
public partial class BinaryHeapForm : Form
{
    private ManadgmentHeap manadgmentHeap;
    private Storage storage;
    private HeapVisiualizator? visualizator;
    public BinaryHeapForm()
    {
        InitializeComponent();
        storage = new Storage();
        manadgmentHeap = new ManadgmentHeap(storage);
    }
    private void Draw(int index)
    {
        if (storage == null)
        {
            return;
        }
        Bitmap bmp = new(pictureBoxHeap.Width, pictureBoxHeap.Height);
        Graphics gr = Graphics.FromImage(bmp);
        visualizator = new HeapVisiualizator(pictureBoxHeap.Width);
        visualizator?.VisiulationHeap(storage.getHeap(index), gr);
        pictureBoxHeap.Image = bmp;
    }
    private void buttonAddElement_Click(object sender, EventArgs e)
    {
        InputDataForm form = new();
        form.Show();
        form.AddEvent(SetElement);
    }
    private void SetElement(Element element)
    {
        if (element == null) return;
        int index = manadgmentHeap.addElement(element);
        Draw(index);
    }

    private void buttonForwardStep_Click(object sender, EventArgs e)
    {
        int index = manadgmentHeap.ForwardStep();
        if (index == -1) return;
        Draw(index);
    }

    private void buttonBackStep_Click(object sender, EventArgs e)
    {
        int index = manadgmentHeap.BackStep();
        if (index == -1) return;
        Draw(index);
    }
    private void buttonSkipForward_Click(object sender, EventArgs e)
    {
        int index = manadgmentHeap.ForwardSkip();
        if (index == -1) return;
        Draw(index);
    }

    private void buttonSkipBack_Click(object sender, EventArgs e)
    {
        int index = manadgmentHeap.BackSkip();
        if (index == -1) return;
        Draw(index);
    }

    private void saveFileDialogToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            if (storage.SaveData(saveFileDialog.FileName))
            {
                MessageBox.Show("Сохранение прошло успешно",
                "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Не сохранилось", "Результат",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void loadToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            if (storage.LoadData(openFileDialog.FileName))
            {
                MessageBox.Show("Загрузка прошла успешно",
                "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                manadgmentHeap.currentStorageIndex = storage.Count - 1;
                Draw(manadgmentHeap.currentStorageIndex);
            }
            else
            {
                MessageBox.Show("Не сохранилось", "Результат",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void informationToolStripMenuItem_Click(object sender, EventArgs e)
    {
        InformationForm form = new();
        form.Show();
    }
}