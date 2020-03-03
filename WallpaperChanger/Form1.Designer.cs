namespace U4WC
{
    partial class Form1
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
            this.submitButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.regValueData = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.regValueName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.regKeyName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.openRegEdit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.AutoSize = true;
            this.submitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.submitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitButton.Depth = 0;
            this.submitButton.Icon = null;
            this.submitButton.Location = new System.Drawing.Point(565, 231);
            this.submitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.submitButton.Name = "submitButton";
            this.submitButton.Primary = true;
            this.submitButton.Size = new System.Drawing.Size(170, 36);
            this.submitButton.TabIndex = 1;
            this.submitButton.Text = "Change registry key";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // regValueData
            // 
            this.regValueData.Depth = 0;
            this.regValueData.Hint = "";
            this.regValueData.Location = new System.Drawing.Point(132, 176);
            this.regValueData.MaxLength = 32767;
            this.regValueData.MouseState = MaterialSkin.MouseState.HOVER;
            this.regValueData.Name = "regValueData";
            this.regValueData.PasswordChar = '\0';
            this.regValueData.SelectedText = "";
            this.regValueData.SelectionLength = 0;
            this.regValueData.SelectionStart = 0;
            this.regValueData.Size = new System.Drawing.Size(603, 23);
            this.regValueData.TabIndex = 2;
            this.regValueData.TabStop = false;
            this.regValueData.Text = "C:\\\\";
            this.regValueData.UseSystemPasswordChar = false;
            this.regValueData.Click += new System.EventHandler(this.regValueData_Click);
            // 
            // regValueName
            // 
            this.regValueName.Depth = 0;
            this.regValueName.Hint = "";
            this.regValueName.Location = new System.Drawing.Point(132, 120);
            this.regValueName.MaxLength = 32767;
            this.regValueName.MouseState = MaterialSkin.MouseState.HOVER;
            this.regValueName.Name = "regValueName";
            this.regValueName.PasswordChar = '\0';
            this.regValueName.SelectedText = "";
            this.regValueName.SelectionLength = 0;
            this.regValueName.SelectionStart = 0;
            this.regValueName.Size = new System.Drawing.Size(603, 23);
            this.regValueName.TabIndex = 3;
            this.regValueName.TabStop = false;
            this.regValueName.UseSystemPasswordChar = false;
            // 
            // regKeyName
            // 
            this.regKeyName.Depth = 0;
            this.regKeyName.Hint = "";
            this.regKeyName.Location = new System.Drawing.Point(132, 91);
            this.regKeyName.MaxLength = 32767;
            this.regKeyName.MouseState = MaterialSkin.MouseState.HOVER;
            this.regKeyName.Name = "regKeyName";
            this.regKeyName.PasswordChar = '\0';
            this.regKeyName.SelectedText = "";
            this.regKeyName.SelectionLength = 0;
            this.regKeyName.SelectionStart = 0;
            this.regKeyName.Size = new System.Drawing.Size(603, 23);
            this.regKeyName.TabIndex = 4;
            this.regKeyName.TabStop = false;
            this.regKeyName.UseSystemPasswordChar = false;
            // 
            // openRegEdit
            // 
            this.openRegEdit.AutoSize = true;
            this.openRegEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.openRegEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openRegEdit.Depth = 0;
            this.openRegEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openRegEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openRegEdit.Icon = null;
            this.openRegEdit.Location = new System.Drawing.Point(561, 297);
            this.openRegEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.openRegEdit.Name = "openRegEdit";
            this.openRegEdit.Primary = true;
            this.openRegEdit.Size = new System.Drawing.Size(174, 36);
            this.openRegEdit.TabIndex = 5;
            this.openRegEdit.Text = "Open Registry Editor";
            this.openRegEdit.UseVisualStyleBackColor = true;
            this.openRegEdit.Click += new System.EventHandler(this.openRegEdit_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(8, 95);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(91, 19);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "Registry Key";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(8, 124);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(91, 19);
            this.materialLabel2.TabIndex = 7;
            this.materialLabel2.Text = "Value Name";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(17, 180);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(82, 19);
            this.materialLabel3.TabIndex = 8;
            this.materialLabel3.Text = "Value Data";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(12, 158);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(722, 2);
            this.materialDivider1.TabIndex = 9;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 367);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.openRegEdit);
            this.Controls.Add(this.regKeyName);
            this.Controls.Add(this.regValueName);
            this.Controls.Add(this.regValueData);
            this.Controls.Add(this.submitButton);
            this.Name = "Form1";
            this.Text = " Wallpaper Changer 4U";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton submitButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField regValueData;
        private MaterialSkin.Controls.MaterialSingleLineTextField regValueName;
        private MaterialSkin.Controls.MaterialSingleLineTextField regKeyName;
        private MaterialSkin.Controls.MaterialRaisedButton openRegEdit;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

