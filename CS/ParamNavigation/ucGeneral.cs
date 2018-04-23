using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;

namespace ParamNavigation {
    public partial class ucGeneral : UserControl, ISupportNavigation {
        WindowsUIView generalView;
        Page detailsPage;
        public ucGeneral() {
            InitializeComponent();
            employeesTableAdapter.Fill(nwindDataSet.Employees);
        }

        public void OnNavigatedFrom(INavigationArgs args) {
            args.Parameter = gridView1.GetDataRow(gridView1.FocusedRowHandle);
        }

        public void OnNavigatedTo(INavigationArgs args) {
            generalView = args.View;
            detailsPage = args.Parameter as Page;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e) {
            generalView.Controller.Activate(detailsPage);
        }
    }
}
