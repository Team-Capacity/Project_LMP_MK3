using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace LMP_Projcet.Methods
{
    class FormChange
    {

        public void ChangeFIF(Form f, Panel p)
        {
            p.Controls.Clear(); // Panel 속 폼을 클리어
            f.TopLevel = false;
            p.Controls.Add(f);
            f.Show();
            f.Dock = DockStyle.Fill;
        }

        public void ChangeF(Form nowF, Form nextF)
        {
            nowF.Hide();
            nextF.Show();
        }

        public void ChangeBorder(GroupBoxBorderChagne g)
        {
            // 색을 나중엔 배경색으로 변경할 생각으로 수정 필요
            g.BorderColor = Color.White;
        }

        public void fromColorChange(Label[] back, Label[] font, Panel[] title)
        {
            for (int i = 0; i < back.Length; i++)
            {
                back[i].BackColor = LoginForm.backColor;
            }
            for (int i = 0; i < font.Length; i++)
            {
                font[i].ForeColor = LoginForm.fontColor;
            }
            for (int i = 0; i < title.Length; i++)
            {
                title[i].BackColor = LoginForm.titleColor;
            }
        }
        public void fromColorChange(Label[] back, Label[] font)
        {
            for (int i = 0; i < back.Length; i++)
            {
                back[i].BackColor = LoginForm.backColor;
            }
            for (int i = 0; i < font.Length; i++)
            {
                font[i].ForeColor = LoginForm.fontColor;
            }
        }

        public void fromBColorChange(Label[] back)
        {
            for (int i = 0; i < back.Length; i++)
            {
                back[i].BackColor = LoginForm.backColor;
            }
        }
        public void fromFColorChange(Label[] font)
        {
            for (int i = 0; i < font.Length; i++)
            {
                font[i].ForeColor = LoginForm.fontColor;
            }
        }

        public void fromColorChange(Form form)
        {
            form.BackColor = LoginForm.backColor;
        }

        public void fromColorChange(GroupBox group)
        {
            group.BackColor = LoginForm.backColor;
            group.ForeColor = LoginForm.fontColor;
        }

        public void fromColorChange(TabControl tab)
        {
            for(int i = 0; i< tab.TabPages.Count; i++)
            {
                tab.TabPages[i].BackColor = LoginForm.backColor;
                tab.TabPages[i].ForeColor = LoginForm.fontColor;
            }
        }


    }
}
