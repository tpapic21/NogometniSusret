namespace NogometniSusret
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
            btnEvidentiraj = new Button();
            txtHost = new TextBox();
            lblHost = new Label();
            txtGuest = new TextBox();
            lblGuest = new Label();
            txtResult = new TextBox();
            lblResult = new Label();
            SuspendLayout();
            // 
            // btnEvidentiraj
            // 
            btnEvidentiraj.Location = new Point(62, 213);
            btnEvidentiraj.Name = "btnEvidentiraj";
            btnEvidentiraj.Size = new Size(75, 22);
            btnEvidentiraj.TabIndex = 0;
            btnEvidentiraj.Text = "Evidentiraj";
            btnEvidentiraj.UseVisualStyleBackColor = true;
            btnEvidentiraj.Click += btnEvidentiraj_Click;
            // 
            // txtHost
            // 
            txtHost.Location = new Point(93, 37);
            txtHost.Name = "txtHost";
            txtHost.Size = new Size(100, 23);
            txtHost.TabIndex = 1;
            // 
            // lblHost
            // 
            lblHost.AutoSize = true;
            lblHost.Location = new Point(16, 41);
            lblHost.Name = "lblHost";
            lblHost.Size = new Size(55, 15);
            lblHost.TabIndex = 2;
            lblHost.Text = "Domaćin";
            // 
            // txtGuest
            // 
            txtGuest.Location = new Point(93, 86);
            txtGuest.Name = "txtGuest";
            txtGuest.Size = new Size(100, 23);
            txtGuest.TabIndex = 1;
            // 
            // lblGuest
            // 
            lblGuest.AutoSize = true;
            lblGuest.Location = new Point(16, 90);
            lblGuest.Name = "lblGuest";
            lblGuest.Size = new Size(31, 15);
            lblGuest.TabIndex = 2;
            lblGuest.Text = "Gost";
            // 
            // txtResult
            // 
            txtResult.Location = new Point(93, 154);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(100, 23);
            txtResult.TabIndex = 1;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(16, 158);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(49, 15);
            lblResult.TabIndex = 2;
            lblResult.Text = "Rezultat";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(238, 271);
            Controls.Add(lblResult);
            Controls.Add(lblGuest);
            Controls.Add(lblHost);
            Controls.Add(txtResult);
            Controls.Add(txtGuest);
            Controls.Add(txtHost);
            Controls.Add(btnEvidentiraj);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEvidentiraj;
        private TextBox txtHost;
        private Label lblHost;
        private TextBox txtGuest;
        private Label lblGuest;
        private TextBox txtResult;
        private Label lblResult;
    }
}