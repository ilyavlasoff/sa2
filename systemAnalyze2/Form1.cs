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
            if (count < 1)
            {
                MessageBox.Show("Значение должно быть больше 0");
                return;
            }
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
                    try {
                        int val = 0;
                        if (!Int32.TryParse(curRow.Cells[j].Value.ToString(), out val))
                        {
                            MessageBox.Show("неверные значения");
                            return;
                        }
                        if (val == 1)
                            curList.Add(j);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                        return;
                    }
                }

                inputValues.Add(curList);
            }
            try
            {
                oper = new GraphOperator(count, inputValues);
                oper.createLevels();
                int value = int.Parse(levelUpDown.Value.ToString());
                levelList.Text = showLevelsForVal(value);
                levelUpDown.Maximum = oper.levelsCount - 1;
                allLevelCount.Text = oper.levelsCount.ToString();
                showRenamedMatrix(oper);
                string s = "";
                Dictionary<int, int> rule = oper.rule;
                foreach (KeyValuePair<int, int> p in rule)
                {
                    s += p.Key.ToString() + "=>" + p.Value.ToString() + "  ";
                }
                rules.Text = s;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return;
            } 
        }

        private void showRenamedMatrix(GraphOperator oper)
        {
            List < List < KeyValuePair<int, int> >> matrix = oper.AtoBMatrix(oper.createRenumberedGraphList());
            int bounds = oper.bounds;
            relationsMatrixView.Rows.Clear();
            relationsMatrixView.Columns.Clear();
            for (int i = 0; i != bounds; i++)
                relationsMatrixView.Columns.Add(new DataGridViewTextBoxColumn());
            for (int i = 0; i != matrix.Count; ++i)
            {
                DataGridViewRow curRow = new DataGridViewRow();
                for (int j = 0; j != bounds; ++j)
                {
                    DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
                    if (matrix[i].Contains(new KeyValuePair<int, int>(j, 1)))
                        cell.Value = 1;
                    else if (matrix[i].Contains(new KeyValuePair<int, int>(j, -1)))
                        cell.Value = -1;
                    else cell.Value = 0;
                    curRow.Cells.Add(cell);
                }
                relationsMatrixView.Rows.Add(curRow);
                relationsMatrixView.Rows[i].HeaderCell.Value = i.ToString();
            }
            for (int j = 0; j != bounds; ++j)
            {
                relationsMatrixView.Columns[j].HeaderCell.Value = j.ToString();
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
