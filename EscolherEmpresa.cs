using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAPbobsCOM;
using System.IO;
using System.Xml;
using System.Xml.Linq;
//using SAPbouiCOM;


namespace Addons
{
    public partial class EscolherEmpresa : Form
    {


        public string aviso = string.Empty;
        private string nomeDoArquivo = "Config.xml";
        private XElement doc;

       

        public EscolherEmpresa()
        {
        
         if (File.Exists("Config.xml"))
            {
              doc = XElement.Load("Config.xml");
              doc.RemoveAll();
            }
         else
         {
             doc = new XElement("Config.xml");
         }
            
        
        {
            InitializeComponent();
        }

        }








        private void button1_Click(object sender, EventArgs e)
        
        
        {
            if(ValidarCampos())


            { 

                            GlobalConection.IncitalizeCompany();

                            GlobalConection.oCompany.CompanyDB = cbEmpresa.Text;
                            GlobalConection.oCompany.Server = cbServer.Text;
                            GlobalConection.oCompany.UserName = Convert.ToString(txtUser.Text);
                            GlobalConection.oCompany.Password = Convert.ToString(txtPassword.Text);
                            GlobalConection.oCompany.language = BoSuppLangs.ln_Portuguese_Br;
                GlobalConection.oCompany.DbUserName = Convert.ToString(txtuserbd.Text); //"sa";
                            GlobalConection.oCompany.DbPassword = Convert.ToString(txtsenhabd.Text); //"sapadmi";


                            if (cbTypeServer.Text == "MSSQL2012")
                            {

                                GlobalConection.oCompany.DbServerType = BoDataServerTypes.dst_MSSQL2012;
                            }

                            if (cbTypeServer.Text == "MSSQL2008")
                            {
                                GlobalConection.oCompany.DbServerType = BoDataServerTypes.dst_MSSQL2008;

                            }

                            if(cbTypeServer.Text == "MSSQL2014")
                            {
                             GlobalConection.oCompany.DbServerType = BoDataServerTypes.dst_MSSQL2014;

                            }



                GlobalConection.lRetCode = GlobalConection.oCompany.Connect();

                            if (GlobalConection.lRetCode != 0)
                            {
                                int temp_int = GlobalConection.lErrCode;
                                string temp_string = GlobalConection.sErrMsg;
                                GlobalConection.oCompany.GetLastError(out temp_int, out temp_string);
                                MessageBox.Show(temp_string);
                            }
                            else
                            {
                                //MessageBox.Show("Connectado na empresa " +  GlobalConection.oCompany.CompanyName);
                                this.Text = this.Text + ": Connectado";
                                label6.Text = "Conectado na empresa : " + (GlobalConection.oCompany.CompanyName);

                                ///Incia gravação do arquivo XML///

                                XElement config = new XElement("config");

                                config.Add(new XElement("server", cbServer.Text));
                                config.Add(new XElement("user", txtUser.Text));
                                config.Add(new XElement("password", txtPassword.Text));
                                config.Add(new XElement("tiposerver", cbTypeServer.Text));
                                config.Add(new XElement("Empresa", cbEmpresa.Text));

                                doc.Add(config);
                                doc.Save("config.xml");
                               // MessageBox.Show("Salvo com sucesso ;-)");
                                label7.Text = "XML de config Salvo Com Sucesso!";


                            }

            }
            else
            {

             MessageBox.Show("" + aviso, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }



           



        }
            

            private bool ValidarCampos()
                   
                    {
                        bool camposPreenchidos = true;
                    
                        if (txtUser.Text == string.Empty)
                        { 
                            this.aviso = "Informe o usuario.";
                            return camposPreenchidos = false;
                        }

                        if (txtPassword.Text ==string.Empty)
                        {
                            this.aviso = "Inform a senha";
                            return camposPreenchidos = false;

                        }
                        
                        if (cbEmpresa.Text == string.Empty)
                        {
                            this.aviso = "Informe a Empresa";
                            return camposPreenchidos = false;

                        }
                        
                        if (cbServer.Text == string.Empty)
                        {
                            this.aviso = "Informe o Servidor";
                            return camposPreenchidos = false;

                        }

                        if (cbTypeServer.Text == string.Empty)
                        {
                            this.aviso = "Informe o Tipo de Banco";
                            return camposPreenchidos = false;
                        }   

                        
                        return camposPreenchidos;




                    {

           




            }
        }

            private void EscolherEmpresa_Load(object sender, EventArgs e)
            {

                 if (File.Exists("Config.xml"))

                 { 
                                XmlTextReader x = new XmlTextReader(@".\\config.xml");
                                while (x.Read())
                                
                                {
                                    if (x.NodeType == XmlNodeType.Element && x.Name == "server")
                                        cbServer.Text = (x.ReadString());
                                    if (x.NodeType == XmlNodeType.Element && x.Name == "user")
                                        txtUser.Text = (x.ReadString());
                                    if (x.NodeType == XmlNodeType.Element && x.Name == "password")
                                        txtPassword.Text = (x.ReadString());
                                    if (x.NodeType == XmlNodeType.Element && x.Name == "tiposerver")
                                        cbTypeServer.Text = (x.ReadString());
                                    if (x.NodeType == XmlNodeType.Element && x.Name == "Empresa")
                                        cbEmpresa.Text = (x.ReadString());
                               

                
                                }

                                x.Close();
                                //return;
                 }
            }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
