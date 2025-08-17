namespace APS_StepByStep_UI
{
    partial class UI
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
            txtClientID = new TextBox();
            txtClientSecret = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtToken = new TextBox();
            btnGetToken = new Button();
            SuspendLayout();
            // 
            // txtClientID
            // 
            txtClientID.Location = new Point(129, 25);
            txtClientID.Name = "txtClientID";
            txtClientID.Size = new Size(578, 27);
            txtClientID.TabIndex = 0;
            txtClientID.Text = "dmqcHi4CsHnSoH5NZB3L6ZjTzBCaKWA2HGn26Zh9IPasxBLk";
            // 
            // txtClientSecret
            // 
            txtClientSecret.Location = new Point(129, 62);
            txtClientSecret.Name = "txtClientSecret";
            txtClientSecret.Size = new Size(578, 27);
            txtClientSecret.TabIndex = 1;
            txtClientSecret.Text = "YakHyIAogXSWsWpnGGLXPhgSkIAAYgGHEzxk4cXJZDa5x3gc69TFAbmbaNXwuq1Q";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 25);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 2;
            label1.Text = "Client ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 62);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 3;
            label2.Text = "Client Secret";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 121);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 4;
            label3.Text = "Token";
            // 
            // txtToken
            // 
            txtToken.Location = new Point(129, 121);
            txtToken.Multiline = true;
            txtToken.Name = "txtToken";
            txtToken.Size = new Size(578, 338);
            txtToken.TabIndex = 5;
            // 
            // btnGetToken
            // 
            btnGetToken.Location = new Point(19, 180);
            btnGetToken.Name = "btnGetToken";
            btnGetToken.Size = new Size(94, 61);
            btnGetToken.TabIndex = 6;
            btnGetToken.Text = "Get Token";
            btnGetToken.UseVisualStyleBackColor = true;
            btnGetToken.Click += btnGetToken_Click;
            // 
            // UI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 471);
            Controls.Add(btnGetToken);
            Controls.Add(txtToken);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtClientSecret);
            Controls.Add(txtClientID);
            Name = "UI";
            Text = "APS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtClientID;
        private TextBox txtClientSecret;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtToken;
        private Button btnGetToken;
    }
}
