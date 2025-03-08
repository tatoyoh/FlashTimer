using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlashTimer {
    public partial class Alert : Form {
        int i=0;
        /// <summary>
        /// 画面を点滅させて指定時刻が来たことを知らせます。
        /// </summary>
        /// <param name="interval">ミリ秒で指定した点滅間隔。</param>
        /// <param name="message">表示するメッセージ。</param>
        public Alert(int interval,string message) {
            InitializeComponent();
            lblAlert.Text = message;
            timer.Interval = interval;
            timer.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e) {
            switch (i++) {
                case 0:
                    BackColor = Color.Cyan;
                    break;
                case 1:
                    BackColor = Color.Yellow;
                    break;
                case 2:
                    BackColor = Color.Lime;
                    i = 0;
                    break;
            }
        }

        private void btnOK_Click(object sender, EventArgs e) {
            Dispose();
        }

    }
}