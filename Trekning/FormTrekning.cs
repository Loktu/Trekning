using System.Windows.Forms;

namespace Trekning
{
    public partial class FormTrekning : Form
    {
        public FormTrekning()
        {
            InitializeComponent();
            dataGridViewTrekning.DataSource = Program.trekningDataSet.Tables["Trekning"];
            dataGridViewTrekning.AutoResizeColumns();
            dataGridViewTrekning.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
