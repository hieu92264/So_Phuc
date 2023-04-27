namespace So_Phuc
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txt_a = new TextBox();
            label2 = new Label();
            txt_b = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txt_d = new TextBox();
            txt_c = new TextBox();
            label5 = new Label();
            BTN_Run = new Button();
            BTN_Reset = new Button();
            BTN_Exit = new Button();
            groupBox1 = new GroupBox();
            rdo_sub = new RadioButton();
            rdo_add = new RadioButton();
            label6 = new Label();
            txt_f = new TextBox();
            txt_e = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(200, 126);
            label1.Name = "label1";
            label1.Size = new Size(17, 18);
            label1.TabIndex = 0;
            label1.Text = "+";
            // 
            // txt_a
            // 
            txt_a.Location = new Point(144, 121);
            txt_a.Name = "txt_a";
            txt_a.Size = new Size(50, 23);
            txt_a.TabIndex = 1;
            txt_a.KeyPress += txt_a_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(15, 126);
            label2.Name = "label2";
            label2.Size = new Size(123, 18);
            label2.TabIndex = 2;
            label2.Text = "Nhập số phức 1:";
            // 
            // txt_b
            // 
            txt_b.Location = new Point(223, 121);
            txt_b.Name = "txt_b";
            txt_b.Size = new Size(50, 23);
            txt_b.TabIndex = 3;
            txt_b.KeyPress += txt_b_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(279, 126);
            label3.Name = "label3";
            label3.Size = new Size(12, 18);
            label3.TabIndex = 4;
            label3.Text = "i";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(279, 185);
            label4.Name = "label4";
            label4.Size = new Size(12, 18);
            label4.TabIndex = 8;
            label4.Text = "i";
            // 
            // txt_d
            // 
            txt_d.Location = new Point(223, 180);
            txt_d.Name = "txt_d";
            txt_d.Size = new Size(50, 23);
            txt_d.TabIndex = 7;
            txt_d.KeyPress += txt_d_KeyPress;
            // 
            // txt_c
            // 
            txt_c.Location = new Point(144, 180);
            txt_c.Name = "txt_c";
            txt_c.Size = new Size(50, 23);
            txt_c.TabIndex = 6;
            txt_c.KeyPress += txt_c_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(200, 185);
            label5.Name = "label5";
            label5.Size = new Size(17, 18);
            label5.TabIndex = 5;
            label5.Text = "+";
            // 
            // BTN_Run
            // 
            BTN_Run.Location = new Point(24, 282);
            BTN_Run.Name = "BTN_Run";
            BTN_Run.Size = new Size(75, 23);
            BTN_Run.TabIndex = 9;
            BTN_Run.Text = "Tính";
            BTN_Run.UseVisualStyleBackColor = true;
            BTN_Run.Click += BTN_Run_Click;
            // 
            // BTN_Reset
            // 
            BTN_Reset.Location = new Point(163, 282);
            BTN_Reset.Name = "BTN_Reset";
            BTN_Reset.Size = new Size(75, 23);
            BTN_Reset.TabIndex = 10;
            BTN_Reset.Text = "Reset";
            BTN_Reset.UseVisualStyleBackColor = true;
            BTN_Reset.Click += BTN_Reset_Click;
            // 
            // BTN_Exit
            // 
            BTN_Exit.Location = new Point(292, 282);
            BTN_Exit.Name = "BTN_Exit";
            BTN_Exit.Size = new Size(75, 23);
            BTN_Exit.TabIndex = 11;
            BTN_Exit.Text = "Thoát";
            BTN_Exit.UseVisualStyleBackColor = true;
            BTN_Exit.Click += BTN_Exit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdo_sub);
            groupBox1.Controls.Add(rdo_add);
            groupBox1.Location = new Point(15, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(401, 100);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chọn phép toán";
            // 
            // rdo_sub
            // 
            rdo_sub.AutoSize = true;
            rdo_sub.Location = new Point(172, 43);
            rdo_sub.Name = "rdo_sub";
            rdo_sub.Size = new Size(70, 19);
            rdo_sub.TabIndex = 1;
            rdo_sub.TabStop = true;
            rdo_sub.Text = "Phép trừ";
            rdo_sub.UseVisualStyleBackColor = true;
            rdo_sub.CheckedChanged += rdo_sub_CheckedChanged;
            // 
            // rdo_add
            // 
            rdo_add.AutoSize = true;
            rdo_add.Location = new Point(35, 43);
            rdo_add.Name = "rdo_add";
            rdo_add.Size = new Size(82, 19);
            rdo_add.TabIndex = 0;
            rdo_add.TabStop = true;
            rdo_add.Text = "Phép cộng";
            rdo_add.UseVisualStyleBackColor = true;
            rdo_add.CheckedChanged += rdo_add_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(279, 237);
            label6.Name = "label6";
            label6.Size = new Size(16, 18);
            label6.TabIndex = 16;
            label6.Text = "i ";
            // 
            // txt_f
            // 
            txt_f.Location = new Point(223, 232);
            txt_f.Name = "txt_f";
            txt_f.ReadOnly = true;
            txt_f.Size = new Size(50, 23);
            txt_f.TabIndex = 15;
            // 
            // txt_e
            // 
            txt_e.Location = new Point(144, 232);
            txt_e.Name = "txt_e";
            txt_e.ReadOnly = true;
            txt_e.Size = new Size(50, 23);
            txt_e.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(200, 237);
            label7.Name = "label7";
            label7.Size = new Size(17, 18);
            label7.TabIndex = 13;
            label7.Text = "+";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(15, 180);
            label8.Name = "label8";
            label8.Size = new Size(123, 18);
            label8.TabIndex = 17;
            label8.Text = "Nhập số phức 2:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(15, 237);
            label9.Name = "label9";
            label9.Size = new Size(67, 18);
            label9.TabIndex = 18;
            label9.Text = "Kết quả:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(424, 325);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(txt_f);
            Controls.Add(txt_e);
            Controls.Add(label7);
            Controls.Add(groupBox1);
            Controls.Add(BTN_Exit);
            Controls.Add(BTN_Reset);
            Controls.Add(BTN_Run);
            Controls.Add(label4);
            Controls.Add(txt_d);
            Controls.Add(txt_c);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(txt_b);
            Controls.Add(label2);
            Controls.Add(txt_a);
            Controls.Add(label1);
            MaximizeBox = false;
            MaximumSize = new Size(440, 364);
            MinimumSize = new Size(440, 364);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tính số phức";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_a;
        private Label label2;
        private TextBox txt_b;
        private Label label3;
        private Label label4;
        private TextBox txt_d;
        private TextBox txt_c;
        private Label label5;
        private Button BTN_Run;
        private Button BTN_Reset;
        private Button BTN_Exit;
        private GroupBox groupBox1;
        private RadioButton rdo_sub;
        private RadioButton rdo_add;
        private Label label6;
        private TextBox txt_f;
        private TextBox txt_e;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}