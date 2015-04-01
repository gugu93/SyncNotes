using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Net;
using System.IO;
using System.Windows.Forms;

namespace NofaTextEditor
{
    class Parameters
    {
        private string ServerAddress = "http://rozalka.otwiera.cz";
        private string Port = "5000";
        public string Url;
        public string Keyfile = "E:\\syncnotes-keyfile.pem";
        public DSACryptoServiceProvider dsa;

        public Parameters()
        {
            dsa = new DSACryptoServiceProvider();
            Url = ServerAddress + ":" + Port;
            if (!check_dsafile())
            {
                generatedsa();
            }
            dsa.ImportCspBlob(Convert.FromBase64String(File.ReadAllText(Keyfile)));
        }

        public string getKeypair()
        {
            return Convert.ToBase64String(dsa.ExportCspBlob(true));
        }

        public string getPublickey()
        {
            // MessageBox.Show(Convert.ToBase64String(dsa.ExportCspBlob(false))+"<END>");
            return Convert.ToBase64String(dsa.ExportCspBlob(false));
        }

        public void generatedsa()
        {
            var dsa = new DSACryptoServiceProvider();
            byte[] binarypublikey = dsa.ExportCspBlob(true);
            string s;
            s = Convert.ToBase64String(binarypublikey);
            File.WriteAllText(Keyfile, s);
        }

        public bool check_dsafile()
        {
            if (File.Exists(Keyfile) == true)
            {
                return true;
            }
            else return false;
        }

        public string makeHttpRequest(string endpoint, string requestParameters)
        {
            HttpWebRequest HttpWReq = (HttpWebRequest)WebRequest.Create(Url + endpoint);

            HttpWReq.Method = "POST";
            HttpWReq.ContentType = "application/x-www-form-urlencoded";

            byte[] request_data = System.Text.Encoding.UTF8.GetBytes(requestParameters);
            HttpWReq.ContentLength = request_data.Length;

            Stream newStream = HttpWReq.GetRequestStream();
            newStream.Write(request_data, 0, request_data.Length);
            newStream.Close();

            WebResponse myresposne = HttpWReq.GetResponse();
            StreamReader sr = new StreamReader(myresposne.GetResponseStream(), System.Text.Encoding.UTF8);
            string result = sr.ReadToEnd();
            sr.Close();
            myresposne.Close();
            return result;
        }

        public string makeSignature(string message)
        {
            var sha1 = SHA1.Create();
            string signature = Convert.ToBase64String(dsa.CreateSignature(sha1.ComputeHash(System.Text.Encoding.UTF8.GetBytes(message))));
            return signature;
        }
    }
}
