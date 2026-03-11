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
            btnAddRandomAnimal = new Button();
            ((System.ComponentModel.ISupportInitialize)nudAge).BeginInit();
            grpType.SuspendLayout();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(41, 43);
            lblName.Margin = new Padding(2, 0, 2, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(62, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Pet Name:";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(41, 74);
            lblAge.Margin = new Padding(2, 0, 2, 0);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(34, 15);
            lblAge.TabIndex = 1;
            lblAge.Text = "Age: ";
            // 
            // txtName
            // 
            txtName.Location = new Point(118, 43);
            txtName.Margin = new Padding(2, 2, 2, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(141, 23);
            txtName.TabIndex = 2;
            // 
            // nudAge
            // 
            nudAge.Location = new Point(118, 74);
            nudAge.Margin = new Padding(2, 2, 2, 2);
            nudAge.Name = "nudAge";
            nudAge.Size = new Size(86, 23);
            nudAge.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(169, 137);
            btnSave.Margin = new Padding(2, 2, 2, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(88, 40);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(169, 181);
            btnClear.Margin = new Padding(2, 2, 2, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(88, 40);
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
            grpType.Location = new Point(29, 125);
            grpType.Margin = new Padding(2, 2, 2, 2);
            grpType.Name = "grpType";
            grpType.Padding = new Padding(2, 2, 2, 2);
            grpType.Size = new Size(127, 122);
            grpType.TabIndex = 6;
            grpType.TabStop = false;
            grpType.Text = "Type";
            // 
            // radDog
            // 
            radDog.AutoSize = true;
            radDog.Location = new Point(12, 91);
            radDog.Margin = new Padding(2, 2, 2, 2);
            radDog.Name = "radDog";
            radDog.Size = new Size(47, 19);
            radDog.TabIndex = 2;
            radDog.TabStop = true;
            radDog.Text = "Dog";
            radDog.UseVisualStyleBackColor = true;
            // 
            // radCat
            // 
            radCat.AutoSize = true;
            radCat.Location = new Point(12, 60);
            radCat.Margin = new Padding(2, 2, 2, 2);
            radCat.Name = "radCat";
            radCat.Size = new Size(43, 19);
            radCat.TabIndex = 1;
            radCat.TabStop = true;
            radCat.Text = "Cat";
            radCat.UseVisualStyleBackColor = true;
            // 
            // radBird
            // 
            radBird.AutoSize = true;
            radBird.Location = new Point(12, 29);
            radBird.Margin = new Padding(2, 2, 2, 2);
            radBird.Name = "radBird";
            radBird.Size = new Size(46, 19);
            radBird.TabIndex = 0;
            radBird.TabStop = true;
            radBird.Text = "Bird";
            radBird.UseVisualStyleBackColor = true;
            // 
            // lstPet
            // 
            lstPet.FormattingEnabled = true;
            lstPet.Location = new Point(293, 43);
            lstPet.Margin = new Padding(2, 2, 2, 2);
            lstPet.Name = "lstPet";
            lstPet.Size = new Size(251, 199);
            lstPet.TabIndex = 7;
            lstPet.SelectedIndexChanged += lstPet_SelectedIndexChanged;
            // 
            // btnAddRandomAnimal
            // 
            btnAddRandomAnimal.ImageAlign = ContentAlignment.MiddleRight;
            btnAddRandomAnimal.Location = new Point(177, 230);
            btnAddRandomAnimal.Name = "btnAddRandomAnimal";
            btnAddRandomAnimal.Size = new Size(75, 23);
            btnAddRandomAnimal.TabIndex = 8;
            btnAddRandomAnimal.Text = "Random  Pet";
            btnAddRandomAnimal.UseVisualStyleBackColor = true;
            btnAddRandomAnimal.Click += btnAddRandomAnimal_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(btnAddRandomAnimal);
            Controls.Add(lstPet);
            Controls.Add(grpType);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(nudAge);
            Controls.Add(txtName);
            Controls.Add(lblAge);
            Controls.Add(lblName);
            Margin = new Padding(2, 2, 2, 2);
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
        private Button btnAddRandomAnimal;
    }
}
