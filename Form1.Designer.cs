namespace Practice1
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
            lblName = new Label();
            lblAge = new Label();
            txtName = new TextBox();
            nudAge = new NumericUpDown();
            btnSave = new Button();
            btnClear = new Button();
            grpType = new GroupBox();
            radDog = new RadioButton();
            radCat = new RadioButton();
            radBird = new RadioButton();
            lstPet = new ListBox();
            ((System.ComponentModel.ISupportInitialize)nudAge).BeginInit();
            grpType.SuspendLayout();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(58, 72);
            lblName.Name = "lblName";
            lblName.Size = new Size(92, 25);
            lblName.TabIndex = 0;
            lblName.Text = "Pet Name:";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(58, 123);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(53, 25);
            lblAge.TabIndex = 1;
            lblAge.Text = "Age: ";
            // 
            // txtName
            // 
            txtName.Location = new Point(168, 72);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 31);
            txtName.TabIndex = 2;
            // 
            // nudAge
            // 
            nudAge.Location = new Point(168, 123);
            nudAge.Name = "nudAge";
            nudAge.Size = new Size(123, 31);
            nudAge.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(242, 228);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(126, 67);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(242, 336);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(126, 67);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // grpType
            // 
            grpType.Controls.Add(radDog);
            grpType.Controls.Add(radCat);
            grpType.Controls.Add(radBird);
            grpType.Location = new Point(41, 208);
            grpType.Name = "grpType";
            grpType.Size = new Size(181, 204);
            grpType.TabIndex = 6;
            grpType.TabStop = false;
            grpType.Text = "Type";
            // 
            // radDog
            // 
            radDog.AutoSize = true;
            radDog.Location = new Point(17, 151);
            radDog.Name = "radDog";
            radDog.Size = new Size(72, 29);
            radDog.TabIndex = 2;
            radDog.TabStop = true;
            radDog.Text = "Dog";
            radDog.UseVisualStyleBackColor = true;
            // 
            // radCat
            // 
            radCat.AutoSize = true;
            radCat.Location = new Point(17, 100);
            radCat.Name = "radCat";
            radCat.Size = new Size(63, 29);
            radCat.TabIndex = 1;
            radCat.TabStop = true;
            radCat.Text = "Cat";
            radCat.UseVisualStyleBackColor = true;
            // 
            // radBird
            // 
            radBird.AutoSize = true;
            radBird.Location = new Point(17, 49);
            radBird.Name = "radBird";
            radBird.Size = new Size(68, 29);
            radBird.TabIndex = 0;
            radBird.TabStop = true;
            radBird.Text = "Bird";
            radBird.UseVisualStyleBackColor = true;
            // 
            // lstPet
            // 
            lstPet.FormattingEnabled = true;
            lstPet.Location = new Point(418, 72);
            lstPet.Name = "lstPet";
            lstPet.Size = new Size(357, 329);
            lstPet.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstPet);
            Controls.Add(grpType);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(nudAge);
            Controls.Add(txtName);
            Controls.Add(lblAge);
            Controls.Add(lblName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudAge).EndInit();
            grpType.ResumeLayout(false);
            grpType.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblAge;
        private TextBox txtName;
        private NumericUpDown nudAge;
        private Button btnSave;
        private Button btnClear;
        private GroupBox grpType;
        private RadioButton radDog;
        private RadioButton radCat;
        private RadioButton radBird;
        private ListBox lstPet;
    }
}
