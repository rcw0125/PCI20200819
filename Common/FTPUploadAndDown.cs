using DevExpress.Utils.OAuth.Provider;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace Common
{
    /// <summary>
    /// 2018-04-25 zmc
    /// </summary>
    public class FTPUploadAndDown
    {
        public static string ftpServer = "ftp://192.168.2.96/Pdf";
        public static string ftpUserID = "xgcap";
        public static string ftpPassword = "Admin2018";


        /// <summary>
        /// 用ftp下载文件到本地指定目录
        /// </summary>
        /// <param name="fileName">文件名</param>
        /// <param name="downloadUrl">下载到本地的文件夹路径</param>
        public static void down(string fileName, string downloadUrl)
        {

            //string downloadUrl = "E:/和兴软件项目/download";//C:\Users
            string userId = Environment.UserName;
            // string downloadUrl = System.IO.Directory.GetCurrentDirectory().Replace("\\", "/") ;


            //需要下载的文件名  
            // string fileName = "导入数据格式.xlsx";
            //需要现在的文件在ftp上的完整路径  
            // string fileUploadPath = "ftp://192.168.2.96/Pdf";
            Uri uri = new Uri(ftpServer + fileName);
            //下载后存放的路径  
            string FileName = Path.GetFullPath(downloadUrl) + Path.DirectorySeparatorChar.ToString() + Path.GetFileName(uri.LocalPath);

            //创建文件流  
            FileStream fs = null;
            Stream responseStream = null;
            try
            {
                //创建一个与FTP服务器联系的FtpWebRequest对象  
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(uri);
                //设置请求的方法是FTP文件下载  
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                //连接登录FTP服务器  
                request.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
                //获取一个请求响应对象  
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                //获取请求的响应流  
                responseStream = response.GetResponseStream();
                //判断本地文件是否存在，如果存在，则打开和重写本地文件  
                if (File.Exists(FileName))
                {
                    fs = File.Open(FileName, FileMode.Open, FileAccess.ReadWrite);
                }
                else
                {
                    fs = File.Create(FileName);
                }

                if (fs != null)
                {
                    int buffer_count = 65536;
                    byte[] buffer = new byte[buffer_count];
                    int size = 0;
                    while ((size = responseStream.Read(buffer, 0, buffer_count)) > 0)
                    {
                        fs.Write(buffer, 0, size);
                    }
                    fs.Flush();
                    fs.Close();
                    responseStream.Close();
                }
            }
            finally
            {
                if (fs != null)
                    fs.Close();
                if (responseStream != null)
                    responseStream.Close();
            }
        }


        #region 上传文件

        /// <summary>
        /// ftp上传后的文件名
        /// </summary>
        /// <param name="fileNamePath"></param>
        /// <returns></returns>
        public static string GetNewFileName(string fileNamePath)
        {
            DateTime serviecdt =RV.UI.ServerTime.timeNow();
            return serviecdt.ToString("yyMMddHHmmss") + serviecdt.Millisecond.ToString() ;
        }
        /// <summary>
        /// pdf上传文件
        /// </summary>
        /// <param name="localfile">本地文件路径</param>
        /// <param name="newfileName">上传生成后的文件名</param>
        /// <returns></returns>
        public static string ftpUploadFile(string localfile, string newfileName)
        {
            try
            {
                string ftpPath = "ftp://192.168.2.96/Pdf";
                FileInfo fileInf = new FileInfo(localfile);
                FtpWebRequest reqFTP;

                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(string.Format("{0}/{1}", ftpPath, newfileName)));
                reqFTP.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
                reqFTP.KeepAlive = false;
                reqFTP.Method = WebRequestMethods.Ftp.UploadFile;
                reqFTP.UseBinary = true;
                reqFTP.ContentLength = fileInf.Length;
                int buffLength = 2048;
                byte[] buff = new byte[buffLength];
                int contentLen;
                FileStream fs = fileInf.OpenRead();
                Stream strm = reqFTP.GetRequestStream();
                contentLen = fs.Read(buff, 0, buffLength);
                while (contentLen != 0)
                {
                    strm.Write(buff, 0, contentLen);
                    contentLen = fs.Read(buff, 0, buffLength);
                }
                strm.Close();
                fs.Close();

                return "1";
            }
            catch (Exception)
            {

                return "0";
            }
        }


        #endregion

        #region 上传文件夹

        /// <summary>  
        /// 判断ftp服务器上该目录是否存在  
        /// </summary>  
        /// <param name="ftpPath">FTP路径目录</param>  
        /// <param name="dirName">目录上的文件夹名称</param>  
        /// <returns></returns>  
        private bool CheckDirectoryExist(string ftpPath, string dirName)
        {
            bool flag = true;
            try
            {
                //实例化FTP连接  
                FtpWebRequest ftp = (FtpWebRequest)FtpWebRequest.Create(ftpPath + dirName);
                ftp.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
                ftp.Method = WebRequestMethods.Ftp.ListDirectory;
                FtpWebResponse response = (FtpWebResponse)ftp.GetResponse();
                response.Close();
            }
            catch (Exception)
            {
                flag = false;
            }
            return flag;
        }

        /// <summary>  
        /// 创建文件夹    
        /// </summary>    
        /// <param name="ftpPath">FTP路径</param>    
        /// <param name="dirName">创建文件夹名称</param>    
        public string MakeDir(string ftpPath, string dirName)
        {

            FtpWebRequest reqFTP;
            try
            {
                string ui = (ftpPath + dirName).Trim();
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(ui);
                reqFTP.Method = WebRequestMethods.Ftp.MakeDirectory;
                reqFTP.UseBinary = true;
                reqFTP.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                Stream ftpStream = response.GetResponseStream();
                ftpStream.Close();
                response.Close();
                return "1";
            }

            catch (Exception ex)
            {
                return "0";
            }

        }

        /// <summary>  
        /// 获取目录下的详细信息  
        /// </summary>  
        /// <param name="localDir">本机目录</param>  
        /// <returns></returns>  
        private List<List<string>> GetDirDetails(string localDir)
        {
            List<List<string>> infos = new List<List<string>>();
            try
            {
                infos.Add(Directory.GetFiles(localDir).ToList()); //获取当前目录的文件  

                infos.Add(Directory.GetDirectories(localDir).ToList()); //获取当前目录的目录  

                for (int i = 0; i < infos[0].Count; i++)
                {
                    int index = infos[0][i].LastIndexOf(@"\");
                    infos[0][i] = infos[0][i].Substring(index + 1);
                }
                for (int i = 0; i < infos[1].Count; i++)
                {
                    int index = infos[1][i].LastIndexOf(@"\");
                    infos[1][i] = infos[1][i].Substring(index + 1);
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return infos;
        }


        /// <summary>
        /// 删除文件
        /// </summary>
        /// <param name="fileName"></param>
        public static string Delete(string fileName)
        {
            try
            {
                string ftpPath = "ftp://192.168.2.96/Pdf";
                string uri = ftpPath + fileName;
                FtpWebRequest reqFTP;
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(uri));

                reqFTP.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
                reqFTP.KeepAlive = false;
                reqFTP.Method = WebRequestMethods.Ftp.DeleteFile;

                string result = String.Empty;
                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                long size = response.ContentLength;
                Stream datastream = response.GetResponseStream();
                StreamReader sr = new StreamReader(datastream);
                result = sr.ReadToEnd();
                sr.Close();
                datastream.Close();
                response.Close();
            }
            catch (Exception ex)
            {
                return "删除失败 --> " + ex.Message + "  文件名:" + fileName;
            }

            return string.Empty;
        }


        #endregion

    }
}
