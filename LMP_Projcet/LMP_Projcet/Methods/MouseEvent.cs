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

        public void ImageUpload(PictureBox imageBox)
        {
            //이미지를 담기 위한 변수
            string imageFile = string.Empty;
            //이미지 선택을 위한 다이얼로그
            OpenFileDialog dialog = new OpenFileDialog();
            //다이얼로그 시작위치 설정
            dialog.InitialDirectory = "C:\\";
            dialog.Title = "이미지 선택창";
            dialog.Filter = "이미지 파일 (*.jpg) | *.jpg; |모든 파일 (*.*) | *.*";
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    imageFile = dialog.FileName;
                }catch(Exception e)
                {
                    MessageBox.Show("불러오기 도중 에러가 발생하였습니다.");
                }
            }
            else
            {
                try
                {
                    return;
                }
                catch (Exception e)
                {
                    MessageBox.Show("취소 도중 에러가 발생하였습니다.");
                }
            }

            imageBox.Image = Bitmap.FromFile(imageFile);
            imageBox.SizeMode = PictureBoxSizeMode.StretchImage;
            
        }

        public void ImageSave(PictureBox imageBox)
        {
            // 이미지 저장 경로
            string savePath = "~~~";
            // 해당 경로에 디렉토리가 있는지 확인
            if (!System.IO.Directory.Exists(savePath))
            {
                //만약 지정 경로에 디렉토리가 없다면 만들고 있다면 만들지 않기
                System.IO.Directory.CreateDirectory(savePath);
                // PictureBox의 이미지를 저장(경로+ "\\저장이미지이름"+이미지 포맷)
                imageBox.Image.Save(savePath + "\\" + imageBox.Name, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }

    }
}
