namespace Laboratorio_2
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
            resultadolbl = new Label();
            button1 = new Button();
            minutostxt = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(45, 66);
            label1.Name = "label1";
            label1.Size = new Size(279, 38);
            label1.TabIndex = 0;
            label1.Text = "Cantidad de mintuos:";
            // 
            // resultadolbl
            // 
            resultadolbl.AutoSize = true;
            resultadolbl.BackColor = Color.FromArgb(192, 255, 192);
            resultadolbl.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            resultadolbl.Location = new Point(218, 222);
            resultadolbl.Name = "resultadolbl";
            resultadolbl.Size = new Size(169, 38);
            resultadolbl.TabIndex = 1;
            resultadolbl.Text = "                   ";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(218, 138);
            button1.Name = "button1";
            button1.Size = new Size(171, 45);
            button1.TabIndex = 2;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // minutostxt
            // 
            minutostxt.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            minutostxt.Location = new Point(348, 63);
            minutostxt.Name = "minutostxt";
            minutostxt.Size = new Size(193, 45);
            minutostxt.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 324);
            Controls.Add(minutostxt);
            Controls.Add(button1);
            Controls.Add(resultadolbl);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label resultadolbl;
        private Button button1;
        private TextBox minutostxt;
    }
}