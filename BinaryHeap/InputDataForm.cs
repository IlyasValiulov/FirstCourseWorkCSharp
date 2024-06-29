namespace Курсовая;
/// <summary>
/// Форма ввода данных
/// </summary>
public partial class InputDataForm : Form
{
    private Element _element;
    private event Action<Element>? ElementDelegate;
    public InputDataForm()
    {
        InitializeComponent();
    }
    public void AddEvent(Action<Element> elementDelegate)
    {
        if (ElementDelegate == null)
        {
            ElementDelegate = elementDelegate;
        }
        else
        {
            ElementDelegate += elementDelegate;
        }
    }
    private void buttonAdd_Click(object sender, EventArgs e)
    {
        _element = new Element();
        _element.number = (int)numericUpDown.Value;
        ElementDelegate?.Invoke(_element);
        Close();
    }

    private void buttonClose_Click(object sender, EventArgs e)
    {
        Close();
    }
}
