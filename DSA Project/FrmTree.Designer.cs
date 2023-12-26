
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
            this.picTreeDesign = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Tree = new System.Windows.Forms.TabPage();
            this.OutputBox = new System.Windows.Forms.TabPage();
            this.selectTraversing = new System.Windows.Forms.ComboBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TraverName = new System.Windows.Forms.TextBox();
            this.txtSearchNode = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picTreeDesign)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Tree.SuspendLayout();
            this.OutputBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // picTreeDesign
            // 
            this.picTreeDesign.Location = new System.Drawing.Point(3, 6);
            this.picTreeDesign.Name = "picTreeDesign";
            this.picTreeDesign.Size = new System.Drawing.Size(800, 420);
            this.picTreeDesign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picTreeDesign.TabIndex = 0;
            this.picTreeDesign.TabStop = false;
            this.picTreeDesign.Paint += new System.Windows.Forms.PaintEventHandler(this.picTreeDesign_Paint);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(1000, 1000);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(773, 17);
            this.hScrollBar1.TabIndex = 5;
            // 
            // resultBox
            // 
            this.resultBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBox.Location = new System.Drawing.Point(3, 3);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(333, 22);
            this.resultBox.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.Tree);
            this.tabControl1.Controls.Add(this.OutputBox);
            this.tabControl1.Location = new System.Drawing.Point(-3, 93);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2000, 2000);
            this.tabControl1.TabIndex = 8;
            // 
            // Tree
            // 
            this.Tree.Controls.Add(this.picTreeDesign);
            this.Tree.Location = new System.Drawing.Point(4, 4);
            this.Tree.Name = "Tree";
            this.Tree.Padding = new System.Windows.Forms.Padding(3);
            this.Tree.Size = new System.Drawing.Size(1992, 1974);
            this.Tree.TabIndex = 0;
            this.Tree.Text = "Tree";
            this.Tree.UseVisualStyleBackColor = true;
            // 
            // OutputBox
            // 
            this.OutputBox.Controls.Add(this.resultBox);
            this.OutputBox.Location = new System.Drawing.Point(4, 4);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Padding = new System.Windows.Forms.Padding(3);
            this.OutputBox.Size = new System.Drawing.Size(1992, 1974);
            this.OutputBox.TabIndex = 1;
            this.OutputBox.Text = "Output";
            this.OutputBox.UseVisualStyleBackColor = true;
            // 
            // selectTraversing
            // 
            this.selectTraversing.FormattingEnabled = true;
            this.selectTraversing.Items.AddRange(new object[] {
            "",
            "Pre-Order Traversing",
            "Post-Order Traversing",
            "In-Order Traversing"});
            this.selectTraversing.Location = new System.Drawing.Point(12, 12);
            this.selectTraversing.Name = "selectTraversing";
            this.selectTraversing.Size = new System.Drawing.Size(121, 21);
            this.selectTraversing.TabIndex = 1;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(33, 39);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tree Traversing";
            // 
            // TraverName
            // 
            this.TraverName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TraverName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TraverName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TraverName.Location = new System.Drawing.Point(123, 72);
            this.TraverName.Name = "TraverName";
            this.TraverName.Size = new System.Drawing.Size(165, 19);
            this.TraverName.TabIndex = 9;
            // 
            // txtSearchNode
            // 
            this.txtSearchNode.Location = new System.Drawing.Point(200, 12);
            this.txtSearchNode.Name = "txtSearchNode";
            this.txtSearchNode.Size = new System.Drawing.Size(100, 20);
            this.txtSearchNode.TabIndex = 10;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(213, 39);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 11;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.txtSearchNode);
            this.Controls.Add(this.TraverName);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.selectTraversing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTree";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTree";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.picTreeDesign)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Tree.ResumeLayout(false);
            this.OutputBox.ResumeLayout(false);
            this.OutputBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picTreeDesign;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Tree;
        private System.Windows.Forms.TabPage OutputBox;
        private System.Windows.Forms.ComboBox selectTraversing;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TraverName;
        private System.Windows.Forms.TextBox txtSearchNode;
        private System.Windows.Forms.Button SearchBtn;
    }
}