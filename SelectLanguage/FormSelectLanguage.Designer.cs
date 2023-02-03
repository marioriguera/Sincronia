namespace SelectLanguage
{
    partial class FormSelectLanguage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSelectLanguage));
            this.labelSelectLanguage = new System.Windows.Forms.Label();
            this.comboBoxLanguages = new System.Windows.Forms.ComboBox();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSelectLanguage
            // 
            this.labelSelectLanguage.AutoSize = true;
            this.labelSelectLanguage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSelectLanguage.Location = new System.Drawing.Point(12, 30);
            this.labelSelectLanguage.Name = "labelSelectLanguage";
            this.labelSelectLanguage.Size = new System.Drawing.Size(122, 21);
            this.labelSelectLanguage.TabIndex = 0;
            this.labelSelectLanguage.Text = "Select language:";
            // 
            // comboBoxLanguages
            // 
            this.comboBoxLanguages.FormattingEnabled = true;
            this.comboBoxLanguages.Items.AddRange(new object[] {
            "Spanish",
            "English",
            "German",
            "Czech"});
            this.comboBoxLanguages.Location = new System.Drawing.Point(140, 32);
            this.comboBoxLanguages.Name = "comboBoxLanguages";
            this.comboBoxLanguages.Size = new System.Drawing.Size(188, 23);
            this.comboBoxLanguages.TabIndex = 1;
            this.comboBoxLanguages.SelectedIndex = 0;
            // 
            // buttonContinue
            // 
            this.buttonContinue.Location = new System.Drawing.Point(157, 76);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(75, 23);
            this.buttonContinue.TabIndex = 2;
            this.buttonContinue.Text = "Continue";
            this.buttonContinue.UseVisualStyleBackColor = true;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(253, 76);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormSelectLanguage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(344, 111);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonContinue);
            this.Controls.Add(this.comboBoxLanguages);
            this.Controls.Add(this.labelSelectLanguage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(360, 150);
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(360, 150);
            this.Name = "FormSelectLanguage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Language Installation Selector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelSelectLanguage;
        private ComboBox comboBoxLanguages;
        private Button buttonContinue;
        private Button buttonCancel;
    }
}