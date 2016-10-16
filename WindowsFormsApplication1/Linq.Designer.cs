namespace WindowsFormsApplication1
{
    partial class Linq
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
            this.dgvHienthi = new System.Windows.Forms.DataGridView();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnWhere = new System.Windows.Forms.Button();
            this.txtWhere = new System.Windows.Forms.TextBox();
            this.btnSum = new System.Windows.Forms.Button();
            this.bntMax = new System.Windows.Forms.Button();
            this.bntMin = new System.Windows.Forms.Button();
            this.bntTb = new System.Windows.Forms.Button();
            this.btnTake = new System.Windows.Forms.Button();
            this.btnStartWith = new System.Windows.Forms.Button();
            this.btnEndWith = new System.Windows.Forms.Button();
            this.bntOrderByASC = new System.Windows.Forms.Button();
            this.bntOrderByDSC = new System.Windows.Forms.Button();
            this.btnGroupBy = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienthi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHienthi
            // 
            this.dgvHienthi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHienthi.Location = new System.Drawing.Point(1, 3);
            this.dgvHienthi.Name = "dgvHienthi";
            this.dgvHienthi.RowTemplate.Height = 28;
            this.dgvHienthi.Size = new System.Drawing.Size(455, 432);
            this.dgvHienthi.TabIndex = 0;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(496, 12);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(122, 36);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.Select_Click);
            // 
            // btnWhere
            // 
            this.btnWhere.Location = new System.Drawing.Point(752, 12);
            this.btnWhere.Name = "btnWhere";
            this.btnWhere.Size = new System.Drawing.Size(117, 36);
            this.btnWhere.TabIndex = 2;
            this.btnWhere.Text = "where";
            this.btnWhere.UseVisualStyleBackColor = true;
            this.btnWhere.Click += new System.EventHandler(this.btnWhere_Click);
            // 
            // txtWhere
            // 
            this.txtWhere.Location = new System.Drawing.Point(642, 12);
            this.txtWhere.Multiline = true;
            this.txtWhere.Name = "txtWhere";
            this.txtWhere.Size = new System.Drawing.Size(85, 36);
            this.txtWhere.TabIndex = 3;
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(496, 80);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(92, 32);
            this.btnSum.TabIndex = 4;
            this.btnSum.Text = "Sum";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.button1_Click);
            // 
            // bntMax
            // 
            this.bntMax.Location = new System.Drawing.Point(642, 80);
            this.bntMax.Name = "bntMax";
            this.bntMax.Size = new System.Drawing.Size(89, 33);
            this.bntMax.TabIndex = 5;
            this.bntMax.Text = "Max";
            this.bntMax.UseVisualStyleBackColor = true;
            this.bntMax.Click += new System.EventHandler(this.bntMax_Click);
            // 
            // bntMin
            // 
            this.bntMin.Location = new System.Drawing.Point(752, 80);
            this.bntMin.Name = "bntMin";
            this.bntMin.Size = new System.Drawing.Size(90, 32);
            this.bntMin.TabIndex = 6;
            this.bntMin.Text = "Min";
            this.bntMin.UseVisualStyleBackColor = true;
            this.bntMin.Click += new System.EventHandler(this.bntMin_Click);
            // 
            // bntTb
            // 
            this.bntTb.Location = new System.Drawing.Point(861, 80);
            this.bntTb.Name = "bntTb";
            this.bntTb.Size = new System.Drawing.Size(119, 32);
            this.bntTb.TabIndex = 7;
            this.bntTb.Text = "Trung bình";
            this.bntTb.UseVisualStyleBackColor = true;
            this.bntTb.Click += new System.EventHandler(this.bntTb_Click);
            // 
            // btnTake
            // 
            this.btnTake.Location = new System.Drawing.Point(496, 145);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(97, 31);
            this.btnTake.TabIndex = 8;
            this.btnTake.Text = "Take";
            this.btnTake.UseVisualStyleBackColor = true;
            this.btnTake.Click += new System.EventHandler(this.btnTake_Click);
            // 
            // btnStartWith
            // 
            this.btnStartWith.Location = new System.Drawing.Point(642, 145);
            this.btnStartWith.Name = "btnStartWith";
            this.btnStartWith.Size = new System.Drawing.Size(114, 31);
            this.btnStartWith.TabIndex = 9;
            this.btnStartWith.Text = "StartWith";
            this.btnStartWith.UseVisualStyleBackColor = true;
            this.btnStartWith.Click += new System.EventHandler(this.btnStartWith_Click);
            // 
            // btnEndWith
            // 
            this.btnEndWith.Location = new System.Drawing.Point(781, 145);
            this.btnEndWith.Name = "btnEndWith";
            this.btnEndWith.Size = new System.Drawing.Size(111, 31);
            this.btnEndWith.TabIndex = 10;
            this.btnEndWith.Text = "EndWith";
            this.btnEndWith.UseVisualStyleBackColor = true;
            this.btnEndWith.Click += new System.EventHandler(this.btnEndWith_Click);
            // 
            // bntOrderByASC
            // 
            this.bntOrderByASC.Location = new System.Drawing.Point(496, 203);
            this.bntOrderByASC.Name = "bntOrderByASC";
            this.bntOrderByASC.Size = new System.Drawing.Size(161, 32);
            this.bntOrderByASC.TabIndex = 11;
            this.bntOrderByASC.Text = " OrderBy ASC";
            this.bntOrderByASC.UseVisualStyleBackColor = true;
            this.bntOrderByASC.Click += new System.EventHandler(this.bntOrderByASC_Click);
            // 
            // bntOrderByDSC
            // 
            this.bntOrderByDSC.Location = new System.Drawing.Point(694, 203);
            this.bntOrderByDSC.Name = "bntOrderByDSC";
            this.bntOrderByDSC.Size = new System.Drawing.Size(119, 32);
            this.bntOrderByDSC.TabIndex = 12;
            this.bntOrderByDSC.Text = "OrderByDSC";
            this.bntOrderByDSC.UseVisualStyleBackColor = true;
            this.bntOrderByDSC.Click += new System.EventHandler(this.bntOrderByDSC_Click);
            // 
            // btnGroupBy
            // 
            this.btnGroupBy.Location = new System.Drawing.Point(861, 203);
            this.btnGroupBy.Name = "btnGroupBy";
            this.btnGroupBy.Size = new System.Drawing.Size(125, 32);
            this.btnGroupBy.TabIndex = 13;
            this.btnGroupBy.Text = "GroupBy";
            this.btnGroupBy.UseVisualStyleBackColor = true;
            this.btnGroupBy.Click += new System.EventHandler(this.btnGroupBy_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(508, 268);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(85, 32);
            this.btnCount.TabIndex = 14;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(642, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Join";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 486);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnGroupBy);
            this.Controls.Add(this.bntOrderByDSC);
            this.Controls.Add(this.bntOrderByASC);
            this.Controls.Add(this.btnEndWith);
            this.Controls.Add(this.btnStartWith);
            this.Controls.Add(this.btnTake);
            this.Controls.Add(this.bntTb);
            this.Controls.Add(this.bntMin);
            this.Controls.Add(this.bntMax);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.txtWhere);
            this.Controls.Add(this.btnWhere);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.dgvHienthi);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienthi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHienthi;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnWhere;
        private System.Windows.Forms.TextBox txtWhere;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button bntMax;
        private System.Windows.Forms.Button bntMin;
        private System.Windows.Forms.Button bntTb;
        private System.Windows.Forms.Button btnTake;
        private System.Windows.Forms.Button btnStartWith;
        private System.Windows.Forms.Button btnEndWith;
        private System.Windows.Forms.Button bntOrderByASC;
        private System.Windows.Forms.Button bntOrderByDSC;
        private System.Windows.Forms.Button btnGroupBy;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button button1;
    }
}

