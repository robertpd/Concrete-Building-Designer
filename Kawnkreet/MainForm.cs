using System;
using System.Windows.Forms;

namespace Kawnkreet
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void btnDesign_Click(object sender, EventArgs e)
        {
            InputData data = new InputData();
            GetInput(data);
            Building newBuilding = new Building(data);
            newBuilding.DesignSlabs();
        }
    }
}
