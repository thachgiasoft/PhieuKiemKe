﻿namespace PhieuKiemKe.MyUserControl
{
    partial class uc_AT_Rows
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_STT = new DevExpress.XtraEditors.TextEdit();
            this.txt_TruongSo10 = new DevExpress.XtraEditors.TextEdit();
            this.txt_TruongSo08 = new DevExpress.XtraEditors.TextEdit();
            this.txt_TruongSo09 = new DevExpress.XtraEditors.TextEdit();
            this.txt_TruongSo07 = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_STT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TruongSo10.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TruongSo08.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TruongSo09.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TruongSo07.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_STT
            // 
            this.txt_STT.Location = new System.Drawing.Point(1, 1);
            this.txt_STT.Name = "txt_STT";
            this.txt_STT.Size = new System.Drawing.Size(30, 20);
            this.txt_STT.TabIndex = 0;
            this.txt_STT.TabStop = false;
            // 
            // txt_TruongSo10
            // 
            this.txt_TruongSo10.Location = new System.Drawing.Point(229, 1);
            this.txt_TruongSo10.Name = "txt_TruongSo10";
            this.txt_TruongSo10.Size = new System.Drawing.Size(30, 20);
            this.txt_TruongSo10.TabIndex = 2;
            // 
            // txt_TruongSo08
            // 
            this.txt_TruongSo08.Location = new System.Drawing.Point(258, 1);
            this.txt_TruongSo08.Name = "txt_TruongSo08";
            this.txt_TruongSo08.Size = new System.Drawing.Size(100, 20);
            this.txt_TruongSo08.TabIndex = 3;
            // 
            // txt_TruongSo09
            // 
            this.txt_TruongSo09.Location = new System.Drawing.Point(357, 1);
            this.txt_TruongSo09.Name = "txt_TruongSo09";
            this.txt_TruongSo09.Size = new System.Drawing.Size(78, 20);
            this.txt_TruongSo09.TabIndex = 4;
            // 
            // txt_TruongSo07
            // 
            this.txt_TruongSo07.Location = new System.Drawing.Point(30, 1);
            this.txt_TruongSo07.Name = "txt_TruongSo07";
            this.txt_TruongSo07.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.txt_TruongSo07.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_TruongSo07.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_TruongSo07.Size = new System.Drawing.Size(200, 20);
            this.txt_TruongSo07.TabIndex = 1;
            // 
            // uc_AT_Rows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.txt_TruongSo07);
            this.Controls.Add(this.txt_TruongSo09);
            this.Controls.Add(this.txt_TruongSo08);
            this.Controls.Add(this.txt_TruongSo10);
            this.Controls.Add(this.txt_STT);
            this.Name = "uc_AT_Rows";
            this.Size = new System.Drawing.Size(436, 21);
            this.Load += new System.EventHandler(this.uc_AT_Rows_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_STT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TruongSo10.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TruongSo08.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TruongSo09.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TruongSo07.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.TextEdit txt_STT;
        public DevExpress.XtraEditors.TextEdit txt_TruongSo10;
        public DevExpress.XtraEditors.TextEdit txt_TruongSo08;
        public DevExpress.XtraEditors.TextEdit txt_TruongSo09;
        public DevExpress.XtraEditors.ComboBoxEdit txt_TruongSo07;
    }
}
