namespace FlashTimer {
    partial class FrmMain {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.nudHour = new System.Windows.Forms.NumericUpDown();
            this.nudMinute = new System.Windows.Forms.NumericUpDown();
            this.nudSecond = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPassed = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPassedSubSecond = new System.Windows.Forms.Label();
            this.btnOption = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nudAbsHour = new System.Windows.Forms.NumericUpDown();
            this.nudAbsMinute = new System.Windows.Forms.NumericUpDown();
            this.nudAbsSecond = new System.Windows.Forms.NumericUpDown();
            this.chkSetByAbsoluteTime = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNewWindow = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.nudBlink = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.lblSubSecond = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecond)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAbsHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAbsMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAbsSecond)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlink)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // nudHour
            // 
            this.nudHour.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudHour.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.nudHour.Location = new System.Drawing.Point(14, 21);
            this.nudHour.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudHour.Name = "nudHour";
            this.nudHour.Size = new System.Drawing.Size(55, 27);
            this.nudHour.TabIndex = 1;
            this.nudHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudHour.ValueChanged += new System.EventHandler(this.remainChanged);
            this.nudHour.Click += new System.EventHandler(this.numericUpDownEntered);
            this.nudHour.Enter += new System.EventHandler(this.numericUpDownEntered);
            // 
            // nudMinute
            // 
            this.nudMinute.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudMinute.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.nudMinute.Location = new System.Drawing.Point(110, 21);
            this.nudMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudMinute.Name = "nudMinute";
            this.nudMinute.Size = new System.Drawing.Size(55, 27);
            this.nudMinute.TabIndex = 3;
            this.nudMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudMinute.ValueChanged += new System.EventHandler(this.remainChanged);
            this.nudMinute.Click += new System.EventHandler(this.numericUpDownEntered);
            this.nudMinute.Enter += new System.EventHandler(this.numericUpDownEntered);
            // 
            // nudSecond
            // 
            this.nudSecond.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudSecond.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.nudSecond.Location = new System.Drawing.Point(194, 21);
            this.nudSecond.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudSecond.Name = "nudSecond";
            this.nudSecond.Size = new System.Drawing.Size(55, 27);
            this.nudSecond.TabIndex = 5;
            this.nudSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudSecond.ValueChanged += new System.EventHandler(this.remainChanged);
            this.nudSecond.Click += new System.EventHandler(this.numericUpDownEntered);
            this.nudSecond.Enter += new System.EventHandler(this.numericUpDownEntered);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(75, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "時間";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(171, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "分";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(255, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "秒";
            // 
            // btnStartStop
            // 
            this.btnStartStop.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnStartStop.Location = new System.Drawing.Point(101, 54);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(106, 23);
            this.btnStartStop.TabIndex = 7;
            this.btnStartStop.Text = "スタート(&S)";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // btnReset
            // 
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Location = new System.Drawing.Point(213, 54);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(68, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "リセット(&R)";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "経過時間：";
            // 
            // lblPassed
            // 
            this.lblPassed.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPassed.Location = new System.Drawing.Point(71, 12);
            this.lblPassed.Name = "lblPassed";
            this.lblPassed.Size = new System.Drawing.Size(82, 20);
            this.lblPassed.TabIndex = 3;
            this.lblPassed.Text = "00:00:00";
            this.lblPassed.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "残り時間(&T)：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPassedSubSecond);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblPassed);
            this.groupBox1.Location = new System.Drawing.Point(101, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 35);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // lblPassedSubSecond
            // 
            this.lblPassedSubSecond.AutoSize = true;
            this.lblPassedSubSecond.Location = new System.Drawing.Point(153, 15);
            this.lblPassedSubSecond.Name = "lblPassedSubSecond";
            this.lblPassedSubSecond.Size = new System.Drawing.Size(11, 12);
            this.lblPassedSubSecond.TabIndex = 4;
            this.lblPassedSubSecond.Text = "0";
            // 
            // btnOption
            // 
            this.btnOption.Location = new System.Drawing.Point(12, 98);
            this.btnOption.Name = "btnOption";
            this.btnOption.Size = new System.Drawing.Size(68, 20);
            this.btnOption.TabIndex = 9;
            this.btnOption.Text = "↓拡張(&O)";
            this.btnOption.UseVisualStyleBackColor = true;
            this.btnOption.Click += new System.EventHandler(this.btnOption_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(80, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "時";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(164, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "分";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(248, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "秒";
            // 
            // nudAbsHour
            // 
            this.nudAbsHour.Enabled = false;
            this.nudAbsHour.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudAbsHour.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.nudAbsHour.Location = new System.Drawing.Point(19, 38);
            this.nudAbsHour.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudAbsHour.Name = "nudAbsHour";
            this.nudAbsHour.Size = new System.Drawing.Size(55, 27);
            this.nudAbsHour.TabIndex = 12;
            this.nudAbsHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudAbsHour.Click += new System.EventHandler(this.numericUpDownEntered);
            this.nudAbsHour.Enter += new System.EventHandler(this.numericUpDownEntered);
            // 
            // nudAbsMinute
            // 
            this.nudAbsMinute.Enabled = false;
            this.nudAbsMinute.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudAbsMinute.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.nudAbsMinute.Location = new System.Drawing.Point(103, 38);
            this.nudAbsMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudAbsMinute.Name = "nudAbsMinute";
            this.nudAbsMinute.Size = new System.Drawing.Size(55, 27);
            this.nudAbsMinute.TabIndex = 14;
            this.nudAbsMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudAbsMinute.Click += new System.EventHandler(this.numericUpDownEntered);
            this.nudAbsMinute.Enter += new System.EventHandler(this.numericUpDownEntered);
            // 
            // nudAbsSecond
            // 
            this.nudAbsSecond.Enabled = false;
            this.nudAbsSecond.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudAbsSecond.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.nudAbsSecond.Location = new System.Drawing.Point(187, 38);
            this.nudAbsSecond.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudAbsSecond.Name = "nudAbsSecond";
            this.nudAbsSecond.Size = new System.Drawing.Size(55, 27);
            this.nudAbsSecond.TabIndex = 16;
            this.nudAbsSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudAbsSecond.Click += new System.EventHandler(this.numericUpDownEntered);
            this.nudAbsSecond.Enter += new System.EventHandler(this.numericUpDownEntered);
            // 
            // chkSetByAbsoluteTime
            // 
            this.chkSetByAbsoluteTime.AutoSize = true;
            this.chkSetByAbsoluteTime.Location = new System.Drawing.Point(6, 18);
            this.chkSetByAbsoluteTime.Name = "chkSetByAbsoluteTime";
            this.chkSetByAbsoluteTime.Size = new System.Drawing.Size(118, 16);
            this.chkSetByAbsoluteTime.TabIndex = 11;
            this.chkSetByAbsoluteTime.Text = "時刻でセットする(&A)";
            this.chkSetByAbsoluteTime.UseVisualStyleBackColor = true;
            this.chkSetByAbsoluteTime.CheckedChanged += new System.EventHandler(this.chkSetByAbsoluteTime_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNewWindow);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.nudBlink);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtMsg);
            this.groupBox2.Controls.Add(this.chkSetByAbsoluteTime);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.nudAbsHour);
            this.groupBox2.Controls.Add(this.nudAbsMinute);
            this.groupBox2.Controls.Add(this.nudAbsSecond);
            this.groupBox2.Location = new System.Drawing.Point(6, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 174);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "追加機能";
            // 
            // btnNewWindow
            // 
            this.btnNewWindow.Location = new System.Drawing.Point(193, 145);
            this.btnNewWindow.Name = "btnNewWindow";
            this.btnNewWindow.Size = new System.Drawing.Size(60, 23);
            this.btnNewWindow.TabIndex = 24;
            this.btnNewWindow.Text = "起動(&N)";
            this.btnNewWindow.UseVisualStyleBackColor = true;
            this.btnNewWindow.Click += new System.EventHandler(this.btnNewWindow_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 150);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(183, 12);
            this.label13.TabIndex = 23;
            this.label13.Text = "フラッシュタイマーをもうひとつ起動する：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(141, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 12);
            this.label12.TabIndex = 22;
            this.label12.Text = "ms";
            // 
            // nudBlink
            // 
            this.nudBlink.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudBlink.Location = new System.Drawing.Point(82, 119);
            this.nudBlink.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nudBlink.Minimum = new decimal(new int[] {
            350,
            0,
            0,
            0});
            this.nudBlink.Name = "nudBlink";
            this.nudBlink.Size = new System.Drawing.Size(58, 19);
            this.nudBlink.TabIndex = 21;
            this.nudBlink.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudBlink.Value = new decimal(new int[] {
            350,
            0,
            0,
            0});
            this.nudBlink.Click += new System.EventHandler(this.numericUpDownEntered);
            this.nudBlink.Enter += new System.EventHandler(this.numericUpDownEntered);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 12);
            this.label10.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 12);
            this.label11.TabIndex = 20;
            this.label11.Text = "点滅速度(&B)：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 12);
            this.label9.TabIndex = 18;
            this.label9.Text = "表示するメッセージ(&M)：";
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(19, 92);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(246, 19);
            this.txtMsg.TabIndex = 19;
            this.txtMsg.Text = "指定した時間になりました！！";
            // 
            // lblSubSecond
            // 
            this.lblSubSecond.AutoSize = true;
            this.lblSubSecond.Location = new System.Drawing.Point(270, 36);
            this.lblSubSecond.Name = "lblSubSecond";
            this.lblSubSecond.Size = new System.Drawing.Size(11, 12);
            this.lblSubSecond.TabIndex = 11;
            this.lblSubSecond.Text = "0";
            // 
            // FrmMain
            // 
            this.AcceptButton = this.btnStartStop;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(289, 123);
            this.Controls.Add(this.lblSubSecond);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnOption);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.nudSecond);
            this.Controls.Add(this.nudMinute);
            this.Controls.Add(this.nudHour);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "フラッシュタイマー";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.nudHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecond)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAbsHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAbsMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAbsSecond)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlink)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.NumericUpDown nudHour;
        private System.Windows.Forms.NumericUpDown nudMinute;
        private System.Windows.Forms.NumericUpDown nudSecond;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPassed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOption;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudAbsHour;
        private System.Windows.Forms.NumericUpDown nudAbsMinute;
        private System.Windows.Forms.NumericUpDown nudAbsSecond;
        private System.Windows.Forms.CheckBox chkSetByAbsoluteTime;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.NumericUpDown nudBlink;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnNewWindow;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblPassedSubSecond;
        private System.Windows.Forms.Label lblSubSecond;
    }
}

