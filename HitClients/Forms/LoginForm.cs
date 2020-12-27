using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using HitClients.Api;
using HitClients.Api.Types.Authentication;
using HitClients.Helpers;

namespace HitClients.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLogin.Text))
            {
                LbStatus.Text = "Login is empty!";
                return;
            }
            if (string.IsNullOrEmpty(txtPass.Text))
            {
                LbStatus.Text = "Pass is empty!";
                return;
            }

            LoginKey loginKey = new LoginKey
            {
                Login = txtLogin.Text,
                Pass = txtPass.Text
            };

            if (cbSave.Checked)
            {
                WriteXml(loginKey);
            }


            Login(loginKey);
        }

        private void Login(LoginKey loginKey)
        {
            LbStatus.Text = "Trying to login...";
            var result = ApiProvider.Login(loginKey);
            if (result)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                LbStatus.Text = "Wrong login or password!";
            }
        }

        public void WriteXml(LoginKey loginKey)
        {

            string fileLoginKey = Path.Combine(FolderHelper.HitClientsPath, "LoginKey.xml");
            FileStream file = File.Create(fileLoginKey);
            
            XmlSerializer writer = new XmlSerializer(typeof (LoginKey));
            writer.Serialize(file, loginKey);
            file.Close();
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            LoginKey loginKey = ReadXml();
            if (loginKey != null)
            {
                txtLogin.Text = loginKey.Login;
                txtPass.Text = loginKey.Pass;
                cbSave.Checked = true;
            }
        }

        public LoginKey ReadXml()
        {
            string fileLoginKey = Path.Combine(FolderHelper.HitClientsPath, "LoginKey.xml");
            if (!File.Exists(fileLoginKey)) return null;
            XmlSerializer reader = new XmlSerializer(typeof(LoginKey));
            StreamReader file = new StreamReader(fileLoginKey);
            LoginKey loginKey = (LoginKey)reader.Deserialize(file);
            file.Close();
            return loginKey;
        }
    }
}
