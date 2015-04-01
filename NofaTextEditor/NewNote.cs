using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Security.Cryptography;

namespace NofaTextEditor
{
    public partial class NewNote : Form
    {
        string id;
        Parameters parameters = new Parameters();

        public NewNote()
        {
            InitializeComponent();
        }
        public NewNote(string id = "1")
        {
            InitializeComponent();
            this.id = id;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string title = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(textBox1.Text));
            string newNoteResponse = parameters.makeHttpRequest("/new_note", "title=" + WebUtility.UrlEncode(title) + "&user-key=" + WebUtility.UrlEncode(parameters.getPublickey()) +
                "&signature=" + WebUtility.UrlEncode(parameters.makeSignature(title)));
            dynamic parsedNewNoteResponse = Newtonsoft.Json.JsonConvert.DeserializeObject(newNoteResponse);
            //System.Diagnostics.Debugger.Break();
            if (parsedNewNoteResponse["status"] == "ok")
            {
                this.Close();
                string noteId = parsedNewNoteResponse["noteId"];
                NoteEditor form1 = new NoteEditor(noteId);
                form1.Show();
            }
            else
            {
                MessageBox.Show(newNoteResponse);
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
