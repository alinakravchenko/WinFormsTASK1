namespace WinFormsTASK1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Shown += ShowMesBox_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ShowMesBox_Click(object sender, EventArgs e)
        {
            string[] array = { "Student: Кравченко Алина", "Предмет: Windows Forms", "Группа: ПВ111" };
            int numSymbol = 0;
            string caption;

            for (int i = 0; i < array.Length; i++)
            {
                numSymbol += array[i].Length;
                caption = (array.Length - 1 == i) ? $"MessageBox {i + 1}. Среднее количество символов - {numSymbol / array.Length}" : $"MessageBox {i + 1}";
                MessageBox.Show(array[i], caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}