using System.DirectoryServices;
using System.Numerics;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks.Dataflow;
using System.Windows.Forms;
using System.Windows.Forms.Design.Behavior;

namespace OTPR_C_SHARP_FinForm
{
    public partial class Form1 : Form
    {
        private bool saved = false;
        private bool saved2 = false;

        int _alternatives_count;
        int _criteria_count;

        double[,] _criteria_list;
        List<double[,]> _alternatives_list = new List<double[,]>();

        public Form1()
        {
            InitializeComponent();
        }

        private void criteria_add_Click(object sender, EventArgs e)
        {
            criteria.Rows.Add(criteria_inp.Text);
        }

        private void criteria_del_Click(object sender, EventArgs e)
        {
            try
            {
                criteria.Rows.Remove(criteria.CurrentRow);
            }
            catch (Exception)
            {

            }
        }

        private void criteria_cln_all_Click(object sender, EventArgs e)
        {
            criteria.Rows.Clear();
        }

        private void alternatives_add_Click(object sender, EventArgs e)
        {
            alternatives.Rows.Add(alternatives_inp.Text);
        }

        private void alternatives_del_Click(object sender, EventArgs e)
        {
            try
            {
                alternatives.Rows.Remove(alternatives.CurrentRow);
            }
            catch (Exception)
            {

            }
        }

        private void alternatives_cln_all_Click(object sender, EventArgs e)
        {
            alternatives.Rows.Clear();
        }


        void setup_comp()
        {
            if (saved)
                return;

            int column_width = 220;

            var criteria_list_dim = criteria.Rows.Count;
            string[] criteria_data = new string[criteria_list_dim];

            string cell_value;
            try
            {
                for (int i = 0, j = 0; i < criteria_list_dim; i++)
                {
                    cell_value = criteria.Rows[i].Cells[0].Value.ToString();
                    if (cell_value != String.Empty)
                        criteria_data[j++] = cell_value;
                }
            }
            catch (Exception)
            {

            }


            criteria_comp.AllowUserToAddRows = false;
            criteria_comp.AllowUserToDeleteRows = false;
            criteria_comp.AllowUserToOrderColumns = false;


            criteria_comp.Rows.Clear();
            criteria_comp.Columns.Clear();

            criteria_comp.RowHeadersWidth = column_width;


            for (int i = 0, j = 0; i < criteria_list_dim; i++)
            {
                if (criteria_data[i] != null && criteria_data[i] != String.Empty)
                {
                    criteria_comp.Columns.Add(criteria_data[i].ToString().Trim() + "_name", criteria_data[i].ToString());
                    criteria_comp.Columns[j].SortMode = DataGridViewColumnSortMode.NotSortable;
                    criteria_comp.Columns[j++].Width = column_width;
                }
                else
                {
                    continue;
                }
            }


            for (int i = 0, j = 0; i < criteria_list_dim; i++)
            {
                if (criteria_data[i] != null && criteria_data[i] != String.Empty)
                {
                    criteria_comp.Rows.Add();
                    criteria_comp.Rows[j++].HeaderCell.Value = criteria_data[i].ToString();
                }
                else
                {
                    continue;
                }
            }






            var criteria_count = criteria_comp.Columns.Count;
            _criteria_count = criteria_count;

            for (int i = 0; i < criteria_count; i++)
            {
                criteria_sel.Items.Add(criteria_comp.Rows[i].HeaderCell.Value.ToString());
            }


            saved = true;

        }

        private void tabs_Selected(object sender, TabControlEventArgs e)
        {
            switch (e.TabPageIndex)
            {
                case 0:
                    break;
                case 1:
                    groupBox2.Enabled = false;
                    groupBox3.Enabled = false;  
                    setup_comp();
                    break;
                case 2:
                    groupBox4.Enabled = false;
                    button2.Enabled = false;
                    button1.Enabled = false;
                    alternatives_cln.Enabled = false;
                    criteria_cln.Enabled = false;
                    result();
                    break;
            }
        }


        double[,] collect_comp()
        {
            int criteria_matrix_dim_i = criteria_comp.Columns.Count;
            int criteria_matrix_dim_j = criteria_comp.Rows.Count;
            double[,] criteria_matrix = new double[criteria_matrix_dim_i, criteria_matrix_dim_j];

            for (int i = 0; i < criteria_matrix_dim_i; i++)
            {
                for (int j = 0; j < criteria_matrix_dim_j; j++)
                {
                    criteria_matrix[i, j] = Convert.ToDouble(criteria_comp.Rows[i].Cells[j].Value);
                }
            }

            return criteria_matrix;
        }

        void result()
        {
            tabs.SelectedIndex = 2;



            MessageBox.Show(_alternatives_list.ToString());
            MessageBox.Show(_criteria_list.ToString());




            double[] result = Computation.compute_result(_criteria_list, _alternatives_list);


            for (int i = 0; i < result.Length; i++)
            {
                result_list.Rows.Add();
                result_list.Rows[i].Cells[0].Value = criteria.Rows[i].Cells[0].Value;
                result_list.Rows[i].Cells[1].Value = result[i].ToString();
            }

            result_list.Columns[1].SortMode = DataGridViewColumnSortMode.Automatic;
            result_list.Sort(result_list.Columns[1], System.ComponentModel.ListSortDirection.Descending);
            string winner = result_list.Rows[0].Cells[0].Value.ToString();
            result_text.Text = result_text.Text + winner;
        }


        private void next_main_Click(object sender, EventArgs e)
        {
            switch (tabs.SelectedIndex)
            {
                case 0:
                    tabs.SelectedIndex = 1;
                    break;
                case 1:
                    alternatives_cln.Enabled = false;
                    criteria_sel.Text = "";
                    criteria_sel.Enabled = false;
                    button2.Enabled = false;

                    tabs.SelectedIndex = 2;
                    break;
            }
        }

        private void criteria_cln_Click(object sender, EventArgs e)
        {
            saved = false;
            setup_comp();
        }

        void setup_comp2(int Index)
        {
            if (Index == -1)
            {
                return;
            }



            int column_width = 220;

            if (saved2)
            {
                return;
            }


            var alternatives_list_dim = alternatives.Rows.Count;

            string[] alternatives_data = new string[alternatives_list_dim];
            string cell_value;
            try
            {
                for (int i = 0, j = 0; i < alternatives_list_dim; i++)
                {
                    cell_value = alternatives.Rows[i].Cells[0].Value.ToString();
                    if (cell_value != String.Empty)
                        alternatives_data[j++] = cell_value;
                }
            }
            catch (Exception)
            {

            }


            alternatives_comp.AllowUserToAddRows = false;
            alternatives_comp.AllowUserToDeleteRows = false;
            alternatives_comp.AllowUserToOrderColumns = false;


            alternatives_comp.Rows.Clear();
            alternatives_comp.Columns.Clear();

            alternatives_comp.RowHeadersWidth = column_width;

            for (int i = 0, j = 0; i < alternatives_list_dim; i++)
            {
                if (alternatives_data[i] != null && alternatives_data[i] != String.Empty)
                {
                    alternatives_comp.Columns.Add(alternatives_data[i].ToString().Trim() + "_name", alternatives_data[i].ToString());
                    alternatives_comp.Columns[j].SortMode = DataGridViewColumnSortMode.NotSortable;
                    alternatives_comp.Columns[j++].Width = column_width;

                }
                else
                {
                    continue;
                }
            }

            for (int i = 0, j = 0; i < alternatives_list_dim; i++)
            {
                if (alternatives_data[i] != null && alternatives_data[i] != String.Empty)
                {
                    alternatives_comp.Rows.Add();
                    alternatives_comp.Rows[j++].HeaderCell.Value = alternatives_data[i].ToString();
                }
                else
                {
                    continue;
                }
            }

            _alternatives_count = alternatives_comp.Rows.Count;
}

        private void tabs_sub_Selected(object sender, TabControlEventArgs e)
        {
            switch (tabs.SelectedIndex)
            {
                case 0:
                    setup_comp();
                    break;
                case 1:
                    button1_Click(sender, e);
                    setup_comp2((int)(criteria_sel.SelectedIndex));
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _criteria_list = collect_comp();
        }

        private void alternatives_cln_Click(object sender, EventArgs e)
        {
            saved2 = false;
            setup_comp2((int)(criteria_sel.SelectedIndex));
        }

        private void criteria_sel_SelectedIndexChanged(object sender, EventArgs e)
        {
            setup_comp2((int)(criteria_sel.SelectedIndex));
        }



        
        double[,] collect_comp2_for_index(int index)
        {
            double[,] alternatives_matrix = new double[_alternatives_count, _alternatives_count];

            for (int i = 0; i < _alternatives_count; i++)
                for (int j = 0; j < _alternatives_count; j++)
                {
                    alternatives_matrix[i, j] = Convert.ToDouble(alternatives_comp.Rows[i].Cells[j].Value);
                }

            clean_comp2();

            _alternatives_list.Add(alternatives_matrix);

            criteria_sel.Items.RemoveAt(index);

            if (criteria_sel.Items.Count == 0)
            {
                tabs.SelectedIndex = 2;
            }


            return alternatives_matrix;
        }


        void clean_comp2()
        {
            alternatives_comp.Rows.Clear();
            alternatives_comp.Columns.Clear();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (criteria_sel.SelectedIndex < 0)
            {

            }
            else
            {
                collect_comp2_for_index(criteria_sel.SelectedIndex);
            }
        }
    }
}

/*


*/