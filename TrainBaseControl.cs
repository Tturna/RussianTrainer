using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussianTrainer
{
    public partial class TrainBaseControl : UserControl
    {
        public TrainBaseControl()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MainWindow.SetControlView(new MenuControl());
        }
    }
}
