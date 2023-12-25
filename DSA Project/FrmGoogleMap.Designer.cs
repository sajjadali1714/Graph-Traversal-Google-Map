namespace DSA_Project
{
    partial class FrmGoogleMap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGoogleMap));
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnZoomIn = new System.Windows.Forms.ToolStripButton();
            this.BtnZoomOut = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.BtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnverify = new System.Windows.Forms.ToolStripButton();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.HelpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.GoogleMap = new GMap.NET.WindowsForms.GMapControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGetPolygon = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.btnAdjacencyList = new System.Windows.Forms.Button();
            this.btnAdjacencyMatrix = new System.Windows.Forms.Button();
            this.ToolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnZoomIn,
            this.BtnZoomOut,
            this.btnEdit,
            this.btnSave,
            this.BtnRefresh,
            this.btnDelete,
            this.btnverify,
            this.btnPrint,
            this.toolStripSeparator1,
            this.HelpToolStripButton});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(847, 25);
            this.ToolStrip1.TabIndex = 34;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // btnNew
            // 
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(51, 22);
            this.btnNew.Text = "&New";
            this.btnNew.ToolTipText = "Clear All Controls";
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomIn.Image")));
            this.btnZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(72, 22);
            this.btnZoomIn.Text = "Zoom In";
            // 
            // BtnZoomOut
            // 
            this.BtnZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("BtnZoomOut.Image")));
            this.BtnZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnZoomOut.Name = "BtnZoomOut";
            this.BtnZoomOut.Size = new System.Drawing.Size(82, 22);
            this.BtnZoomOut.Text = "Zoom Out";
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(47, 22);
            this.btnEdit.Text = "&Edit";
            this.btnEdit.ToolTipText = "Change Record";
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(51, 22);
            this.btnSave.Text = "&Save";
            this.btnSave.ToolTipText = "Save Or Update Record";
            this.btnSave.Visible = false;
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(50, 22);
            this.BtnRefresh.Text = "&Refresh";
            this.BtnRefresh.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeftAutoMirrorImage = true;
            this.btnDelete.Size = new System.Drawing.Size(60, 22);
            this.btnDelete.Text = "&Delete";
            this.btnDelete.ToolTipText = "Delete Record";
            this.btnDelete.Visible = false;
            // 
            // btnverify
            // 
            this.btnverify.Image = ((System.Drawing.Image)(resources.GetObject("btnverify.Image")));
            this.btnverify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnverify.Name = "btnverify";
            this.btnverify.Size = new System.Drawing.Size(56, 22);
            this.btnverify.Text = "&Verify";
            this.btnverify.Visible = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(70, 22);
            this.btnPrint.Text = "&Re-Print";
            this.btnPrint.ToolTipText = "Trial Balance Report On Main Level";
            this.btnPrint.Visible = false;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // HelpToolStripButton
            // 
            this.HelpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HelpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("HelpToolStripButton.Image")));
            this.HelpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HelpToolStripButton.Name = "HelpToolStripButton";
            this.HelpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.HelpToolStripButton.Text = "He&lp";
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(847, 324);
            this.tabControl1.TabIndex = 35;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.GoogleMap);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(839, 298);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Map";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // GoogleMap
            // 
            this.GoogleMap.Bearing = 0F;
            this.GoogleMap.CanDragMap = true;
            this.GoogleMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GoogleMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.GoogleMap.GrayScaleMode = false;
            this.GoogleMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.GoogleMap.LevelsKeepInMemory = 5;
            this.GoogleMap.Location = new System.Drawing.Point(3, 64);
            this.GoogleMap.MarkersEnabled = true;
            this.GoogleMap.MaxZoom = 2;
            this.GoogleMap.MinZoom = 2;
            this.GoogleMap.MouseWheelZoomEnabled = true;
            this.GoogleMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.GoogleMap.Name = "GoogleMap";
            this.GoogleMap.NegativeMode = false;
            this.GoogleMap.PolygonsEnabled = true;
            this.GoogleMap.RetryLoadTile = 0;
            this.GoogleMap.RoutesEnabled = true;
            this.GoogleMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.GoogleMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.GoogleMap.ShowTileGridLines = false;
            this.GoogleMap.Size = new System.Drawing.Size(833, 231);
            this.GoogleMap.TabIndex = 1;
            this.GoogleMap.Zoom = 0D;
            this.GoogleMap.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.GoogleMap_MouseDoubleClick);
            this.GoogleMap.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GoogleMap_MouseDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdjacencyMatrix);
            this.panel1.Controls.Add(this.btnAdjacencyList);
            this.panel1.Controls.Add(this.btnGetPolygon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 61);
            this.panel1.TabIndex = 0;
            // 
            // btnGetPolygon
            // 
            this.btnGetPolygon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetPolygon.Location = new System.Drawing.Point(5, 17);
            this.btnGetPolygon.Name = "btnGetPolygon";
            this.btnGetPolygon.Size = new System.Drawing.Size(106, 28);
            this.btnGetPolygon.TabIndex = 1;
            this.btnGetPolygon.Text = "Get Polygon";
            this.btnGetPolygon.UseVisualStyleBackColor = true;
            this.btnGetPolygon.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtOutput);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(839, 298);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Output";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtOutput
            // 
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Location = new System.Drawing.Point(3, 3);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(833, 292);
            this.txtOutput.TabIndex = 0;
            // 
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = null;
            // 
            // btnAdjacencyList
            // 
            this.btnAdjacencyList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdjacencyList.Location = new System.Drawing.Point(117, 17);
            this.btnAdjacencyList.Name = "btnAdjacencyList";
            this.btnAdjacencyList.Size = new System.Drawing.Size(132, 28);
            this.btnAdjacencyList.TabIndex = 1;
            this.btnAdjacencyList.Text = "Adjacency List";
            this.btnAdjacencyList.UseVisualStyleBackColor = true;
            this.btnAdjacencyList.Click += new System.EventHandler(this.btnAdjacencyList_Click);
            // 
            // btnAdjacencyMatrix
            // 
            this.btnAdjacencyMatrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdjacencyMatrix.Location = new System.Drawing.Point(255, 17);
            this.btnAdjacencyMatrix.Name = "btnAdjacencyMatrix";
            this.btnAdjacencyMatrix.Size = new System.Drawing.Size(132, 28);
            this.btnAdjacencyMatrix.TabIndex = 1;
            this.btnAdjacencyMatrix.Text = "Adjacency Matrix";
            this.btnAdjacencyMatrix.UseVisualStyleBackColor = true;
            this.btnAdjacencyMatrix.Click += new System.EventHandler(this.btnAdjacencyMatrix_Click);
            // 
            // FrmGoogleMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(847, 349);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ToolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGoogleMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGoogleMap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton btnNew;
        internal System.Windows.Forms.ToolStripButton btnEdit;
        internal System.Windows.Forms.ToolStripButton btnSave;
        internal System.Windows.Forms.ToolStripButton BtnRefresh;
        internal System.Windows.Forms.ToolStripButton btnDelete;
        internal System.Windows.Forms.ToolStripButton btnverify;
        internal System.Windows.Forms.ToolStripButton btnPrint;
        internal System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton HelpToolStripButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private GMap.NET.WindowsForms.GMapControl GoogleMap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGetPolygon;
        private System.Windows.Forms.ToolStripButton btnZoomIn;
        private System.Windows.Forms.ToolStripButton BtnZoomOut;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnAdjacencyMatrix;
        private System.Windows.Forms.Button btnAdjacencyList;
    }
}