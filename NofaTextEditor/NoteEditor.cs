using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using mshtml;
using System.Net;

namespace NofaTextEditor
{
    public partial class NoteEditor : Form
    {
        public string id;
        public string title;
        public string content;
        private bool loaded = false;
        private IHTMLDocument2 doc;
        Parameters parameters = new Parameters();

        public NoteEditor()
        {
            InitializeComponent();
        }
      
        public NoteEditor(string id)
        {
            InitializeComponent();
            string noteRequest = parameters.makeHttpRequest("/get_note", "note-id=" + id + "&user-key=" + WebUtility.UrlEncode(parameters.getPublickey()) +
                "&signature=" + WebUtility.UrlEncode(parameters.makeSignature(id)));
            dynamic parseNoteResponse = Newtonsoft.Json.JsonConvert.DeserializeObject(noteRequest);
            string status = parseNoteResponse["status"];

            this.id = id;
            if (status == "ok")
            {
                //System.Diagnostics.Debugger.Break();
                this.title = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(parseNoteResponse["noteTitle"].ToString()));
                this.content = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(parseNoteResponse["noteContent"].ToString()));
                this.loaded = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Make the web 'browser' an editable HTML field
            //HTMLEditor.DocumentText = "<html><body></body></html>";
            //if (loaded)
            //{
            //    HTMLEditor.DocumentText = this.content;
            //}
            //else
            //{
            //HTMLEditor.DocumentText = "<html><body></body></html>"; //This will get our HTML editor ready, inserting common HTML blocks into the document
            // "<!DOCTYPE HTML PUBLIC \"-//W3C//DTD HTML 4.0 Transitional//EN\">\r\n<HTML><HEAD>\r\n<META content=\"text/html; charset=unicode\" http-equiv=Content-Type>\r\n<META name=GENERATOR content=\"MSHTML 11.00.9600.17107\"></HEAD>\r\n<BODY>Dupa blada.</BODY></HTML>\r\n"
            //}
            // System.Diagnostics.Debugger.Break();
            doc = HTMLEditor.Document.DomDocument as IHTMLDocument2;
            doc.write(this.content);
            doc.designMode = "On";

            //What we just did was make our web browser editable!

        }

        private void BoldButton_Click(object sender, EventArgs e)
        {
            HTMLEditor.Document.ExecCommand("Bold", false, null);
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Debugger.Break();
            string content64 = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(HTMLEditor.DocumentText));
            string title64 = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(this.title));
            string result = parameters.makeHttpRequest("/save_note", "note-id=" + this.id + "&title=" + WebUtility.UrlEncode(title64) + "&content=" + WebUtility.UrlEncode(content64) +
                "&user-key=" + WebUtility.UrlEncode(parameters.getPublickey()) + "&signature=" + WebUtility.UrlEncode(parameters.makeSignature(this.id + this.title + this.content)));
            dynamic parsedResult = Newtonsoft.Json.JsonConvert.DeserializeObject(result);
            if (parsedResult["status"] != "ok")
            {
                MessageBox.Show("Error: " + parsedResult["status"]);
            }
        }

        private void ItalicButton_Click(object sender, EventArgs e)
        {
            HTMLEditor.Document.ExecCommand("Italic", false, null);
        }

        private void UnderlineButton_Click(object sender, EventArgs e)
        {
            HTMLEditor.Document.ExecCommand("Underline", false, null);
        }

        private void CutButton_Click(object sender, EventArgs e)
        {
            HTMLEditor.Document.ExecCommand("Cut", false, null);
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            HTMLEditor.Document.ExecCommand("Copy", false, null);
        }

        private void PasteButton_Click(object sender, EventArgs e)
        {
            HTMLEditor.Document.ExecCommand("Paste", false, null);
        }

        private void AlignLeft_Click(object sender, EventArgs e)
        {
            HTMLEditor.Document.ExecCommand("JustifyLeft", false, null);
        }

        private void AlignRight_Click(object sender, EventArgs e)
        {
            HTMLEditor.Document.ExecCommand("JustifyRight", false, null);
        }

        private void AlignCenter_Click(object sender, EventArgs e)
        {
            HTMLEditor.Document.ExecCommand("JustifyCenter", false, null);
        }

        private void Justify_Click(object sender, EventArgs e)
        {
            HTMLEditor.Document.ExecCommand("JustifyFull", false, null);
        }

        private void InsertOrderedList_Click(object sender, EventArgs e)
        {
            HTMLEditor.Document.ExecCommand("InsertOrderedList", false, null);
        }

        private void InsertUnorderedList_Click(object sender, EventArgs e)
        {
            HTMLEditor.Document.ExecCommand("InsertUnorderedList", false, null);
        }
        
    }
}
