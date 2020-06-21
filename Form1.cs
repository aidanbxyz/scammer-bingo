using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scammerBingo
{
    public partial class scammerBingoMain : Form
    {
        Form2 form2 = new Form2();
        public scammerBingoMain()
        {
            InitializeComponent();
        }

        private void techSupportFormClick_Click(object sender, EventArgs e)
        {
            // Hide things
            this.wsTodayText.Hide();
            this.techSupportFormClick.Hide();
            this.refundFormClick.Hide();
            this.mcs.Hide();

            // Show things
            this.startTechSupport.Show();
            this.backTechSupport.Show();
        }

        private void refundFormClick_Click(object sender, EventArgs e)
        {
            // refundFormClick_Click
        }

        private void startTechSupport_Click(object sender, EventArgs e)
        {
            // Show things
            form2.Show();

            // Hide things
            this.Hide();
        }

        private void backTechSupport_Click(object sender, EventArgs e)
        {
            // Hide things
            this.wsTodayText.Show();
            this.techSupportFormClick.Show();
            this.refundFormClick.Show();
            this.mcs.Show();

            // Show things
            this.startTechSupport.Hide();
            this.backTechSupport.Hide();
        }
    }
}
