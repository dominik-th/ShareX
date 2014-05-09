﻿namespace ScreenCaptureLib
{
    partial class FFmpegCLIOptionsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FFmpegCLIOptionsForm));
            this.lblExt = new System.Windows.Forms.Label();
            this.lblQuantizer = new System.Windows.Forms.Label();
            this.nudCRF = new System.Windows.Forms.NumericUpDown();
            this.toolTipFFmpeg = new System.Windows.Forms.ToolTip(this.components);
            this.comboBoxExtension = new System.Windows.Forms.ComboBox();
            this.lblCodec = new System.Windows.Forms.Label();
            this.comboBoxCodec = new System.Windows.Forms.ComboBox();
            this.comboBoxPreset = new System.Windows.Forms.ComboBox();
            this.lblPreset = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCRF)).BeginInit();
            this.SuspendLayout();
            // 
            // lblExt
            // 
            this.lblExt.AutoSize = true;
            this.lblExt.Location = new System.Drawing.Point(16, 112);
            this.lblExt.Name = "lblExt";
            this.lblExt.Size = new System.Drawing.Size(56, 13);
            this.lblExt.TabIndex = 11;
            this.lblExt.Text = "Extension:";
            // 
            // lblQuantizer
            // 
            this.lblQuantizer.AutoSize = true;
            this.lblQuantizer.Location = new System.Drawing.Point(16, 48);
            this.lblQuantizer.Name = "lblQuantizer";
            this.lblQuantizer.Size = new System.Drawing.Size(31, 13);
            this.lblQuantizer.TabIndex = 13;
            this.lblQuantizer.Text = "CRF:";
            // 
            // nudCRF
            // 
            this.nudCRF.Location = new System.Drawing.Point(88, 40);
            this.nudCRF.Maximum = new decimal(new int[] {
            51,
            0,
            0,
            0});
            this.nudCRF.Name = "nudCRF";
            this.nudCRF.Size = new System.Drawing.Size(121, 20);
            this.nudCRF.TabIndex = 14;
            this.toolTipFFmpeg.SetToolTip(this.nudCRF, resources.GetString("nudCRF.ToolTip"));
            this.nudCRF.Value = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudCRF.ValueChanged += new System.EventHandler(this.nudCRF_ValueChanged);
            // 
            // comboBoxExtension
            // 
            this.comboBoxExtension.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxExtension.FormattingEnabled = true;
            this.comboBoxExtension.Items.AddRange(new object[] {
            "mp4",
            "webm",
            "avi"});
            this.comboBoxExtension.Location = new System.Drawing.Point(88, 104);
            this.comboBoxExtension.Name = "comboBoxExtension";
            this.comboBoxExtension.Size = new System.Drawing.Size(121, 21);
            this.comboBoxExtension.TabIndex = 15;
            this.comboBoxExtension.Text = "mp4";
            this.comboBoxExtension.SelectedValueChanged += new System.EventHandler(this.comboBoxExtension_SelectedValueChanged);
            // 
            // lblCodec
            // 
            this.lblCodec.AutoSize = true;
            this.lblCodec.Location = new System.Drawing.Point(16, 16);
            this.lblCodec.Name = "lblCodec";
            this.lblCodec.Size = new System.Drawing.Size(41, 13);
            this.lblCodec.TabIndex = 16;
            this.lblCodec.Text = "Codec:";
            // 
            // comboBoxCodec
            // 
            this.comboBoxCodec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCodec.FormattingEnabled = true;
            this.comboBoxCodec.Location = new System.Drawing.Point(88, 8);
            this.comboBoxCodec.Name = "comboBoxCodec";
            this.comboBoxCodec.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCodec.TabIndex = 17;
            this.comboBoxCodec.SelectedIndexChanged += new System.EventHandler(this.comboBoxCodec_SelectedIndexChanged);
            // 
            // comboBoxPreset
            // 
            this.comboBoxPreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPreset.FormattingEnabled = true;
            this.comboBoxPreset.Location = new System.Drawing.Point(88, 72);
            this.comboBoxPreset.Name = "comboBoxPreset";
            this.comboBoxPreset.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPreset.TabIndex = 19;
            this.comboBoxPreset.SelectedIndexChanged += new System.EventHandler(this.comboBoxPreset_SelectedIndexChanged);
            // 
            // lblPreset
            // 
            this.lblPreset.AutoSize = true;
            this.lblPreset.Location = new System.Drawing.Point(16, 80);
            this.lblPreset.Name = "lblPreset";
            this.lblPreset.Size = new System.Drawing.Size(40, 13);
            this.lblPreset.TabIndex = 18;
            this.lblPreset.Text = "Preset:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(200, 184);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(120, 184);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 20;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FFmpegCLIOptionsForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 218);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.comboBoxPreset);
            this.Controls.Add(this.lblPreset);
            this.Controls.Add(this.comboBoxCodec);
            this.Controls.Add(this.lblCodec);
            this.Controls.Add(this.comboBoxExtension);
            this.Controls.Add(this.nudCRF);
            this.Controls.Add(this.lblQuantizer);
            this.Controls.Add(this.lblExt);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 256);
            this.Name = "FFmpegCLIOptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FFmpegGUI";
            ((System.ComponentModel.ISupportInitialize)(this.nudCRF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExt;
        private System.Windows.Forms.Label lblQuantizer;
        private System.Windows.Forms.NumericUpDown nudCRF;
        private System.Windows.Forms.ToolTip toolTipFFmpeg;
        private System.Windows.Forms.ComboBox comboBoxExtension;
        private System.Windows.Forms.Label lblCodec;
        private System.Windows.Forms.ComboBox comboBoxCodec;
        private System.Windows.Forms.ComboBox comboBoxPreset;
        private System.Windows.Forms.Label lblPreset;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}