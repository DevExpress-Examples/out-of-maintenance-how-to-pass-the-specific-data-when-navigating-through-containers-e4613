namespace ParamNavigation {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.windowsUIView1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView(this.components);
            this.page1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Page(this.components);
            this.document1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.page2 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Page(this.components);
            this.document2 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.GeneralTile = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.ucDetailsTile = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsUIView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.page1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.page2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralTile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucDetailsTile)).BeginInit();
            this.SuspendLayout();
            // 
            // documentManager1
            // 
            this.documentManager1.ContainerControl = this;
            this.documentManager1.View = this.windowsUIView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.windowsUIView1});
            // 
            // windowsUIView1
            // 
            this.windowsUIView1.ContentContainers.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.IContentContainer[] {
            this.page1,
            this.page2});
            this.windowsUIView1.Documents.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseDocument[] {
            this.document1,
            this.document2});
            this.windowsUIView1.Tiles.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile[] {
            this.GeneralTile,
            this.ucDetailsTile});
            this.windowsUIView1.NavigatedTo += new DevExpress.XtraBars.Docking2010.Views.WindowsUI.NavigationEventHandler(this.windowsUIView1_NavigatedTo);
            this.windowsUIView1.QueryControl += new DevExpress.XtraBars.Docking2010.Views.QueryControlEventHandler(this.windowsUIView1_QueryControl);
            // 
            // page1
            // 
            this.page1.Caption = "Employees";
            this.page1.Document = this.document1;
            this.page1.Name = "page1";
            // 
            // document1
            // 
            this.document1.Caption = "General";
            this.document1.ControlName = "General";
            this.document1.ControlTypeName = "ParamNavigation.General";
            // 
            // page2
            // 
            this.page2.Caption = "Details";
            this.page2.Document = this.document2;
            this.page2.Name = "page2";
            this.page2.Parent = this.page1;
            // 
            // document2
            // 
            this.document2.Caption = "ucDetails";
            this.document2.ControlName = "ucDetails";
            this.document2.ControlTypeName = "ParamNavigation.ucDetails";
            // 
            // GeneralTile
            // 
            this.GeneralTile.Document = this.document1;
            this.GeneralTile.Group = "";
            this.GeneralTile.Name = "GeneralTile";
            // 
            // ucDetailsTile
            // 
            this.ucDetailsTile.Document = this.document2;
            this.ucDetailsTile.Group = "";
            this.ucDetailsTile.Name = "ucDetailsTile";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 557);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsUIView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.page1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.page2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralTile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucDetailsTile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView windowsUIView1;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Page page1;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document document1;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Page page2;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document document2;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile GeneralTile;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile ucDetailsTile;
    }
}

