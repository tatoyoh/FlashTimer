using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlashTimer {
    public partial class FrmMain : Form {
        public bool cantClose = false;//閉じるとアプリケーションが終わってしまうフォーム（はじめに開いたフォーム）の場合はtrue
        private DateTime startTime;//作動を開始した時刻
        private TimeSpan setTime;//セットした残り時間
        private TimeSpan havePassedTime;//累積既測定時間（現在測定中の時間を含まない）
        private DateTime stopTime;//一時停止した時刻

        private readonly Size SMALL_SIZE = new Size(305, 162); //初期ウインドウサイズ
        private readonly Size LARGE_SIZE = new Size(305, 353); //拡大時ウインドウサイズ

        public FrmMain() {
            InitializeComponent();
            cantClose = true;
        }
        /// <summary>
        /// 新しいタイマーを（高機能モードで）起動する。
        /// </summary>
        /// <param name="setByAbsoluteTime">時刻でセットするかどうか</param>
        /// <param name="message">表示するメッセージ</param>
        /// <param name="interval">点滅間隔</param>
        public FrmMain(bool setByAbsoluteTime, string message, int interval) {
            InitializeComponent();
            chkSetByAbsoluteTime.Checked = setByAbsoluteTime;
            txtMsg.Text = message;
            nudBlink.Value = interval;
            Size = LARGE_SIZE;
            btnOption.Text = "↑縮小";
        }

        //作動中にする
        private void start() {
            timer.Enabled = true;
            chkSetByAbsoluteTime.Enabled = nudAbsHour.Enabled = nudAbsMinute.Enabled = nudAbsSecond.Enabled
            = nudHour.Enabled = nudMinute.Enabled = nudSecond.Enabled = btnReset.Enabled = false;
            btnStartStop.Text = "ストップ";
        }
        //停止状態にする
        private void stop() {
            timer.Enabled = false;
            nudHour.Enabled = nudMinute.Enabled = nudSecond.Enabled = !(
            nudAbsHour.Enabled = nudAbsMinute.Enabled = nudAbsSecond.Enabled = chkSetByAbsoluteTime.Checked);
            chkSetByAbsoluteTime.Enabled= btnReset.Enabled = true;
            btnStartStop.Text = "スタート";
        }
        private void alarm() {
            (new Alert((int)nudBlink.Value,txtMsg.Text)).Show();
        }

        private void btnStartStop_Click(object sender, EventArgs e) {
            if (timer.Enabled) {
                //作動中(一時停止させる)
                stop();
                havePassedTime += DateTime.Now - startTime;
                stopTime = DateTime.Now;
            }
            else {
                //待機中(作動させる)
                if (nudHour.Value + nudMinute.Value + nudSecond.Value == 0 && !chkSetByAbsoluteTime.Checked) return;
                if (chkSetByAbsoluteTime.Checked) {
                //時刻で指定するときは残り時間に換算してスタート(継続測定はあり得ない)
                    DateTime goalTime = DateTime.Today;
                    goalTime += new TimeSpan((int)nudAbsHour.Value, (int)nudAbsMinute.Value, (int)nudAbsSecond.Value);
                    if (goalTime < DateTime.Now) {
                        goalTime+=new TimeSpan(1,0,0,0);
                    }
                    setTime = goalTime - DateTime.Now;
                }
                else {
                    setTime =
                        (setTime == new TimeSpan()) ?
                        new TimeSpan((int)nudHour.Value, (int)nudMinute.Value, (int)nudSecond.Value) :
                        setTime - (stopTime - startTime);//継続してスタートさせるときは秒以下も続きから
                }
                startTime = DateTime.Now;
                start();
            }
        }

        private void btnReset_Click(object sender, EventArgs e) {
            if (timer.Enabled) return;
            nudHour.Value = nudMinute.Value = nudSecond.Value = 0;
            lblSubSecond.Text = "0";
            lblPassedSubSecond.Text = "0";
            havePassedTime = new TimeSpan();
            setTime=new TimeSpan();
            lblPassed.Text = "00:00:00";
            Text = "フラッシュタイマー";
        }

        private void timer_Tick(object sender, EventArgs e) {
            TimeSpan _passed = DateTime.Now - startTime;
            if (_passed > setTime) {
                stop();
                alarm();
                setTime = new TimeSpan();
                nudHour.Value = nudMinute.Value = nudSecond.Value = 0;
                lblSubSecond.Text = "0";
                lblPassedSubSecond.Text = "0";
                havePassedTime = new TimeSpan();
                setTime=new TimeSpan();
                lblPassed.Text = "00:00:00";
                Text = "フラッシュタイマー";
                return;
            }
            TimeSpan remain = setTime - _passed;
            nudHour.Value = remain.Hours;
            nudMinute.Value = remain.Minutes;
            nudSecond.Value = remain.Seconds;
            lblSubSecond.Text=string.Format("{0:0}",remain.Milliseconds/100);
            _passed += havePassedTime;
            lblPassed.Text = string.Format("{0:hh}:{0:mm}:{0:ss}", new TimeSpan(_passed.Hours, _passed.Minutes, _passed.Seconds));
            lblPassedSubSecond.Text = string.Format("{0:0}", _passed.Milliseconds / 100);
            Text = string.Format("{0:hh}:{0:mm}:{0:ss}", new TimeSpan(remain.Hours, remain.Minutes, remain.Seconds));
        }

        private void btnOption_Click(object sender, EventArgs e) {
            if (Height < LARGE_SIZE.Height) {
                Size = new Size(Width, LARGE_SIZE.Height);
                btnOption.Text = "↑縮小";
            }
            else {
                Size = new Size(Width, SMALL_SIZE.Height);
                btnOption.Text = "↓拡張";
            }
        }

        private void chkSetByAbsoluteTime_CheckedChanged(object sender, EventArgs e) {
            nudHour.Enabled = nudMinute.Enabled = nudSecond.Enabled = !(
            nudAbsHour.Enabled = nudAbsMinute.Enabled = nudAbsSecond.Enabled = chkSetByAbsoluteTime.Checked);
        }

        private void btnNewWindow_Click(object sender, EventArgs e) {
            (new FrmMain(chkSetByAbsoluteTime.Checked, txtMsg.Text, (int)nudBlink.Value)).Show();
        }

        private void remainChanged(object sender, EventArgs e) {
            if(timer.Enabled)return;
            setTime = new TimeSpan();//（停止中に）残り時間を変更した場合は継続計測ではないのですでに測定した分の時間を解除
            lblSubSecond.Text = "0";
        }

        private void numericUpDownEntered(object sender, EventArgs e){
            ((NumericUpDown)sender).Select(0, 10);
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e) {
            if (cantClose && Application.OpenForms.Count >= 2) {
                this.Hide();
                e.Cancel = true;
            }
            else {
                int shownforms = 0;
                foreach (Form f in Application.OpenForms) {
                    if (f.Visible) shownforms++;
                }
                if (shownforms == 1) {
                    foreach (Form f in Application.OpenForms) {
                        ((FrmMain)f).cantClose = false;
                    }
                }
            }
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e) {
            int shownforms = 0;
            foreach (Form f in Application.OpenForms) {
                if (f.Visible) shownforms++;
            }
            if (shownforms == 0) Application.Exit();
        }
    }
}