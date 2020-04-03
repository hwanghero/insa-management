﻿using project.form_user;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace project
{
    public partial class main : Form
    {
        // 폼 저장 변수
        Form[] form_name = new Form[10];
        int form_count = 0;

        // 인사기초정보
        insainfo insainfo = new insainfo(); // 인사코드 관리
        form_user.insa_base.insa_department insa_department = new form_user.insa_base.insa_department(); // 부서코드 관리
        form_user.insa_base.insa_rank insa_rank = new form_user.insa_base.insa_rank(); // 직급코드 관리
        form_user.insa_base.insa_position insa_position = new form_user.insa_base.insa_position(); // 직책코드 관리

        // 인사기록관리
        insacontrol insacontrol = new insacontrol(); // 인사기본사항

        // 비밀번호 변경
        password_change password_chagne = new password_change();

        public main()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            for (int i = 0; i < form_name.Length - 1; i++)
                form_hide(form_name[i]);

            // 인사기초정보
            if (e.Node.Text.Equals("인사코드 관리"))
            {
                insainfo.Show();
            }
            if (e.Node.Text.Equals("부서코드 관리"))
            {
                insa_department.Show();
            }
            if (e.Node.Text.Equals("직급코드 관리"))
            {
                insa_rank.Show();
            }
            if (e.Node.Text.Equals("직책코드 관리"))
            {
                insa_position.Show();
            }

            // 인사기록관리
            if (e.Node.Text.Equals("인사기본사항"))
            {
                insacontrol.Show();
            }
            if (e.Node.Text.Equals("비밀번호 변경"))
            {
                password_chagne.Show();
            }
            this.Text = "인사관리프로그램 - " + e.Node.Text;
        }

        private void main_Load(object sender, EventArgs e)
        {
            // 인사기초정보
            main_add(insainfo);
            main_add(insa_department);
            main_add(insa_rank);
            main_add(insa_position);

            // 인사기록관리
            main_add(insacontrol);

            // 비번 변경
            main_add(password_chagne);

        }

        // 폼 추가
        public void main_add(Form addform)
        {
            addform.TopLevel = false;
            this.Controls.Add(addform);
            addform.Parent = this.panel1;
            addform.ControlBox = false;
            form_name[form_count] = addform;
            form_count++;
            Array.Resize(ref form_name, form_count + 1);
        }

        // 폼 숨기기
        public void form_hide(Form hideform)
        {
            hideform.Hide();
        }

        // 패널 사이즈 값 보내주기
        public Size panel_size()
        {
            return this.panel1.Size;
        }
    }
}
