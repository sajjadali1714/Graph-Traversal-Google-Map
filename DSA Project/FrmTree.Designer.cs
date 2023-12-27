namespace DSA_Project
{
    partial class FrmTree
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.txtSearchNode = new System.Windows.Forms.TextBox();
            this.TraverName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.selectTraversing = new System.Windows.Forms.ComboBox();
            this.picTreeDesign = new System.Windows.Forms.PictureBox();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTreeDesign)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(816, 457);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.picTreeDesign);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(808, 431);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tree";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.resultBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(808, 431);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Output";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SearchBtn);
            this.panel1.Controls.Add(this.txtSearchNode);
            this.panel1.Controls.Add(this.TraverName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Controls.Add(this.selectTraversing);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 145);
            this.panel1.TabIndex = 0;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SearchBtn.Location = new System.Drawing.Point(489, 95);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(121, 30);
            this.SearchBtn.TabIndex = 17;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSearchNode
            // 
            this.txtSearchNode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSearchNode.Location = new System.Drawing.Point(362, 99);
            this.txtSearchNode.Name = "txtSearchNode";
            this.txtSearchNode.Size = new System.Drawing.Size(121, 26);
            this.txtSearchNode.TabIndex = 16;
            // 
            // TraverName
            // 
            this.TraverName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TraverName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TraverName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TraverName.Location = new System.Drawing.Point(610, 23);
            this.TraverName.Name = "TraverName";
            this.TraverName.Size = new System.Drawing.Size(165, 19);
            this.TraverName.TabIndex = 15;
            this.TraverName.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 37);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tree Traversing";
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnFind.Location = new System.Drawing.Point(192, 95);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(164, 30);
            this.btnFind.TabIndex = 13;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // selectTraversing
            // 
            this.selectTraversing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.selectTraversing.FormattingEnabled = true;
            this.selectTraversing.Items.AddRange(new object[] {
            "",
            "Pre-Order Traversing",
            "Post-Order Traversing",
            "In-Order Traversing"});
            this.selectTraversing.Location = new System.Drawing.Point(22, 95);
            this.selectTraversing.Name = "selectTraversing";
            this.selectTraversing.Size = new System.Drawing.Size(164, 28);
            this.selectTraversing.TabIndex = 12;
            // 
            // picTreeDesign
            // 
            this.picTreeDesign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picTreeDesign.Location = new System.Drawing.Point(3, 148);
            this.picTreeDesign.Name = "picTreeDesign";
            this.picTreeDesign.Size = new System.Drawing.Size(802, 280);
            this.picTreeDesign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picTreeDesign.TabIndex = 2;
            this.picTreeDesign.TabStop = false;
            this.picTreeDesign.Paint += new System.Windows.Forms.PaintEventHandler(this.picTreeDesign_Paint);
            // 
            // resultBox
            // 
            this.resultBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.resultBox.Location = new System.Drawing.Point(3, 3);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(802, 425);
            this.resultBox.TabIndex = 1;
            // 
            // FrmTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 457);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTree";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTree";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTreeDesign)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox txtSearchNode;
        private System.Windows.Forms.TextBox TraverName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ComboBox selectTraversing;
        private System.Windows.Forms.PictureBox picTreeDesign;
        private System.Windows.Forms.TextBox resultBox;
    }
}