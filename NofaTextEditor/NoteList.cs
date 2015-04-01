using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using mshtml;
using System.Security.Cryptography;

namespace NofaTextEditor
{

    public partial class NoteList : Form
    {
        public mshtml.IHTMLDocument2 doc;
        Parameters parameters = new Parameters();

        public NoteList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewNote form4 = new NewNote();
            form4.ShowDialog();
        }

        private void refreshList()
        {
            string result = parameters.makeHttpRequest("/list_notes", "user-key=" + WebUtility.UrlEncode(parameters.getPublickey()));
            dynamic JsonDe = Newtonsoft.Json.JsonConvert.DeserializeObject(result);

            listView1.Items.Clear();
            if (JsonDe != null)
            {
                foreach (int noteId in JsonDe)
                {
                    string titleRequestResponse = parameters.makeHttpRequest("/get_title", "note-id=" + noteId + "&user-key=" + WebUtility.UrlEncode(parameters.getPublickey())
                        + "&signature=" + WebUtility.UrlEncode(parameters.makeSignature(noteId.ToString())));
                    dynamic parseTitleResponse = Newtonsoft.Json.JsonConvert.DeserializeObject(titleRequestResponse);
                    string status = parseTitleResponse["status"];
                    if (parseTitleResponse["status"] == "ok")
                    {
                        string title = parseTitleResponse["noteTitle"];
                        listView1.Items.Add(new ListViewItem(new string[] { noteId.ToString(), System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(title)) }));
                    }
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            refreshList();
        }

        private void LoadItem(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                NoteEditor editorWindow = new NoteEditor(listView1.SelectedItems[0].SubItems[0].Text);
                editorWindow.Show();
            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton(object sender, EventArgs e)
        {
            string noteId = listView1.SelectedItems[0].SubItems[0].Text;
            string deleteRequestResponse = parameters.makeHttpRequest("/delete_note", "note-id=" + noteId + "&user-key=" + WebUtility.UrlEncode(parameters.getPublickey())
                 + "&signature=" + WebUtility.UrlEncode(parameters.makeSignature(noteId.ToString())));
            refreshList();
        }

        private void listView1_Enter(object sender, EventArgs e)
        {
            refreshList();
        }

    }
}
