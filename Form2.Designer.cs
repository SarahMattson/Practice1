namespace Practice1
{
    partial class Form2
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
            btnSave = new Button();
            btnQuit = new Button();
            lblTtitle = new Label();
            lblSpeak = new Label();
            txtName = new TextBox();
            txtAge = new TextBox();
            txtType = new TextBox();
            lblLoyalty = new Label();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(97, 119);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(148, 55);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(330, 119);
            btnQuit.Margin = new Padding(2);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(148, 55);
            btnQuit.TabIndex = 1;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // lblTtitle
            // 
            lblTtitle.AutoSize = true;
            lblTtitle.Location = new Point(267, 21);
            lblTtitle.Margin = new Padding(2, 0, 2, 0);
            lblTtitle.Name = "lblTtitle";
            lblTtitle.Size = new Size(38, 15);
            lblTtitle.TabIndex = 2;
            lblTtitle.Text = "label1";
            // 
            // lblSpeak
            // 
            lblSpeak.AutoSize = true;
            lblSpeak.Location = new Point(267, 195);
            lblSpeak.Margin = new Padding(2, 0, 2, 0);
            lblSpeak.Name = "lblSpeak";
            lblSpeak.Size = new Size(38, 15);
            lblSpeak.TabIndex = 3;
            lblSpeak.Text = "label1";
            // 
            // txtName
            // 
            txtName.Location = new Point(97, 68);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new Size(106, 23);
            txtName.TabIndex = 4;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(234, 68);
            txtAge.Margin = new Padding(2);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(106, 23);
            txtAge.TabIndex = 5;
            // 
            // txtType
            // 
            txtType.Location = new Point(372, 68);
            txtType.Margin = new Padding(2);
            txtType.Name = "txtType";
            txtType.Size = new Size(106, 23);
            txtType.TabIndex = 6;
            // 
            // lblLoyalty
            // 
            lblLoyalty.AutoSize = true;
            lblLoyalty.Location = new Point(267, 238);
            lblLoyalty.Margin = new Padding(2, 0, 2, 0);
            lblLoyalty.Name = "lblLoyalty";
            lblLoyalty.Size = new Size(38, 15);
            lblLoyalty.TabIndex = 7;
            lblLoyalty.Text = "label1";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(lblLoyalty);
            Controls.Add(txtType);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(lblSpeak);
            Controls.Add(lblTtitle);
            Controls.Add(btnQuit);
            Controls.Add(btnSave);
            Margin = new Padding(2);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnQuit;
        private Label lblTtitle;
        private Label lblSpeak;
        private TextBox txtName;
        private TextBox txtAge;
        private TextBox txtType;
        private Label lblLoyalty;
    }
}