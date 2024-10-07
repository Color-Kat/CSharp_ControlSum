namespace MyControlSum
{
    public partial class Form1 : Form
    {
        CheckSum CheckSum = new CheckSum();

        public Form1()
        {
            InitializeComponent();
        }

        private void initButton_Click(object sender, EventArgs e)
        {
            uint count, range;

            if(
                UInt32.TryParse(countInput.Text, out count) &&
                UInt32.TryParse(rangeInput.Text, out range)
            ) {
                CheckSum.initElements(count, range);
            }
            else
            {
                MessageBox.Show("Ошибка в введённых данных.");
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            List<uint> elements = CheckSum.getElements();

            if(elements.Count == 0)
            {
                MessageBox.Show("Массив не инициализирован!");
                return;
            }

            // Change the size of data grid view
            elementsGrid.RowCount = elements.Count;

            for (int i = 0; i < elements.Count; i++)
            {
                elementsGrid.Rows[i].Cells[0].Value = String.Format("{0, 12:X}", elements[i]); 
            }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            CheckSum.UpdateElements(elementsGrid);
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            List<uint> elements = CheckSum.getElements();

            string checkSumResult = CheckSum.CalcCheckSum(elements);
            resultBox.Text = checkSumResult;
        }

        private void checkSumButton_Click(object sender, EventArgs e)
        {
            bool result = CheckSum.CheckCRC(resultBox.Text);

            resultBox2.Text = result ? "Array is fine" : "Array is damaged";
        }
    }
}
