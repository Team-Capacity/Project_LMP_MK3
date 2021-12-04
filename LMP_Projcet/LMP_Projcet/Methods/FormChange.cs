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

    }
}
