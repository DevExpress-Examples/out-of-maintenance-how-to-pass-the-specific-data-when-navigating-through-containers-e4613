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
    public partial class ucDetails : UserControl, ISupportNavigation {
        string detailsID;
        public ucDetails() {
            InitializeComponent();
            employeesTableAdapter.Fill(nwindDataSet.Employees);
        }

        public void OnNavigatedFrom(INavigationArgs args) {
            
        }

        public void OnNavigatedTo(INavigationArgs args) {
            detailsID = (args.Parameter as ParamNavigation.nwindDataSet.EmployeesRow).EmployeeID.ToString();
            layoutView1.ActiveFilterString = "[EmployeeID] = " + detailsID;
        }
    }
}
