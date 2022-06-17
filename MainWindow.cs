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
    public partial class MainWindow : Form
    {
        static Panel mainPanel;

        public MainWindow()
        {
            InitializeComponent();

            mainPanel = panel1;

            // Populate the main panel with the menu user control
            SetControlView(new MenuControl());
        }

        public static void SetControlView(UserControl controlView)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(controlView);
            controlView.Dock = DockStyle.Fill;
        }
    }
}
