using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LMP_Projcet.Methods
{
    class FTPManager
    {
        public delegate void ExceptionEventHandler(string LocationID, Exception ex);

        public event ExceptionEventHandler ExceptionEvent;
        public Exception LastException = null;
        public bool IsConnected { get; set; }

        private string ipAddr = string.Empty;
        private string port = string.Empty;
        private string userId = string.Empty;
        private string pwd = string.Empty;

        public FTPManager()
        {

        }

        // 파일을 전송한 서버와 연결
        public bool ConnectToServer(string ip, string port, string userId, string pwd)
        {
            this.IsConnected = false;
            this.ipAddr = ip;
            this.port = port;
            this.userId = userId;
            this.pwd = pwd;

            string url = string.Format(@"FTP://{0}:{1}/", this.ipAddr, this.port);
            try
            {
                FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create(url);
                ftpRequest.Credentials = new NetworkCredential(userId, pwd);
                ftpRequest.KeepAlive = false;
                ftpRequest.Method = WebRequestMethods.Ftp.ListDirectory;
                ftpRequest.UsePassive = false;

                using (ftpRequest.GetResponse())
                {

                }
                this.IsConnected = true;
            }
            catch (Exception ex)
            {
                this.LastException = ex;
                System.Reflection.MemberInfo info = System.Reflection.MethodInfo.GetCurrentMethod();
                string id = string.Format("{0}.{1}", info.ReflectedType.Name, info.Name);

                if (this.ExceptionEvent != null)
                    this.ExceptionEvent(id, ex);
                return false;
            }
            return true;
        }

        public bool UpLoad(string folder, string filename)
        {
            return upload(folder, filename);
        }



        /// <summary>
        /// 파일 업로드
        /// </summary>
        /// <param name="folder"></param>
        /// <param name="filename"></param>
        /// <returns></returns>

        private bool upload(string folder, string filename)
        {
            try
            {
                makeDir(folder);
                FileInfo fileInf = new FileInfo(filename);

                folder = folder.Replace('\\', '/');
                filename = filename.Replace('\\', '/');
                string url = string.Format(@"FTP://{0}:{1}/{2}{3}", this.ipAddr, this.port, folder, fileInf.Name);
                FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create(url);
                ftpRequest.Credentials = new NetworkCredential(userId, pwd);
                ftpRequest.KeepAlive = false;
                ftpRequest.UseBinary = false;
                ftpRequest.UsePassive = false;
                ftpRequest.Method = WebRequestMethods.Ftp.UploadFile;
                ftpRequest.ContentLength = fileInf.Length;
                int buffLength = 2048;
                byte[] buff = new byte[buffLength];
                int contentLen;

                using (FileStream fs = fileInf.OpenRead())
                {
                    using (Stream strm = ftpRequest.GetRequestStream())
                    {
                        contentLen = fs.Read(buff, 0, buffLength);
                        while (contentLen != 0)
                        {
                            strm.Write(buff, 0, contentLen);
                            contentLen = fs.Read(buff, 0, buffLength);
                        }
                    }
                    fs.Flush();
                    fs.Close();
                }
                if (buff != null)
                {
                    Array.Clear(buff, 0, buff.Length);
                    buff = null;
                }
            }
            catch (Exception ex)
            {
                this.LastException = ex;
                System.Reflection.MemberInfo info = System.Reflection.MethodInfo.GetCurrentMethod();
                string id = string.Format("{0}.{1}", info.ReflectedType.Name, info.Name);
                if (this.ExceptionEvent != null)
                    this.ExceptionEvent(id, ex);
                return false;
            }
            return true;
        }

        private void makeDir(string dirName)
        {
            string[] arrDir = dirName.Split('\\');
            string currentDir = string.Empty;

            try {
                foreach (string tmpFoler in arrDir){
                    try{
                        if (tmpFoler == string.Empty) continue;
                        currentDir += @"/" + tmpFoler;
                        string url = string.Format(@"FTP://{0}:{1}{2}", this.ipAddr, this.port, currentDir);

                        FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create(url);
                        ftpRequest.Credentials = new NetworkCredential(userId, pwd);
                        ftpRequest.Method = WebRequestMethods.Ftp.MakeDirectory;
                        ftpRequest.KeepAlive = false;
                        ftpRequest.UsePassive = false;
                        FtpWebResponse response = (FtpWebResponse)ftpRequest.GetResponse();
                        response.Close();
                    }
                    catch { }
                }
            }
            catch (Exception ex){
                this.LastException = ex;
                System.Reflection.MemberInfo info = System.Reflection.MethodInfo.GetCurrentMethod();
                string id = string.Format("{0}.{1}", info.ReflectedType.Name, info.Name);

                if (this.ExceptionEvent != null)
                    this.ExceptionEvent(id, ex);
            }
        }

        private void checkDir(string localFullPathFile){
            FileInfo fInfo = new FileInfo(localFullPathFile);
            if (!fInfo.Exists)
            {
                DirectoryInfo dInfo = new DirectoryInfo(fInfo.DirectoryName);
                if (!dInfo.Exists) {
                    dInfo.Create();
                }
            }
        }




        /*        public void ImageSaveFTP(PictureBox imageBox, string saveName)
                {

                }

                private FtpWebResponse Connect(String url, string method, Action<FtpWebRequest> action = null)
                {
                    // WebRequest 클래스를 이용해 접속하기 때문에 객체를 가져온다. (FtpWebRequest로 변환)
                    var request = WebRequest.Create(url) as FtpWebRequest;
                    // Binary 형식으로 사용한다.
                    request.UseBinary = true;
                    // FTP 메소드 설정(아래에 별도 설명)
                    request.Method = method;
                    // 로그인 인증
                    request.Credentials = new NetworkCredential(db.Id, db.Pwd);
                    // request.GetResponse()함수가 호출되면 실제적으로 접속이 되기 때문에, 그전에 설정할 callback 함수 호출
                    if (action != null)
                    {
                        action(request);
                    }
                    // 접속해서 WebResponse함수를 가져온다.
                    return request.GetResponse() as FtpWebResponse;
                }

                //파일 업로드
                private void UploadFileList(String url, string source)
                {
                    using (var fs = File.OpenRead(source))
                    {
                        // 파일을 업로드한다.
                        Connect(url, WebRequestMethods.Ftp.UploadFile, (req) =>
                        {
                            // 파일 크기 설정
                            req.ContentLength = fs.Length;
                            // GetResponse()가 호출되기 전에 request스트림에 파일 binary를 넣는다.
                            using (var stream = req.GetRequestStream())
                            {
                                fs.CopyTo(stream);
                            }
                        }).Close();
                        // respose 객체를 닫는다.
                    }
                }*/


/*        public void ImageSaveFTP(PictureBox imageBox, string saveName)
        {
            string savePath = "ftp://" + db.Server + db.Port + @"/home/pi/LMP/BookImage";
            string uploadFile = saveName + ".jpeg";
            FtpWebRequest req = (FtpWebRequest)WebRequest.Create(savePath);
            req.Method = WebRequestMethods.Ftp.UploadFile;
            req.Credentials = new NetworkCredential(db.Id, db.Pwd);

            byte[] data;
            using (StreamReader reader = new StreamReader(uploadFile))
            {
                data = Encoding.UTF8.GetBytes(reader.ReadToEnd());
            }

            req.ContentLength = data.Length;
            using (Stream reqStream = req.GetRequestStream())
            {
                reqStream.Write(data, 0, data.Length);
            }

            using (FtpWebResponse resp = (FtpWebResponse)req.GetResponse())
            {
                MessageBox.Show("Upload: {0}", resp.StatusDescription);
            }

        }*/
    }



}
