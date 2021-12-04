using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace LibraryMgrProgram
{
    class MouseEvent
    {
        // 상단바로 폼 이동 시키기
        private bool isMove = false;
        private Point fpt;

        public void PlanMouseMove(MouseEventArgs e, Form f)
        {
            if (isMove && (e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                f.Location = new Point(f.Left - (fpt.X - e.X), f.Top - (fpt.Y - e.Y));
            }
        }

        public void PlanMouseDown(MouseEventArgs e)
        {
            // 클릭시 움직이도록
            isMove = true;
            // 클릭시 해당 마우스 위치 저장
            fpt = new Point(e.X, e.Y);
        }

        public void PlanMouseUp()
        {
            isMove = false;
        }

        //상단바 닫기 버튼
        public void ButtonClose(Form f)
        {
            f.Close();
        }

        // 상단바 최대화 버튼
        public void FormMaxSize(Form f)
        {
            if (f.WindowState == FormWindowState.Maximized)
            {
                f.WindowState = FormWindowState.Normal;
            }
            else
            {
                f.WindowState = FormWindowState.Maximized;
            }
        }

        public void FormMinSize(Form f)
        {
            f.WindowState = FormWindowState.Minimized;
        }
    }
}
