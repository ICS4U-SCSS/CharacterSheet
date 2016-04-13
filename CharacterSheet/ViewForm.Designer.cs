namespace CharacterSheet
{
    partial class ViewForm
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
            this.nameOutput = new System.Windows.Forms.Label();
            this.heroSelect = new System.Windows.Forms.ComboBox();
            this.classLabel = new System.Windows.Forms.Label();
            this.dexLabel = new System.Windows.Forms.Label();
            this.healthLabel = new System.Windows.Forms.Label();
            this.strLabel = new System.Windows.Forms.Label();
            this.perkLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.perkOutput = new System.Windows.Forms.Label();
            this.healthOutput = new System.Windows.Forms.Label();
            this.strengthOutput = new System.Windows.Forms.Label();
            this.dexterityOutput = new System.Windows.Forms.Label();
            this.classOutput = new System.Windows.Forms.Label();
            this.heroImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.heroImage)).BeginInit();
            this.SuspendLayout();
            // 
            // nameOutput
            // 
            this.nameOutput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nameOutput.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameOutput.Location = new System.Drawing.Point(12, 44);
            this.nameOutput.Name = "nameOutput";
            this.nameOutput.Size = new System.Drawing.Size(135, 41);
            this.nameOutput.TabIndex = 0;
            // 
            // heroSelect
            // 
            this.heroSelect.FormattingEnabled = true;
            this.heroSelect.Location = new System.Drawing.Point(12, 20);
            this.heroSelect.Name = "heroSelect";
            this.heroSelect.Size = new System.Drawing.Size(135, 21);
            this.heroSelect.TabIndex = 1;
            this.heroSelect.Text = "Select Character";
            this.heroSelect.SelectedIndexChanged += new System.EventHandler(this.heroSelect_SelectedIndexChanged);
            // 
            // classLabel
            // 
            this.classLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.classLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classLabel.Location = new System.Drawing.Point(88, 148);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(81, 23);
            this.classLabel.TabIndex = 2;
            this.classLabel.Text = "Class:";
            // 
            // dexLabel
            // 
            this.dexLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dexLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dexLabel.Location = new System.Drawing.Point(88, 184);
            this.dexLabel.Name = "dexLabel";
            this.dexLabel.Size = new System.Drawing.Size(81, 21);
            this.dexLabel.TabIndex = 3;
            this.dexLabel.Text = "Dexterity:";
            // 
            // healthLabel
            // 
            this.healthLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.healthLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthLabel.Location = new System.Drawing.Point(88, 257);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(81, 21);
            this.healthLabel.TabIndex = 4;
            this.healthLabel.Text = "Health:";
            // 
            // strLabel
            // 
            this.strLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.strLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strLabel.Location = new System.Drawing.Point(88, 221);
            this.strLabel.Name = "strLabel";
            this.strLabel.Size = new System.Drawing.Size(81, 21);
            this.strLabel.TabIndex = 5;
            this.strLabel.Text = "Strength:";
            // 
            // perkLabel
            // 
            this.perkLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.perkLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perkLabel.Location = new System.Drawing.Point(88, 292);
            this.perkLabel.Name = "perkLabel";
            this.perkLabel.Size = new System.Drawing.Size(81, 21);
            this.perkLabel.TabIndex = 6;
            this.perkLabel.Text = "Perk:";
            // 
            // exitButton
            // 
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(304, 395);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(64, 27);
            this.exitButton.TabIndex = 27;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // perkOutput
            // 
            this.perkOutput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.perkOutput.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perkOutput.Location = new System.Drawing.Point(202, 292);
            this.perkOutput.Name = "perkOutput";
            this.perkOutput.Size = new System.Drawing.Size(77, 21);
            this.perkOutput.TabIndex = 28;
            // 
            // healthOutput
            // 
            this.healthOutput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.healthOutput.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthOutput.Location = new System.Drawing.Point(202, 257);
            this.healthOutput.Name = "healthOutput";
            this.healthOutput.Size = new System.Drawing.Size(77, 21);
            this.healthOutput.TabIndex = 29;
            // 
            // strengthOutput
            // 
            this.strengthOutput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.strengthOutput.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strengthOutput.Location = new System.Drawing.Point(202, 221);
            this.strengthOutput.Name = "strengthOutput";
            this.strengthOutput.Size = new System.Drawing.Size(77, 21);
            this.strengthOutput.TabIndex = 30;
            // 
            // dexterityOutput
            // 
            this.dexterityOutput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dexterityOutput.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dexterityOutput.Location = new System.Drawing.Point(202, 184);
            this.dexterityOutput.Name = "dexterityOutput";
            this.dexterityOutput.Size = new System.Drawing.Size(77, 21);
            this.dexterityOutput.TabIndex = 31;
            // 
            // classOutput
            // 
            this.classOutput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.classOutput.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classOutput.Location = new System.Drawing.Point(202, 148);
            this.classOutput.Name = "classOutput";
            this.classOutput.Size = new System.Drawing.Size(77, 21);
            this.classOutput.TabIndex = 32;
            // 
            // heroImage
            // 
            this.heroImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.heroImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.heroImage.Location = new System.Drawing.Point(0, 0);
            this.heroImage.Name = "heroImage";
            this.heroImage.Size = new System.Drawing.Size(380, 433);
            this.heroImage.TabIndex = 33;
            this.heroImage.TabStop = false;
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(380, 434);
            this.Controls.Add(this.classOutput);
            this.Controls.Add(this.dexterityOutput);
            this.Controls.Add(this.strengthOutput);
            this.Controls.Add(this.healthOutput);
            this.Controls.Add(this.perkOutput);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.perkLabel);
            this.Controls.Add(this.strLabel);
            this.Controls.Add(this.healthLabel);
            this.Controls.Add(this.dexLabel);
            this.Controls.Add(this.classLabel);
            this.Controls.Add(this.heroSelect);
            this.Controls.Add(this.nameOutput);
            this.Controls.Add(this.heroImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewForm";
            this.Load += new System.EventHandler(this.ViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.heroImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label nameOutput;
        private System.Windows.Forms.ComboBox heroSelect;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.Label dexLabel;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.Label strLabel;
        private System.Windows.Forms.Label perkLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label perkOutput;
        private System.Windows.Forms.Label healthOutput;
        private System.Windows.Forms.Label strengthOutput;
        private System.Windows.Forms.Label dexterityOutput;
        private System.Windows.Forms.Label classOutput;
        private System.Windows.Forms.PictureBox heroImage;
    }
}