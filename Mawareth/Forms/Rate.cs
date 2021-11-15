using Mawareth.Classes;
using Mawareth.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mawareth.Forms
{
    public partial class Rate: Form
    {
        public Rate()
        {
            InitializeComponent();
        }

        private void RateStar(byte stars)
        {
            using (MawarethContext context = new MawarethContext())
            {
                var rate = new Data.Rate
                {
                    Stars = stars
                };
                context.Rates.Add(rate);
                context.SaveChanges();
            }
        }

        private void Rate_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main main = new Main();
            main.Show();
        }

        private void lblNotNow_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            Hide();
            main.ShowDialog();
        }

        private void one_Click(object sender, EventArgs e)
        {
            RateStar(1);
            Hide();
            Main main = new Main();
            main.ShowDialog();
        }

        private void two1_Click(object sender, EventArgs e)
        {
            RateStar(2);
            Hide();
            Main main = new Main();
            main.ShowDialog();
        }

        private void two2_Click(object sender, EventArgs e)
        {
            RateStar(2);
            Hide();
            Main main = new Main();
            main.ShowDialog();
        }

        private void three1_Click(object sender, EventArgs e)
        {
            RateStar(3);
            Hide();
            Main main = new Main();
            main.ShowDialog();
        }

        private void three2_Click(object sender, EventArgs e)
        {
            RateStar(3);
            Hide();
            Main main = new Main();
            main.ShowDialog();
        }

        private void three3_Click(object sender, EventArgs e)
        {
            RateStar(3);
            Hide();
            Main main = new Main();
            main.ShowDialog();
        }

        private void four1_Click(object sender, EventArgs e)
        {
            RateStar(4);
            Hide();
            Main main = new Main();
            main.ShowDialog();
        }

        private void four2_Click(object sender, EventArgs e)
        {
            RateStar(4);
            Hide();
            Main main = new Main();
            main.ShowDialog();
        }

        private void four3_Click(object sender, EventArgs e)
        {
            RateStar(4);
            Hide();
            Main main = new Main();
            main.ShowDialog();
        }

        private void four4_Click(object sender, EventArgs e)
        {
            RateStar(4);
            Hide();
            Main main = new Main();
            main.ShowDialog();
        }

        private void five1_Click(object sender, EventArgs e)
        {
            RateStar(5);
            Hide();
            Main main = new Main();
            main.ShowDialog();
        }

        private void five2_Click(object sender, EventArgs e)
        {
            RateStar(5);
            Hide();
            Main main = new Main();
            main.ShowDialog();
        }

        private void five3_Click(object sender, EventArgs e)
        {
            RateStar(5);
            Hide();
            Main main = new Main();
            main.ShowDialog();
        }

        private void five4_Click(object sender, EventArgs e)
        {
            RateStar(5);
            Hide();
            Main main = new Main();
            main.ShowDialog();
        }

        private void five5_Click(object sender, EventArgs e)
        {
            RateStar(5);
            Hide();
            Main main = new Main();
            main.ShowDialog();
        }
    }
}
