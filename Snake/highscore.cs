using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Snake
{
    public partial class highscore : Form
    {
        List<String> nameList = new List<String>();

        public List<String> list()
        {
            List<string> info = new List<string>();
            StreamReader sr = new StreamReader(@"D:\temp\Scores.txt");
            string oneLine;
            string[] one;
            oneLine = sr.ReadLine();
            while (oneLine != null)
            {
                one = oneLine.Split(',');

                info.Add(one[0]);

                oneLine = sr.ReadLine();
           
            }
            // [10,sean][20,fangchong][30,hariz]
            for (int q = 1; q < info.Count; q++)
            {
                for (int w = q; w > 0; w--)
                {
                    if (Convert.ToInt32(info[w].Split('.')[0]) > Convert.ToInt32(info[w - 1].Split('.')[0]))
                    {

                        String tempA = info[w];
                        String tempB = info[w - 1];
                        info[w] = tempB;
                        info[w - 1] = tempA;
                    }
                }
            }

            return info;
        }

        public highscore()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].HeaderText = "name";
            dataGridView1.Columns[1].HeaderText = "score";


            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.MultiSelect = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Rows.Clear();
            dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);

            nameList = list();
            
            for (int i = 0; i < 5; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = nameList[i].Split('.')[1];
                dataGridView1.Rows[i].Cells[1].Value = nameList[i].Split('.')[0];
            }


        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
