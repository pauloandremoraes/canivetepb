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
using SAPbobsCOM;

namespace Addons
{
    public partial class Form1 : Form
    {
        private string arquivo;
   

        public SAPbobsCOM.CompanyService oCS;
        public SAPbobsCOM.InventoryCountingsService oICS;

        public SAPbobsCOM.InventoryCounting oIC;
        public SAPbobsCOM.InventoryCountingParams oICP;
        public SAPbobsCOM.InventoryCountingLine oICL;
        public SAPbobsCOM.StockTaking oST;
        public SAPbobsCOM.InventoryCountingLines oICLS;

        public bool _status = false;
        public string msgErroSAP;
        public bool SRet;
        public int resultado;
        public int nErr;
        public string errMsg;






        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            EscolherEmpresa Empresa = new EscolherEmpresa();
            Empresa.ShowDialog();
            if (GlobalConection.oCompany.Connected)
            { 
                label1.Text = "Conectado na Empresa :" + GlobalConection.oCompany.CompanyName;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //private void button3_Click(object sender, EventArgs e)
        //{

        //}

        private void button3_Click(object sender, EventArgs e)
        {

            StreamReader rd = new StreamReader(@txtCaminho.Text);
            string Linha = null;
            string[] linhaseparada = null;
            
            
            if (GlobalConection.oCompany.Connected)

            {

                try

                {


                    oCS = GlobalConection.oCompany.GetCompanyService();
                    oICS = oCS.GetBusinessService(SAPbobsCOM.ServiceTypes.InventoryCountingsService);
                    oIC = oICS.GetDataInterface(SAPbobsCOM.InventoryCountingsServiceDataInterfaces.icsInventoryCounting);


                    while ((Linha = rd.ReadLine()) != null)

                    {
                        linhaseparada = Linha.Split(';');
                        oIC.CountDate = DateTime.Now;

                        oICLS = oIC.InventoryCountingLines;
                        oICL = oICLS.Add();

                        oICL.ItemCode = linhaseparada[0];//"998";
                        oICL.WarehouseCode = linhaseparada[1]; //"01";
                        oICL.CountedQuantity = 2;
                        oICL.Counted = BoYesNoEnum.tYES;

                        oICP = oICS.Add(oIC);

                        int Docentry = oICP.DocumentEntry;


                    }


                    MessageBox.Show("Contagem de Estoque realizada com sucesso");

                }
                catch (Exception ex)

                {
                    string msg = ex.Message;

                    MessageBox.Show("ERRO" + msg);


                }

            }
            else
            {

                MessageBox.Show("Contagem Não Realizada");


            }


        }

        private void btnCancelaLcm_Click(object sender, EventArgs e)
        {

            LerArquivo(txtCaminho.Text);
            txtCaminho.Text = Convert.ToString(arquivo);
            

        }

        /// <summary>
        /// Cancelar LCM
        /// </summary>
        /// <param name="Caminho"></param>
        /// 
        public void LerArquivo(string Caminho )
        {   
            using (OpenFileDialog openfileDialog = new OpenFileDialog())
            {
                string PorLinha = null;
                openfileDialog.Title = "Integração SAP";
                openfileDialog.InitialDirectory = Convert.ToString(Caminho);
                openfileDialog.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
                openfileDialog.FilterIndex = 2;
                openfileDialog.RestoreDirectory = true;

                if (openfileDialog.ShowDialog() == DialogResult.OK)
                    arquivo = openfileDialog.FileName;

                if (string.IsNullOrEmpty(arquivo))
                    {
                        MessageBox.Show("Arquivo Invalido", "Salvar Como", MessageBoxButtons.OK);
                    }
                else
                    using (StreamReader texto = new StreamReader(arquivo))
                    {
                        List<string> TextoPorLinha = new List<string>();
                        
                        while ((PorLinha = texto.ReadLine()) != null)
                        {
                            TextoPorLinha.Add(PorLinha);
                        }

                        if (GlobalConection.oCompany.Connected == true)
                        {

                            foreach (var nota in TextoPorLinha)
                            {


                                // var cJE = (JournalEntries)GlobalConection.oCompany.GetBusinessObject(BoObjectTypes.oJournalVouchers);

                                //JournalEntries cJE = (JournalEntries)GlobalConection.oCompany.GetBusinessObject(BoObjectTypes.oJournalEntries);

                                // cJE.GetByKey(Convert.ToInt32(nota));

                                //Items citms = (Items)GlobalConection.oCompany.GetBusinessObject(BoObjectTypes.oItems);

                                BusinessPartners cPN = (BusinessPartners)GlobalConection.oCompany.GetBusinessObject(BoObjectTypes.oBusinessPartners);


                                cPN.GetByKey(nota);
                                //citms.GetByKey(nota);
                                

                                //Documents cancelJE = cJE.CreateCancellationDocument();

                                bool resultado;
                                //resultado = citms.GetByKey(nota);
                                resultado = cPN.GetByKey(nota);

                                if (resultado == false)
                                {
                                    string msg = GlobalConection.oCompany.GetLastErrorDescription();
                                    //MessageBox.Show(msg);
                                }
                                else
                                {
                                    // MessageBox.Show("LCM cancelado com sucesso");
                                    //citms.Remove();
                                    cPN.Remove();
                                   // MessageBox.Show("item cancelado com sucesso");
                                }

                            }

                            //MessageBox.Show("item cancelado com sucesso");
                        }






                        else
                        {
                            MessageBox.Show("Não está conectado!!");
                        }



                    }

            }

          

        }



    }
    
}

