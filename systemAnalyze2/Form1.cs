using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace systemAnalyze2
{
    public partial class Form1 : Form
    {
        private int count = 0;
        private GraphOperator oper = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void topsCount_ValueChanged(object sender, EventArgs e)
        {
            count = Int32.Parse(topsCount.Value.ToString());
            relationsMatrixView.RowCount = count;
            relationsMatrixView.ColumnCount = count;
            for (int i=0; i!= count; i++)
            {
                relationsMatrixView.Rows[i].HeaderCell.Value = $"{i}";
                relationsMatrixView.Columns[i].HeaderCell.Value = $"{i}";
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            List<List<int>> inputValues = new List<List<int>>();
            for (int i = 0; i != count; ++i)
            {
                DataGridViewRow curRow = relationsMatrixView.Rows[i];
                List<int> curList = new List<int>();
                for (int j = 0; j != count; ++j)
                {
                    int val = 0;
                    if (!Int32.TryParse(curRow.Cells[j].Value.ToString(), out val))
                    {
                        MessageBox.Show("неверные значения");
                        return;
                    }
                    if (val == 1)
                        curList.Add(j);
                }
                inputValues.Add(curList);
            }
            //inputValues.Add(new List<int> { 1, 6 });
            //inputValues.Add(new List<int> { 2, 3 });
            //inputValues.Add(new List<int> { });
            //inputValues.Add(new List<int> { });
            //inputValues.Add(new List<int> { 3 });
            //inputValues.Add(new List<int> { 2, 3 });
            //inputValues.Add(new List<int> { 1 });
            //inputValues.Add(new List<int> { 5, 6 });
            //inputValues.Add(new List<int> { 1 });
            //inputValues.Add(new List<int> { 4,6,7,8 });
            oper = new GraphOperator(count, inputValues);
            oper.createLevels();
            int value = int.Parse(levelUpDown.Value.ToString());
            levelList.Text = showLevelsForVal(value);
            levelUpDown.Maximum = oper.levelsCount - 1;
            allLevelCount.Text = oper.levelsCount.ToString();
            showRenamedMatrix();
        }

        private void showRenamedMatrix()
        {
            List<List<int>> refreshedMatrix = oper.createRenumberedGraphList();
            relationsMatrixView.Rows.Clear();
            foreach(List<int> l in refreshedMatrix)
            {
                DataGridViewRow dgvr = new DataGridViewRow();
                for(int i=0; i!= count; ++i)
                {
                    DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
                    if (l.Contains(i)) cell.Value = "1";
                    else cell.Value = "0";
                    dgvr.Cells.Add(cell);
                }
                relationsMatrixView.Rows.Add(dgvr);
            }
        }

        private void levelUpDown_ValueChanged(object sender, EventArgs e)
        {
            int value = int.Parse(levelUpDown.Value.ToString());
            levelList.Text = showLevelsForVal(value);
        }

        private string showLevelsForVal(int value)
        {
            var items = oper.levels.Where(v => v.Value == value);
            string s = "";
            foreach (KeyValuePair<int, int> pair in items) 
                s += pair.Key + " ";
            return s;
        }
    }
}
