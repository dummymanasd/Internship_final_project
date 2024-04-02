
namespace Internship2024
{
    partial class AddItems
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
            this.createAreaLbl = new Infragistics.Win.Misc.UltraLabel();
            this.uCodeLbl = new Infragistics.Win.Misc.UltraLabel();
            this.aNameLbl = new Infragistics.Win.Misc.UltraLabel();
            this.aCodeLbl = new Infragistics.Win.Misc.UltraLabel();
            this.depNameLbl = new Infragistics.Win.Misc.UltraLabel();
            this.descriptionLbl = new Infragistics.Win.Misc.UltraLabel();
            this.desTextArea = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.uniqueCodeTxt = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.areaNameTxt = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.areaCodeTxt = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.departmentNameTxt = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.isforDispenCheckBox = new System.Windows.Forms.CheckBox();
            this.isActiveCheckbox = new System.Windows.Forms.CheckBox();
            this.cancelBtn = new Infragistics.Win.Misc.UltraButton();
            this.saveBtn = new Infragistics.Win.Misc.UltraButton();
            ((System.ComponentModel.ISupportInitialize)(this.desTextArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniqueCodeTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaNameTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaCodeTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentNameTxt)).BeginInit();
            this.SuspendLayout();
            // 
            // createAreaLbl
            // 
            this.createAreaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAreaLbl.Location = new System.Drawing.Point(3, 1);
            this.createAreaLbl.Name = "createAreaLbl";
            this.createAreaLbl.Size = new System.Drawing.Size(173, 43);
            this.createAreaLbl.TabIndex = 0;
            this.createAreaLbl.Text = "Create Area";
            this.createAreaLbl.Click += new System.EventHandler(this.ultraLabel1_Click);
            // 
            // uCodeLbl
            // 
            this.uCodeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uCodeLbl.Location = new System.Drawing.Point(22, 82);
            this.uCodeLbl.Name = "uCodeLbl";
            this.uCodeLbl.Size = new System.Drawing.Size(172, 42);
            this.uCodeLbl.TabIndex = 1;
            this.uCodeLbl.Text = "Unique Code";
            // 
            // aNameLbl
            // 
            this.aNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aNameLbl.Location = new System.Drawing.Point(22, 156);
            this.aNameLbl.Name = "aNameLbl";
            this.aNameLbl.Size = new System.Drawing.Size(172, 42);
            this.aNameLbl.TabIndex = 2;
            this.aNameLbl.Text = "Area Name";
            // 
            // aCodeLbl
            // 
            this.aCodeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aCodeLbl.Location = new System.Drawing.Point(22, 233);
            this.aCodeLbl.Name = "aCodeLbl";
            this.aCodeLbl.Size = new System.Drawing.Size(172, 42);
            this.aCodeLbl.TabIndex = 2;
            this.aCodeLbl.Text = "Area Code";
            // 
            // depNameLbl
            // 
            this.depNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depNameLbl.Location = new System.Drawing.Point(22, 308);
            this.depNameLbl.Name = "depNameLbl";
            this.depNameLbl.Size = new System.Drawing.Size(211, 42);
            this.depNameLbl.TabIndex = 2;
            this.depNameLbl.Text = "Department Name";
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLbl.Location = new System.Drawing.Point(708, 82);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(172, 42);
            this.descriptionLbl.TabIndex = 1;
            this.descriptionLbl.Text = "Description";
            // 
            // desTextArea
            // 
            this.desTextArea.Location = new System.Drawing.Point(856, 58);
            this.desTextArea.Multiline = true;
            this.desTextArea.Name = "desTextArea";
            this.desTextArea.Size = new System.Drawing.Size(352, 182);
            this.desTextArea.TabIndex = 3;
            // 
            // uniqueCodeTxt
            // 
            this.uniqueCodeTxt.Location = new System.Drawing.Point(250, 82);
            this.uniqueCodeTxt.Multiline = true;
            this.uniqueCodeTxt.Name = "uniqueCodeTxt";
            this.uniqueCodeTxt.Size = new System.Drawing.Size(397, 42);
            this.uniqueCodeTxt.TabIndex = 4;
            // 
            // areaNameTxt
            // 
            this.areaNameTxt.Location = new System.Drawing.Point(250, 156);
            this.areaNameTxt.Multiline = true;
            this.areaNameTxt.Name = "areaNameTxt";
            this.areaNameTxt.Size = new System.Drawing.Size(397, 42);
            this.areaNameTxt.TabIndex = 5;
            // 
            // areaCodeTxt
            // 
            this.areaCodeTxt.Location = new System.Drawing.Point(250, 233);
            this.areaCodeTxt.Multiline = true;
            this.areaCodeTxt.Name = "areaCodeTxt";
            this.areaCodeTxt.Size = new System.Drawing.Size(397, 42);
            this.areaCodeTxt.TabIndex = 6;
            // 
            // departmentNameTxt
            // 
            this.departmentNameTxt.Location = new System.Drawing.Point(250, 308);
            this.departmentNameTxt.Multiline = true;
            this.departmentNameTxt.Name = "departmentNameTxt";
            this.departmentNameTxt.Size = new System.Drawing.Size(397, 42);
            this.departmentNameTxt.TabIndex = 7;
            // 
            // isforDispenCheckBox
            // 
            this.isforDispenCheckBox.AutoSize = true;
            this.isforDispenCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isforDispenCheckBox.Location = new System.Drawing.Point(22, 421);
            this.isforDispenCheckBox.Name = "isforDispenCheckBox";
            this.isforDispenCheckBox.Size = new System.Drawing.Size(203, 30);
            this.isforDispenCheckBox.TabIndex = 11;
            this.isforDispenCheckBox.Text = "Is For Dispensing";
            this.isforDispenCheckBox.UseVisualStyleBackColor = true;
            this.isforDispenCheckBox.CheckedChanged += new System.EventHandler(this.ultraLabel1_Click);
            // 
            // isActiveCheckbox
            // 
            this.isActiveCheckbox.AutoSize = true;
            this.isActiveCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isActiveCheckbox.Location = new System.Drawing.Point(22, 485);
            this.isActiveCheckbox.Name = "isActiveCheckbox";
            this.isActiveCheckbox.Size = new System.Drawing.Size(117, 30);
            this.isActiveCheckbox.TabIndex = 12;
            this.isActiveCheckbox.Text = "Is Active";
            this.isActiveCheckbox.UseVisualStyleBackColor = true;
            this.isActiveCheckbox.CheckedChanged += new System.EventHandler(this.ultraLabel1_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(845, 544);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(172, 56);
            this.cancelBtn.TabIndex = 13;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.Click += new System.EventHandler(this.ultraLabel1_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(1036, 544);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(172, 56);
            this.saveBtn.TabIndex = 14;
            this.saveBtn.Text = "Save";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // AddItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 612);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.isActiveCheckbox);
            this.Controls.Add(this.isforDispenCheckBox);
            this.Controls.Add(this.departmentNameTxt);
            this.Controls.Add(this.areaCodeTxt);
            this.Controls.Add(this.areaNameTxt);
            this.Controls.Add(this.uniqueCodeTxt);
            this.Controls.Add(this.desTextArea);
            this.Controls.Add(this.depNameLbl);
            this.Controls.Add(this.aCodeLbl);
            this.Controls.Add(this.aNameLbl);
            this.Controls.Add(this.descriptionLbl);
            this.Controls.Add(this.uCodeLbl);
            this.Controls.Add(this.createAreaLbl);
            this.Name = "AddItems";
            this.Text = "AddItems";
            ((System.ComponentModel.ISupportInitialize)(this.desTextArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniqueCodeTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaNameTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaCodeTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentNameTxt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Infragistics.Win.Misc.UltraButton saveBtn;

        #endregion

        private Infragistics.Win.Misc.UltraLabel createAreaLbl;
        private Infragistics.Win.Misc.UltraLabel uCodeLbl;
        private Infragistics.Win.Misc.UltraLabel aNameLbl;
        private Infragistics.Win.Misc.UltraLabel aCodeLbl;
        private Infragistics.Win.Misc.UltraLabel depNameLbl;
        private Infragistics.Win.Misc.UltraLabel descriptionLbl;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor desTextArea;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor uniqueCodeTxt;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor areaNameTxt;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor areaCodeTxt;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor departmentNameTxt;
        private System.Windows.Forms.CheckBox isforDispenCheckBox;
        private System.Windows.Forms.CheckBox isActiveCheckbox;
        private Infragistics.Win.Misc.UltraButton cancelBtn;
    }
}