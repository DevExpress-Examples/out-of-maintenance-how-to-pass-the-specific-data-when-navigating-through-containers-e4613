using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParamNavigation {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void windowsUIView1_NavigatedTo(object sender, DevExpress.XtraBars.Docking2010.Views.WindowsUI.NavigationEventArgs e) {
            if (e.Target == page1) e.Parameter = page2;
        }

        private void windowsUIView1_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e) {
            if (e.Document == document1) e.Control = new ucGeneral();
            else e.Control = new ucDetails();
        }
    }
}
