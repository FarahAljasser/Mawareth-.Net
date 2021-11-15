using Mawareth.Forms;
using System;
using System.Windows.Forms;

namespace Mawareth
{
    public partial class Operations : Form
    {
        string husband_q_info = "•	الزوج يرث الربع عند وجود الفرع الوارث لزوجته.";
        string husband_h_info = "•	الزوج يرث النصف بشرط عدم وجود الفرع الوارث لزوجته.";
        string wife_q_info = "•	الزوجة ترث الربع عند عدم الفرع الوارث.";
        string wife_8_info = "•	الزوجة ترث الثمن عند وجود الفرع الوارث لزوجها. لقوله تعالى (فَإِنْ كَانَ لَكُمْ وَلَدٌ فَلَهُنَّ الثُّمُنُ مِمَّا تَرَكْتُمْ).";
        string daughter_h_info = "•	البنت الواحدة، ترث النصف لقوله تعالى (وَإِنْ كَانَتْ وَاحِدَةً فَلَهَا النِّصْفُ).";
        string daughter_2t_info = "•	بنتان فأكثر. (فَإِنْ كُنَّ نِسَاءً فَوْقَ اثْنَتَيْنِ فَلَهُنَّ ثُلُثَا مَا تَرَكَ).";
        string hdaughter_h_info = "•	الأخت الشقيقة ترث النصف لقوله تعالى (إِنِ امْرُؤٌ هَلَكَ لَيْسَ لَهُ وَلَدٌ وَلَهُ أُخْتٌ فَلَهَا نِصْفُ مَا تَرَكَ).";
        string hdaughter_2t_info = "•	الثلثان لشقيقتان فأكثر. (إِنِ امْرُؤٌ هَلَكَ لَيْسَ لَهُ وَلَدٌ وَلَهُ أُخْتٌ فَلَهَا نِصْفُ مَا تَرَكَ ۚ وَهُوَ يَرِثُهَا إِنْ لَمْ يَكُنْ لَهَا وَلَدٌ ۚ فَإِنْ كَانَتَا اثْنَتَيْنِ فَلَهُمَا الثُّلُثَانِ مِمَّا تَرَكَ).";
        string mother_t_info = "•	الأم ترث الثلث عند عدم الفرع الوارث. لقوله تعالى (فَإِنْ لَمْ يَكُنْ لَهُ وَلَدٌ وَوَرِثَهُ أَبَوَاهُ فَلِأُمِّهِ الثُّلُثُ).";
        string mother_s_info = "•	الأم ترث السدس عند وجود الفرع الوارث.";
        string motherch_t_info = "•	اثنان أو أكثر من الإخوة والاخوات لأم، لقوله تعالى (فَإِنْ كَانُوا أَكْثَرَ مِنْ ذَٰلِكَ فَهُمْ شُرَكَاءُ فِي الثُّلُثِ).";
        string motherch_6_info = "•	السدس بشرط عدم الفرع الوارث (ان يكون منفردا).";
        string father_6_info = "•	الأب عند وجود الفرع الوارث.";
        string gfather_6_info = "•	يرث أبو الأب السدس عند وجود الفرع الوارث.";
        string gmother_6_info = "•	الجدة عند عدم الأم. والجدة التي ترث بالإجماع هي: الجدة أم الأم وأمهاتها المدليات بإناث خلّص، والجدة أم الأب وأمهاتها المدليات بإناث خلّص.";
        string gdaughter_h_info = "•	بنت الابن ترث النصف.";
        string gdaughter_6_info = "•	بنت الابن السدس مع البنت الواحدة إذا كانت صاحبة فرض.";
        string fathersis_h_info = "•	الأخت لأب ترث النصف بشرط عدم الفرع الوارث.";
        string fathersis_2t_info = "•	أختان لأب فأكثر. الثلثان بشرط عدم الفرع الوارث.";
        string none_info = "لاترث";
        
        public Operations()
        {
            InitializeComponent();
        }

        private void wife_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("هل لديه فروع؟", "Add",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
                sum_amount(true, false, "زوجة","الثمن",8, wife_8_info);
            else
                sum_amount(false, false, "زوجة", "الربع",4, wife_q_info);
        }

        int last;
        private void sum_amount(bool substation, bool edite, string name, string balancename,double num, string info)
        {
            last = dataGridView1.Rows.Count;
            if (substation)
            {
                double own = double.Parse(txtValue.Text) / num;
                own = double.Parse(String.Format("{0:0.00}", own));
                dataGridView1.Rows.Add(name, substation, 2, balancename, own, own,info);
                dataGridView1.Rows[last].Selected = true;
                if (edite==false)
                {
                    dataGridView1.SelectedRows[0].Cells[2].ReadOnly = true;
                    dataGridView1.SelectedRows[0].Cells[2].Value = 1;
                }
                    edite = true;
            }
            else
            {
                double own = double.Parse(txtValue.Text) / num;
                own = double.Parse(String.Format("{0:0.00}", own));
                dataGridView1.Rows.Add(name, substation, 1, balancename, own, own,info);
                dataGridView1.Rows[last].Selected = true;
                dataGridView1.SelectedRows[0].Cells[2].ReadOnly = true;
            }
        }

        double single;
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int newInt;
            if (!int.TryParse(dataGridView1.CurrentCell.Value.ToString(), out newInt))
            {
                dataGridView1.CurrentCell.Value = 1; 
                single = double.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString()) / double.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                single = double.Parse(String.Format("{0:0.00}", single));
                dataGridView1.CurrentRow.Cells[5].Value = single;
            }
            else
            {
                single = double.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString()) / double.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                single = double.Parse(String.Format("{0:0.00}", single));
                dataGridView1.CurrentRow.Cells[5].Value = single;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("هل لديه فروع؟", "Add", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                double own = double.Parse(txtValue.Text) / 3;
                own = double.Parse(String.Format("{0:0.00}", own));
                dataGridView1.Rows.Add("بنت", true, 2, "الثلثان", own * 2, own * 2,daughter_2t_info);
                dataGridView1.Rows[last].Selected = true;
            }
            else
            {
                last = dataGridView1.Rows.Count;
                double own = double.Parse(txtValue.Text) / 2;
                own = double.Parse(String.Format("{0:0.00}", own));
                dataGridView1.Rows.Add("بنت", true, 1, "النصف", own, own,daughter_h_info);
                dataGridView1.Rows[last].Selected = true;
                dataGridView1.SelectedRows[0].Cells[2].ReadOnly = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("هل لديه فروع؟", "Add", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                sum_amount(true, false, "الأم", "السدس", 6,motherch_6_info);
            else
                sum_amount(false, false, "الأم", "الثلث", 3,motherch_t_info);
        }

        private void husband_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("هل لديه فروع؟", "Add", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                sum_amount(true, false, "الزوج", "الربع", 4,husband_q_info);
            else
                sum_amount(false, false, "الزوج", "النصف", 2,husband_h_info);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sum_amount(false, false, "الأب", "السدس", 6,father_6_info);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("هل الأم على قيد الحياة؟", "Add", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                sum_amount(false, false, "الجدة", "لاترث", 0,none_info);
            else
                sum_amount(false, false, "الجدة", "السدس", 6,gmother_6_info);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("هل الأم على قيد الحياة؟", "Add", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                sum_amount(false, false, "الجد ابو الأب", "لاترث", 0,none_info);
            else
                sum_amount(false, false, "الجد ابو الأب", "السدس", 6,gfather_6_info);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("هل لديه فروع؟", "Add", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                sum_amount(false, false, "الإخوة والأخوات لأم", "الثلث", 3,motherch_t_info);
            else
                sum_amount(false, false, "الإخوة والأخوات لأم", "السدس", 6,motherch_6_info);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("هل لدى المتوفى بنات؟", "Add", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result1 == DialogResult.Yes)
            {
                sum_amount(false, false, "الأخت لأب", "النصف", 2,fathersis_h_info);
            }
            else
            {
                DialogResult result = MessageBox.Show("هل لديه فروع؟", "Add", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    double own = double.Parse(txtValue.Text) / 3;
                    own = double.Parse(String.Format("{0:0.00}", own));
                    dataGridView1.Rows.Add("الأخت لأب", true, 2, "الثلثان", own * 2, own * 2,fathersis_2t_info);
                    dataGridView1.Rows[last].Selected = true;
                }
                else
                {
                    sum_amount(false, false, "الأخت لأب", "النصف", 2,fathersis_h_info);
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("هل لدى المتوفى بنات؟", "Add", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result1 == DialogResult.Yes)
            {
                sum_amount(false, false, "بنت الأبن", "لا ترث", 0,none_info);
            }
            else
            {
                DialogResult result = MessageBox.Show("هل لديه فروع؟", "Add", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    double own = double.Parse(txtValue.Text) / 3;
                    own = double.Parse(String.Format("{0:0.00}", own));
                    dataGridView1.Rows.Add("بنت الأبن", true, 2, "الثلثان", own * 2, own * 2,gdaughter_6_info);
                    dataGridView1.Rows[last].Selected = true;
                }
                else
                {
                    sum_amount(false, false, "بنت الأبن", "النصف", 2,gdaughter_h_info);
                }
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("قم بتحديد صف اولاَ");
            }
        }

        private void Operations_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main main = new Main();
            main.Show();
        }

        private void Operations_Load(object sender, EventArgs e)
        {
            txtIssue.Text = IssueAdd.IssueName;
            txtDead.Text = AddDead.DeadName;
            txtValue.Text = AddDead.Value.ToString();
        }
    }
}
