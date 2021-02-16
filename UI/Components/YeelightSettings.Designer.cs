namespace LiveSplit.UI.Components
{
    partial class YeelightSettings
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
            this.components = new System.ComponentModel.Container();
            this.ttVolume = new System.Windows.Forms.ToolTip(this.components);
            this.tpSoundFiles = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtSplitPath = new System.Windows.Forms.TextBox();
            this.txtSplitAheadGaining = new System.Windows.Forms.TextBox();
            this.txtSplitAheadLosing = new System.Windows.Forms.TextBox();
            this.txtSplitBehindGaining = new System.Windows.Forms.TextBox();
            this.txtSplitBehindLosing = new System.Windows.Forms.TextBox();
            this.txtBestSegment = new System.Windows.Forms.TextBox();
            this.txtUndo = new System.Windows.Forms.TextBox();
            this.txtSkip = new System.Windows.Forms.TextBox();
            this.txtPersonalBest = new System.Windows.Forms.TextBox();
            this.txtNotAPersonalBest = new System.Windows.Forms.TextBox();
            this.txtReset = new System.Windows.Forms.TextBox();
            this.txtPause = new System.Windows.Forms.TextBox();
            this.txtResume = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtStartTimer = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpSoundFiles.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ttVolume
            // 
            this.ttVolume.AutoPopDelay = 5000;
            this.ttVolume.InitialDelay = 1000;
            this.ttVolume.ReshowDelay = 500;
            this.ttVolume.ShowAlways = true;
            // 
            // tpSoundFiles
            // 
            this.tpSoundFiles.Controls.Add(this.tableLayoutPanel1);
            this.tpSoundFiles.Location = new System.Drawing.Point(4, 22);
            this.tpSoundFiles.Name = "tpSoundFiles";
            this.tpSoundFiles.Padding = new System.Windows.Forms.Padding(3);
            this.tpSoundFiles.Size = new System.Drawing.Size(454, 413);
            this.tpSoundFiles.TabIndex = 0;
            this.tpSoundFiles.Text = "Sound Files";
            this.tpSoundFiles.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 146F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.txtStartTimer, 1, 13);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtResume, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.txtPause, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.txtReset, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.txtNotAPersonalBest, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.txtPersonalBest, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.txtSkip, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtUndo, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtBestSegment, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtSplitBehindLosing, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtSplitBehindGaining, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtSplitAheadLosing, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtSplitAheadGaining, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtSplitPath, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 15;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(448, 407);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtSplitPath
            // 
            this.txtSplitPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSplitPath.Location = new System.Drawing.Point(149, 4);
            this.txtSplitPath.Name = "txtSplitPath";
            this.txtSplitPath.Size = new System.Drawing.Size(296, 20);
            this.txtSplitPath.TabIndex = 1;
            // 
            // txtSplitAheadGaining
            // 
            this.txtSplitAheadGaining.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSplitAheadGaining.Location = new System.Drawing.Point(149, 33);
            this.txtSplitAheadGaining.Name = "txtSplitAheadGaining";
            this.txtSplitAheadGaining.Size = new System.Drawing.Size(296, 20);
            this.txtSplitAheadGaining.TabIndex = 4;
            // 
            // txtSplitAheadLosing
            // 
            this.txtSplitAheadLosing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSplitAheadLosing.Location = new System.Drawing.Point(149, 62);
            this.txtSplitAheadLosing.Name = "txtSplitAheadLosing";
            this.txtSplitAheadLosing.Size = new System.Drawing.Size(296, 20);
            this.txtSplitAheadLosing.TabIndex = 7;
            // 
            // txtSplitBehindGaining
            // 
            this.txtSplitBehindGaining.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSplitBehindGaining.Location = new System.Drawing.Point(149, 91);
            this.txtSplitBehindGaining.Name = "txtSplitBehindGaining";
            this.txtSplitBehindGaining.Size = new System.Drawing.Size(296, 20);
            this.txtSplitBehindGaining.TabIndex = 10;
            // 
            // txtSplitBehindLosing
            // 
            this.txtSplitBehindLosing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSplitBehindLosing.Location = new System.Drawing.Point(149, 120);
            this.txtSplitBehindLosing.Name = "txtSplitBehindLosing";
            this.txtSplitBehindLosing.Size = new System.Drawing.Size(296, 20);
            this.txtSplitBehindLosing.TabIndex = 13;
            // 
            // txtBestSegment
            // 
            this.txtBestSegment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBestSegment.Location = new System.Drawing.Point(149, 149);
            this.txtBestSegment.Name = "txtBestSegment";
            this.txtBestSegment.Size = new System.Drawing.Size(296, 20);
            this.txtBestSegment.TabIndex = 16;
            // 
            // txtUndo
            // 
            this.txtUndo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUndo.Location = new System.Drawing.Point(149, 178);
            this.txtUndo.Name = "txtUndo";
            this.txtUndo.Size = new System.Drawing.Size(296, 20);
            this.txtUndo.TabIndex = 19;
            // 
            // txtSkip
            // 
            this.txtSkip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSkip.Location = new System.Drawing.Point(149, 207);
            this.txtSkip.Name = "txtSkip";
            this.txtSkip.Size = new System.Drawing.Size(296, 20);
            this.txtSkip.TabIndex = 22;
            // 
            // txtPersonalBest
            // 
            this.txtPersonalBest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPersonalBest.Location = new System.Drawing.Point(149, 236);
            this.txtPersonalBest.Name = "txtPersonalBest";
            this.txtPersonalBest.Size = new System.Drawing.Size(296, 20);
            this.txtPersonalBest.TabIndex = 25;
            // 
            // txtNotAPersonalBest
            // 
            this.txtNotAPersonalBest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotAPersonalBest.Location = new System.Drawing.Point(149, 265);
            this.txtNotAPersonalBest.Name = "txtNotAPersonalBest";
            this.txtNotAPersonalBest.Size = new System.Drawing.Size(296, 20);
            this.txtNotAPersonalBest.TabIndex = 28;
            // 
            // txtReset
            // 
            this.txtReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReset.Location = new System.Drawing.Point(149, 294);
            this.txtReset.Name = "txtReset";
            this.txtReset.Size = new System.Drawing.Size(296, 20);
            this.txtReset.TabIndex = 31;
            // 
            // txtPause
            // 
            this.txtPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPause.Location = new System.Drawing.Point(149, 323);
            this.txtPause.Name = "txtPause";
            this.txtPause.Size = new System.Drawing.Size(296, 20);
            this.txtPause.TabIndex = 34;
            // 
            // txtResume
            // 
            this.txtResume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResume.Location = new System.Drawing.Point(149, 352);
            this.txtResume.Name = "txtResume";
            this.txtResume.Size = new System.Drawing.Size(296, 20);
            this.txtResume.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Split:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Split (Ahead, Gaining Time):";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Split (Ahead, Losing Time):";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Split (Behind, Gaining Time):";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Split (Behind, Losing Time):";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Split (Best Segment):";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Undo Split:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Skip Split:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Personal Best:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Not a Personal Best:";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 298);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Reset:";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 327);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "Pause:";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 356);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(140, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "Resume:";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 385);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(140, 13);
            this.label14.TabIndex = 39;
            this.label14.Text = "Start Timer:";
            // 
            // txtStartTimer
            // 
            this.txtStartTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStartTimer.Location = new System.Drawing.Point(149, 381);
            this.txtStartTimer.Name = "txtStartTimer";
            this.txtStartTimer.Size = new System.Drawing.Size(296, 20);
            this.txtStartTimer.TabIndex = 40;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpSoundFiles);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(7, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(462, 439);
            this.tabControl1.TabIndex = 0;
            // 
            // YeelightSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "YeelightSettings";
            this.Padding = new System.Windows.Forms.Padding(7);
            this.Size = new System.Drawing.Size(476, 453);
            this.tpSoundFiles.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip ttVolume;
        private System.Windows.Forms.TabPage tpSoundFiles;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtStartTimer;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResume;
        private System.Windows.Forms.TextBox txtPause;
        private System.Windows.Forms.TextBox txtReset;
        private System.Windows.Forms.TextBox txtNotAPersonalBest;
        private System.Windows.Forms.TextBox txtPersonalBest;
        private System.Windows.Forms.TextBox txtSkip;
        private System.Windows.Forms.TextBox txtUndo;
        private System.Windows.Forms.TextBox txtBestSegment;
        private System.Windows.Forms.TextBox txtSplitBehindLosing;
        private System.Windows.Forms.TextBox txtSplitBehindGaining;
        private System.Windows.Forms.TextBox txtSplitAheadLosing;
        private System.Windows.Forms.TextBox txtSplitAheadGaining;
        private System.Windows.Forms.TextBox txtSplitPath;
        private System.Windows.Forms.TabControl tabControl1;
    }
}
