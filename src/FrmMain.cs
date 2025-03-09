using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlashTimer {
    public partial class FrmMain : Form {
        public bool cantClose = false;//����ƃA�v���P�[�V�������I����Ă��܂��t�H�[���i�͂��߂ɊJ�����t�H�[���j�̏ꍇ��true
        private DateTime startTime;//�쓮���J�n��������
        private TimeSpan setTime;//�Z�b�g�����c�莞��
        private TimeSpan havePassedTime;//�ݐϊ����莞�ԁi���ݑ��蒆�̎��Ԃ��܂܂Ȃ��j
        private DateTime stopTime;//�ꎞ��~��������

        private readonly Size SMALL_SIZE = new Size(305, 162); //�����E�C���h�E�T�C�Y
        private readonly Size LARGE_SIZE = new Size(305, 353); //�g�厞�E�C���h�E�T�C�Y

        public FrmMain() {
            InitializeComponent();
            cantClose = true;
        }
        /// <summary>
        /// �V�����^�C�}�[���i���@�\���[�h�Łj�N������B
        /// </summary>
        /// <param name="setByAbsoluteTime">�����ŃZ�b�g���邩�ǂ���</param>
        /// <param name="message">�\�����郁�b�Z�[�W</param>
        /// <param name="interval">�_�ŊԊu</param>
        public FrmMain(bool setByAbsoluteTime, string message, int interval) {
            InitializeComponent();
            chkSetByAbsoluteTime.Checked = setByAbsoluteTime;
            txtMsg.Text = message;
            nudBlink.Value = interval;
            Size = LARGE_SIZE;
            btnOption.Text = "���k��";
        }

        //�쓮���ɂ���
        private void start() {
            timer.Enabled = true;
            chkSetByAbsoluteTime.Enabled = nudAbsHour.Enabled = nudAbsMinute.Enabled = nudAbsSecond.Enabled
            = nudHour.Enabled = nudMinute.Enabled = nudSecond.Enabled = btnReset.Enabled = false;
            btnStartStop.Text = "�X�g�b�v";
        }
        //��~��Ԃɂ���
        private void stop() {
            timer.Enabled = false;
            nudHour.Enabled = nudMinute.Enabled = nudSecond.Enabled = !(
            nudAbsHour.Enabled = nudAbsMinute.Enabled = nudAbsSecond.Enabled = chkSetByAbsoluteTime.Checked);
            chkSetByAbsoluteTime.Enabled= btnReset.Enabled = true;
            btnStartStop.Text = "�X�^�[�g";
        }
        private void alarm() {
            (new Alert((int)nudBlink.Value,txtMsg.Text)).Show();
        }

        private void btnStartStop_Click(object sender, EventArgs e) {
            if (timer.Enabled) {
                //�쓮��(�ꎞ��~������)
                stop();
                havePassedTime += DateTime.Now - startTime;
                stopTime = DateTime.Now;
            }
            else {
                //�ҋ@��(�쓮������)
                if (nudHour.Value + nudMinute.Value + nudSecond.Value == 0 && !chkSetByAbsoluteTime.Checked) return;
                if (chkSetByAbsoluteTime.Checked) {
                //�����Ŏw�肷��Ƃ��͎c�莞�ԂɊ��Z���ăX�^�[�g(�p������͂��蓾�Ȃ�)
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
                        setTime - (stopTime - startTime);//�p�����ăX�^�[�g������Ƃ��͕b�ȉ�����������
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
            Text = "�t���b�V���^�C�}�[";
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
                Text = "�t���b�V���^�C�}�[";
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
                btnOption.Text = "���k��";
            }
            else {
                Size = new Size(Width, SMALL_SIZE.Height);
                btnOption.Text = "���g��";
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
            setTime = new TimeSpan();//�i��~���Ɂj�c�莞�Ԃ�ύX�����ꍇ�͌p���v���ł͂Ȃ��̂ł��łɑ��肵�����̎��Ԃ�����
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