
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
            this.selectTraversing = new System.Windows.Forms.ComboBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.labResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picTreeDesign)).BeginInit();
            this.SuspendLayout();
            // 
            // picTreeDesign
            // 
            this.picTreeDesign.Location = new System.Drawing.Point(3, 95);
            this.picTreeDesign.Name = "picTreeDesign";
            this.picTreeDesign.Size = new System.Drawing.Size(800, 400);
            this.picTreeDesign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picTreeDesign.TabIndex = 0;
            this.picTreeDesign.TabStop = false;
            this.picTreeDesign.Paint += new System.Windows.Forms.PaintEventHandler(this.picTreeDesign_Paint);
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
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tree Traversing";
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
            this.resultBox.Location = new System.Drawing.Point(265, 14);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(310, 20);
            this.resultBox.TabIndex = 6;
            // 
            // labResult
            // 
            this.labResult.AutoSize = true;
            this.labResult.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labResult.Location = new System.Drawing.Point(604, 17);
            this.labResult.Name = "labResult";
            this.labResult.Size = new System.Drawing.Size(43, 15);
            this.labResult.TabIndex = 7;
            this.labResult.Text = "Result";
            // 
            // FrmTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labResult);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.selectTraversing);
            this.Controls.Add(this.picTreeDesign);
            this.Name = "FrmTree";
            this.Text = "FrmTree";
            ((System.ComponentModel.ISupportInitialize)(this.picTreeDesign)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picTreeDesign;
        private System.Windows.Forms.ComboBox selectTraversing;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Label labResult;
    }
}