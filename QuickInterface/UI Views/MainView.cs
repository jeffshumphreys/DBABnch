using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickInterface.UI_Views
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void MainView_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// Segregate all ticket tools on separate form.  These are Cherwell tickets.  
        /// 
        /// Initial Reason: To make it more of a work flow to generate tickets for ITT manager each month.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openTicketsView_Click(object sender, EventArgs e)
        {
            new TicketsView().Show(this);
        }

        private void openJobsView_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void openPermissionsDialogue_Click(object sender, EventArgs e)
        {
            new PermissionsDialogue().Show(this);
        }

        private void cancelMainMenuAndExitApplication_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
