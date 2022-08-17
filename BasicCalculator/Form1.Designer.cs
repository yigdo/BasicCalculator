namespace BasicCalculator
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txb_number_1 = new System.Windows.Forms.TextBox();
            this.lst_totals = new System.Windows.Forms.ListBox();
            this.txb_number_2 = new System.Windows.Forms.TextBox();
            this.lbl_inform_num_1 = new System.Windows.Forms.Label();
            this.lbl_inform_num_2 = new System.Windows.Forms.Label();
            this.btn_calc = new System.Windows.Forms.Button();
            this.chx_operation_add = new System.Windows.Forms.RadioButton();
            this.chx_operation_sub = new System.Windows.Forms.RadioButton();
            this.chx_operation_mult = new System.Windows.Forms.RadioButton();
            this.chx_operation_div = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txb_number_1
            // 
            this.txb_number_1.Location = new System.Drawing.Point(146, 12);
            this.txb_number_1.Name = "txb_number_1";
            this.txb_number_1.Size = new System.Drawing.Size(140, 20);
            this.txb_number_1.TabIndex = 0;
            // 
            // lst_totals
            // 
            this.lst_totals.FormattingEnabled = true;
            this.lst_totals.Location = new System.Drawing.Point(0, 201);
            this.lst_totals.Name = "lst_totals";
            this.lst_totals.Size = new System.Drawing.Size(334, 251);
            this.lst_totals.TabIndex = 2;
            // 
            // txb_number_2
            // 
            this.txb_number_2.Location = new System.Drawing.Point(146, 38);
            this.txb_number_2.Name = "txb_number_2";
            this.txb_number_2.Size = new System.Drawing.Size(140, 20);
            this.txb_number_2.TabIndex = 6;
            // 
            // lbl_inform_num_1
            // 
            this.lbl_inform_num_1.AutoSize = true;
            this.lbl_inform_num_1.Location = new System.Drawing.Point(52, 15);
            this.lbl_inform_num_1.Name = "lbl_inform_num_1";
            this.lbl_inform_num_1.Size = new System.Drawing.Size(56, 13);
            this.lbl_inform_num_1.TabIndex = 7;
            this.lbl_inform_num_1.Text = "1. Number";
            // 
            // lbl_inform_num_2
            // 
            this.lbl_inform_num_2.AutoSize = true;
            this.lbl_inform_num_2.Location = new System.Drawing.Point(52, 41);
            this.lbl_inform_num_2.Name = "lbl_inform_num_2";
            this.lbl_inform_num_2.Size = new System.Drawing.Size(56, 13);
            this.lbl_inform_num_2.TabIndex = 8;
            this.lbl_inform_num_2.Text = "2. Number";
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(72, 165);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(171, 23);
            this.btn_calc.TabIndex = 9;
            this.btn_calc.Text = "Calculate";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // chx_operation_add
            // 
            this.chx_operation_add.AutoSize = true;
            this.chx_operation_add.Location = new System.Drawing.Point(72, 117);
            this.chx_operation_add.Name = "chx_operation_add";
            this.chx_operation_add.Size = new System.Drawing.Size(63, 17);
            this.chx_operation_add.TabIndex = 10;
            this.chx_operation_add.TabStop = true;
            this.chx_operation_add.Text = "Addition";
            this.chx_operation_add.UseVisualStyleBackColor = true;
            // 
            // chx_operation_sub
            // 
            this.chx_operation_sub.AutoSize = true;
            this.chx_operation_sub.Location = new System.Drawing.Point(72, 142);
            this.chx_operation_sub.Name = "chx_operation_sub";
            this.chx_operation_sub.Size = new System.Drawing.Size(79, 17);
            this.chx_operation_sub.TabIndex = 11;
            this.chx_operation_sub.TabStop = true;
            this.chx_operation_sub.Text = "Subtraction";
            this.chx_operation_sub.UseVisualStyleBackColor = true;
            // 
            // chx_operation_mult
            // 
            this.chx_operation_mult.AutoSize = true;
            this.chx_operation_mult.Location = new System.Drawing.Point(158, 118);
            this.chx_operation_mult.Name = "chx_operation_mult";
            this.chx_operation_mult.Size = new System.Drawing.Size(84, 17);
            this.chx_operation_mult.TabIndex = 12;
            this.chx_operation_mult.TabStop = true;
            this.chx_operation_mult.Text = "Multipication";
            this.chx_operation_mult.UseVisualStyleBackColor = true;
            // 
            // chx_operation_div
            // 
            this.chx_operation_div.AutoSize = true;
            this.chx_operation_div.Location = new System.Drawing.Point(158, 142);
            this.chx_operation_div.Name = "chx_operation_div";
            this.chx_operation_div.Size = new System.Drawing.Size(62, 17);
            this.chx_operation_div.TabIndex = 13;
            this.chx_operation_div.TabStop = true;
            this.chx_operation_div.Text = "Division";
            this.chx_operation_div.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 451);
            this.Controls.Add(this.chx_operation_div);
            this.Controls.Add(this.chx_operation_mult);
            this.Controls.Add(this.chx_operation_sub);
            this.Controls.Add(this.chx_operation_add);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.lbl_inform_num_2);
            this.Controls.Add(this.lbl_inform_num_1);
            this.Controls.Add(this.txb_number_2);
            this.Controls.Add(this.lst_totals);
            this.Controls.Add(this.txb_number_1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_number_1;
        private System.Windows.Forms.ListBox lst_totals;
        private System.Windows.Forms.TextBox txb_number_2;
        private System.Windows.Forms.Label lbl_inform_num_1;
        private System.Windows.Forms.Label lbl_inform_num_2;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.RadioButton chx_operation_add;
        private System.Windows.Forms.RadioButton chx_operation_sub;
        private System.Windows.Forms.RadioButton chx_operation_mult;
        private System.Windows.Forms.RadioButton chx_operation_div;
    }
}

