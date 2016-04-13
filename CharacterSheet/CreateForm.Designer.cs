namespace CharacterSheet
{
    partial class CreateForm
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
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.fighterButton = new System.Windows.Forms.Button();
            this.rangerButton = new System.Windows.Forms.Button();
            this.mageButton = new System.Windows.Forms.Button();
            this.classLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.attributesLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.healthLabel = new System.Windows.Forms.Label();
            this.dexInput = new System.Windows.Forms.Label();
            this.dexPlus = new System.Windows.Forms.Button();
            this.dexMinus = new System.Windows.Forms.Button();
            this.StregthMinus = new System.Windows.Forms.Button();
            this.strengthPlus = new System.Windows.Forms.Button();
            this.strengthInput = new System.Windows.Forms.Label();
            this.healthMinus = new System.Windows.Forms.Button();
            this.healthPlus = new System.Windows.Forms.Button();
            this.healthInput = new System.Windows.Forms.Label();
            this.sneakRadio = new System.Windows.Forms.RadioButton();
            this.charmRadio = new System.Windows.Forms.RadioButton();
            this.intuitionRadio = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.speedRadio = new System.Windows.Forms.RadioButton();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.pointsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox
            // 
            this.imageBox.BackColor = System.Drawing.Color.Transparent;
            this.imageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imageBox.Location = new System.Drawing.Point(29, 73);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(185, 292);
            this.imageBox.TabIndex = 0;
            this.imageBox.TabStop = false;
            // 
            // fighterButton
            // 
            this.fighterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fighterButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fighterButton.Location = new System.Drawing.Point(29, 43);
            this.fighterButton.Name = "fighterButton";
            this.fighterButton.Size = new System.Drawing.Size(64, 27);
            this.fighterButton.TabIndex = 1;
            this.fighterButton.Text = "Fighter";
            this.fighterButton.UseVisualStyleBackColor = true;
            this.fighterButton.Click += new System.EventHandler(this.fighterButton_Click);
            // 
            // rangerButton
            // 
            this.rangerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rangerButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rangerButton.Location = new System.Drawing.Point(151, 43);
            this.rangerButton.Name = "rangerButton";
            this.rangerButton.Size = new System.Drawing.Size(64, 27);
            this.rangerButton.TabIndex = 2;
            this.rangerButton.Text = "Ranger";
            this.rangerButton.UseVisualStyleBackColor = true;
            this.rangerButton.Click += new System.EventHandler(this.rangerButton_Click);
            // 
            // mageButton
            // 
            this.mageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mageButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mageButton.Location = new System.Drawing.Point(92, 43);
            this.mageButton.Name = "mageButton";
            this.mageButton.Size = new System.Drawing.Size(64, 27);
            this.mageButton.TabIndex = 3;
            this.mageButton.Text = "Mage";
            this.mageButton.UseVisualStyleBackColor = true;
            this.mageButton.Click += new System.EventHandler(this.mageButton_Click);
            // 
            // classLabel
            // 
            this.classLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classLabel.Location = new System.Drawing.Point(29, 19);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(186, 25);
            this.classLabel.TabIndex = 4;
            this.classLabel.Text = "Select Your Class:";
            // 
            // nameLabel
            // 
            this.nameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(237, 19);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(228, 25);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Character Name:";
            // 
            // nameInput
            // 
            this.nameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameInput.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameInput.Location = new System.Drawing.Point(237, 43);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(228, 25);
            this.nameInput.TabIndex = 6;
            // 
            // attributesLabel
            // 
            this.attributesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.attributesLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attributesLabel.Location = new System.Drawing.Point(237, 100);
            this.attributesLabel.Name = "attributesLabel";
            this.attributesLabel.Size = new System.Drawing.Size(199, 25);
            this.attributesLabel.TabIndex = 7;
            this.attributesLabel.Text = "Attributes:              Points Left:";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Dexterity";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(237, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Strength";
            // 
            // healthLabel
            // 
            this.healthLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.healthLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthLabel.Location = new System.Drawing.Point(237, 172);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(113, 25);
            this.healthLabel.TabIndex = 10;
            this.healthLabel.Text = "Health";
            // 
            // dexInput
            // 
            this.dexInput.BackColor = System.Drawing.Color.White;
            this.dexInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dexInput.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dexInput.Location = new System.Drawing.Point(349, 124);
            this.dexInput.Name = "dexInput";
            this.dexInput.Size = new System.Drawing.Size(60, 26);
            this.dexInput.TabIndex = 11;
            this.dexInput.Text = "5";
            this.dexInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dexPlus
            // 
            this.dexPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dexPlus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dexPlus.Location = new System.Drawing.Point(404, 124);
            this.dexPlus.Margin = new System.Windows.Forms.Padding(0);
            this.dexPlus.Name = "dexPlus";
            this.dexPlus.Size = new System.Drawing.Size(32, 26);
            this.dexPlus.TabIndex = 12;
            this.dexPlus.Text = "+";
            this.dexPlus.UseVisualStyleBackColor = true;
            this.dexPlus.Click += new System.EventHandler(this.dexPlus_Click);
            // 
            // dexMinus
            // 
            this.dexMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dexMinus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dexMinus.Location = new System.Drawing.Point(433, 124);
            this.dexMinus.Margin = new System.Windows.Forms.Padding(0);
            this.dexMinus.Name = "dexMinus";
            this.dexMinus.Size = new System.Drawing.Size(32, 26);
            this.dexMinus.TabIndex = 13;
            this.dexMinus.Text = "-";
            this.dexMinus.UseVisualStyleBackColor = true;
            this.dexMinus.Click += new System.EventHandler(this.dexMinus_Click);
            // 
            // StregthMinus
            // 
            this.StregthMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StregthMinus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StregthMinus.Location = new System.Drawing.Point(433, 148);
            this.StregthMinus.Margin = new System.Windows.Forms.Padding(0);
            this.StregthMinus.Name = "StregthMinus";
            this.StregthMinus.Size = new System.Drawing.Size(32, 26);
            this.StregthMinus.TabIndex = 16;
            this.StregthMinus.Text = "-";
            this.StregthMinus.UseVisualStyleBackColor = true;
            this.StregthMinus.Click += new System.EventHandler(this.StregthMinus_Click);
            // 
            // strengthPlus
            // 
            this.strengthPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.strengthPlus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strengthPlus.Location = new System.Drawing.Point(404, 148);
            this.strengthPlus.Margin = new System.Windows.Forms.Padding(0);
            this.strengthPlus.Name = "strengthPlus";
            this.strengthPlus.Size = new System.Drawing.Size(32, 26);
            this.strengthPlus.TabIndex = 15;
            this.strengthPlus.Text = "+";
            this.strengthPlus.UseVisualStyleBackColor = true;
            this.strengthPlus.Click += new System.EventHandler(this.strengthPlus_Click);
            // 
            // strengthInput
            // 
            this.strengthInput.BackColor = System.Drawing.Color.White;
            this.strengthInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.strengthInput.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strengthInput.Location = new System.Drawing.Point(349, 148);
            this.strengthInput.Name = "strengthInput";
            this.strengthInput.Size = new System.Drawing.Size(60, 26);
            this.strengthInput.TabIndex = 14;
            this.strengthInput.Text = "5";
            this.strengthInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // healthMinus
            // 
            this.healthMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.healthMinus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthMinus.Location = new System.Drawing.Point(433, 172);
            this.healthMinus.Margin = new System.Windows.Forms.Padding(0);
            this.healthMinus.Name = "healthMinus";
            this.healthMinus.Size = new System.Drawing.Size(32, 25);
            this.healthMinus.TabIndex = 19;
            this.healthMinus.Text = "-";
            this.healthMinus.UseVisualStyleBackColor = true;
            this.healthMinus.Click += new System.EventHandler(this.healthMinus_Click);
            // 
            // healthPlus
            // 
            this.healthPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.healthPlus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthPlus.Location = new System.Drawing.Point(404, 172);
            this.healthPlus.Margin = new System.Windows.Forms.Padding(0);
            this.healthPlus.Name = "healthPlus";
            this.healthPlus.Size = new System.Drawing.Size(32, 25);
            this.healthPlus.TabIndex = 18;
            this.healthPlus.Text = "+";
            this.healthPlus.UseVisualStyleBackColor = true;
            this.healthPlus.Click += new System.EventHandler(this.healthPlus_Click);
            // 
            // healthInput
            // 
            this.healthInput.BackColor = System.Drawing.Color.White;
            this.healthInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.healthInput.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthInput.Location = new System.Drawing.Point(349, 172);
            this.healthInput.Name = "healthInput";
            this.healthInput.Size = new System.Drawing.Size(60, 25);
            this.healthInput.TabIndex = 17;
            this.healthInput.Text = "5";
            this.healthInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sneakRadio
            // 
            this.sneakRadio.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sneakRadio.Location = new System.Drawing.Point(237, 253);
            this.sneakRadio.Name = "sneakRadio";
            this.sneakRadio.Size = new System.Drawing.Size(114, 24);
            this.sneakRadio.TabIndex = 20;
            this.sneakRadio.TabStop = true;
            this.sneakRadio.Text = "Sneak";
            this.sneakRadio.UseVisualStyleBackColor = true;
            this.sneakRadio.CheckedChanged += new System.EventHandler(this.sneakRadio_CheckedChanged);
            // 
            // charmRadio
            // 
            this.charmRadio.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charmRadio.Location = new System.Drawing.Point(351, 253);
            this.charmRadio.Name = "charmRadio";
            this.charmRadio.Size = new System.Drawing.Size(114, 24);
            this.charmRadio.TabIndex = 21;
            this.charmRadio.TabStop = true;
            this.charmRadio.Text = "Charm";
            this.charmRadio.UseVisualStyleBackColor = true;
            this.charmRadio.CheckedChanged += new System.EventHandler(this.charmRadio_CheckedChanged);
            // 
            // intuitionRadio
            // 
            this.intuitionRadio.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intuitionRadio.Location = new System.Drawing.Point(237, 274);
            this.intuitionRadio.Name = "intuitionRadio";
            this.intuitionRadio.Size = new System.Drawing.Size(114, 24);
            this.intuitionRadio.TabIndex = 22;
            this.intuitionRadio.TabStop = true;
            this.intuitionRadio.Text = "Intuition";
            this.intuitionRadio.UseVisualStyleBackColor = true;
            this.intuitionRadio.CheckedChanged += new System.EventHandler(this.intuitionRadio_CheckedChanged);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(237, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Perks (select one)";
            // 
            // speedRadio
            // 
            this.speedRadio.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedRadio.Location = new System.Drawing.Point(351, 274);
            this.speedRadio.Name = "speedRadio";
            this.speedRadio.Size = new System.Drawing.Size(114, 24);
            this.speedRadio.TabIndex = 24;
            this.speedRadio.TabStop = true;
            this.speedRadio.Text = "Speed";
            this.speedRadio.UseVisualStyleBackColor = true;
            this.speedRadio.CheckedChanged += new System.EventHandler(this.speedRadio_CheckedChanged);
            // 
            // saveButton
            // 
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(331, 338);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(64, 27);
            this.saveButton.TabIndex = 25;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(401, 338);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(64, 27);
            this.cancelButton.TabIndex = 26;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // pointsLabel
            // 
            this.pointsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pointsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointsLabel.Location = new System.Drawing.Point(433, 100);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(32, 25);
            this.pointsLabel.TabIndex = 27;
            this.pointsLabel.Text = "5";
            this.pointsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CharacterSheet.Properties.Resources.forestCrop;
            this.ClientSize = new System.Drawing.Size(493, 401);
            this.Controls.Add(this.pointsLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.speedRadio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.intuitionRadio);
            this.Controls.Add(this.charmRadio);
            this.Controls.Add(this.sneakRadio);
            this.Controls.Add(this.healthMinus);
            this.Controls.Add(this.healthPlus);
            this.Controls.Add(this.healthInput);
            this.Controls.Add(this.StregthMinus);
            this.Controls.Add(this.strengthPlus);
            this.Controls.Add(this.strengthInput);
            this.Controls.Add(this.dexMinus);
            this.Controls.Add(this.dexPlus);
            this.Controls.Add(this.dexInput);
            this.Controls.Add(this.healthLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.attributesLabel);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.classLabel);
            this.Controls.Add(this.mageButton);
            this.Controls.Add(this.rangerButton);
            this.Controls.Add(this.fighterButton);
            this.Controls.Add(this.imageBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hero Creation";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.Button fighterButton;
        private System.Windows.Forms.Button rangerButton;
        private System.Windows.Forms.Button mageButton;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label attributesLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.Label dexInput;
        private System.Windows.Forms.Button dexPlus;
        private System.Windows.Forms.Button dexMinus;
        private System.Windows.Forms.Button StregthMinus;
        private System.Windows.Forms.Button strengthPlus;
        private System.Windows.Forms.Label strengthInput;
        private System.Windows.Forms.Button healthMinus;
        private System.Windows.Forms.Button healthPlus;
        private System.Windows.Forms.Label healthInput;
        private System.Windows.Forms.RadioButton sneakRadio;
        private System.Windows.Forms.RadioButton charmRadio;
        private System.Windows.Forms.RadioButton intuitionRadio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton speedRadio;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label pointsLabel;
    }
}