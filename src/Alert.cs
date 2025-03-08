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
        /// ��ʂ�_�ł����Ďw�莞�����������Ƃ�m�点�܂��B
        /// </summary>
        /// <param name="interval">�~���b�Ŏw�肵���_�ŊԊu�B</param>
        /// <param name="message">�\�����郁�b�Z�[�W�B</param>
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