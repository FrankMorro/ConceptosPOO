namespace Conceptos.UserInterface
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
            label2 = new Label();
            label3 = new Label();
            txtDay = new TextBox();
            txtMonth = new TextBox();
            txtYear = new TextBox();
            btnValidate = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 87);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 0;
            label1.Text = "Dia:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 116);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 0;
            label2.Text = "Mes:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 145);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 0;
            label3.Text = "Año:";
            // 
            // txtDay
            // 
            txtDay.Location = new Point(97, 84);
            txtDay.Name = "txtDay";
            txtDay.PlaceholderText = "Ingrese el día...";
            txtDay.Size = new Size(132, 23);
            txtDay.TabIndex = 0;
            // 
            // txtMonth
            // 
            txtMonth.Location = new Point(97, 113);
            txtMonth.Name = "txtMonth";
            txtMonth.PlaceholderText = "Ingrese el mes...";
            txtMonth.Size = new Size(132, 23);
            txtMonth.TabIndex = 1;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(97, 142);
            txtYear.Name = "txtYear";
            txtYear.PlaceholderText = "Ingrese el año...";
            txtYear.Size = new Size(132, 23);
            txtYear.TabIndex = 2;
            // 
            // btnValidate
            // 
            btnValidate.Location = new Point(97, 171);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(132, 36);
            btnValidate.TabIndex = 3;
            btnValidate.Text = "Validate";
            btnValidate.UseVisualStyleBackColor = true;
            btnValidate.Click += BtnValidate_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(281, 51);
            label4.TabIndex = 3;
            label4.Text = "Regiestre la fecha correspondiente en los siguientes campos.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 229);
            Controls.Add(label4);
            Controls.Add(btnValidate);
            Controls.Add(txtYear);
            Controls.Add(txtMonth);
            Controls.Add(txtDay);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtDay;
        private TextBox txtMonth;
        private TextBox txtYear;
        private Button btnValidate;
        private Label label4;
    }
}