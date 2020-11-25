﻿using DKClinic.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DKClinic.Customer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // 가운데 패널의 컨트롤 컬렉터의 별칭을 지정
            MainControl = pnlMain.Controls;

            // 처음 시작시에는 Top, Bottom툴바 출력 안하게
            pnlTop.Visible = false;
            pnlBottom.Visible = false;

            // 시작 화면인 로그인 화면(ctmLogin)출력
            ctmLogin login = new ctmLogin();
            CallUserControl(login);
        }

        public Data.Customer ConnectedCustomer { get; set; }
        public Questionnare CreatedQuestionnare { get; set; }
        public Control.ControlCollection MainControl { get; set; }

        public void CallUserControl(BaseUC control)
        {
            if (MainControl.Count > 0)
                MainControl.Clear();

            control.Dock = DockStyle.Fill;
            MainControl.Add(control);
            lblTitle.Text = control.Title;
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            if (MainControl.Count > 0)
                MainControl.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
        }

        public void event1(EventArgs e)
        {
            // 고객 정보를 저장하자
            ConnectedCustomer = new Data.Customer();

            // Top, Bottom툴바 출력
            pnlTop.Visible = false;
            pnlBottom.Visible = false;

            // 하단에 접속된 고객 이름 출력
            lblStatus.Text = "고객 " + ConnectedCustomer.Name + "님 로그인중...";

            // inputDetail 불러오자
            CallUserControl(new BaseUC());
        }

        public void event2(EventArgs e)
        {
            // 고객 정보를 저장하자
            ConnectedCustomer = new Data.Customer();

            // depChoice 불러오자
            CallUserControl(new BaseUC());
        }
    }
}
