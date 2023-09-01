namespace LoginWFA
{
    partial class CaloryForm
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
            label5 = new Label();
            label4 = new Label();
            txtFoodCalory = new TextBox();
            txtFoodName = new TextBox();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(409, 3);
            label5.Name = "label5";
            label5.Size = new Size(167, 16);
            label5.TabIndex = 34;
            label5.Text = "Food Calory per 100 (Gr)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(122, 3);
            label4.Name = "label4";
            label4.Size = new Size(81, 16);
            label4.TabIndex = 35;
            label4.Text = "Food Name";
            // 
            // txtFoodCalory
            // 
            txtFoodCalory.BackColor = Color.LightGray;
            txtFoodCalory.BorderStyle = BorderStyle.None;
            txtFoodCalory.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtFoodCalory.ForeColor = Color.Gray;
            txtFoodCalory.Location = new Point(409, 20);
            txtFoodCalory.Multiline = true;
            txtFoodCalory.Name = "txtFoodCalory";
            txtFoodCalory.ReadOnly = true;
            txtFoodCalory.Size = new Size(180, 35);
            txtFoodCalory.TabIndex = 32;
            // 
            // txtFoodName
            // 
            txtFoodName.BackColor = Color.LightGray;
            txtFoodName.BorderStyle = BorderStyle.None;
            txtFoodName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtFoodName.ForeColor = Color.Gray;
            txtFoodName.Location = new Point(122, 20);
            txtFoodName.Multiline = true;
            txtFoodName.Name = "txtFoodName";
            txtFoodName.ReadOnly = true;
            txtFoodName.Size = new Size(180, 35);
            txtFoodName.TabIndex = 33;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Location = new Point(-4, 83);
            panel1.Name = "panel1";
            panel1.Size = new Size(797, 382);
            panel1.TabIndex = 36;
            // 
            // CaloryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(txtFoodName);
            Controls.Add(txtFoodCalory);
            Controls.Add(label4);
            Controls.Add(label5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CaloryForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CaloryForm";
            Load += CaloryForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private TextBox txtFoodCalory;
        private TextBox txtFoodName;
        private Panel panel1;
    }
}