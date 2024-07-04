using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Xml.Linq;
using System.Xml;

namespace Importação.Formulários
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();

            #region GRID LINES
            //GRID LINES CLIENTE
            ltView_Cliente.View = View.Details;
            ltView_Cliente.GridLines = true;
            ltView_Cliente.FullRowSelect = true;

            ltView_Cliente.Columns.Add("I_COD_CLIENTE", 50, HorizontalAlignment.Left);
            ltView_Cliente.Columns.Add("S_NM_CLIENTE", 100, HorizontalAlignment.Left);
            ltView_Cliente.Columns.Add("S_MAIL_CLIENTE", 150, HorizontalAlignment.Left);
            ltView_Cliente.Columns.Add("S_CEL_CLIENTE", 200, HorizontalAlignment.Left);
            ltView_Cliente.Columns.Add("S_CNPJ_CLIENTE", 250, HorizontalAlignment.Left);

            //GRID LINES PEDIDO
            ltView_Pedido.View = View.Details;
            ltView_Pedido.GridLines = true;
            ltView_Pedido.FullRowSelect = true;

            ltView_Pedido.Columns.Add("I_COD_PEDIDO", 50, HorizontalAlignment.Left);
            ltView_Pedido.Columns.Add("I_COD_CLIENTE", 150, HorizontalAlignment.Left);
            ltView_Pedido.Columns.Add("DT_DATA_PEDIDO", 250, HorizontalAlignment.Left);
            ltView_Pedido.Columns.Add("D_TOT_PEDIDO", 350, HorizontalAlignment.Left);

            //GRID LINE ITENS
            ltView_Itens.View = View.Details;
            ltView_Itens.GridLines = true;
            ltView_Itens.FullRowSelect = true;

            ltView_Itens.Columns.Add("I_COD_ITEM", 50, HorizontalAlignment.Left);
            ltView_Itens.Columns.Add("I_COD_PEDIDO", 150, HorizontalAlignment.Left);
            ltView_Itens.Columns.Add("I_COD_PRODUTO", 250, HorizontalAlignment.Left);
            ltView_Itens.Columns.Add("I_QTDE_ITENS", 350, HorizontalAlignment.Left);
            ltView_Itens.Columns.Add("D_VLRUNIT_ITENS", 450, HorizontalAlignment.Left);

            //GRID LINE PRODUTO
            ltView_Produtos.View = View.Details;
            ltView_Produtos.GridLines = true;
            ltView_Produtos.FullRowSelect = true;

            ltView_Produtos.Columns.Add("I_COD_PRODUTO", 50, HorizontalAlignment.Left);
            ltView_Produtos.Columns.Add("I_COD_CATEGORIA", 50, HorizontalAlignment.Left);
            ltView_Produtos.Columns.Add("D_VLR_PRODUTO", 50, HorizontalAlignment.Left);
            ltView_Produtos.Columns.Add("S_NM_PRODUTO", 50, HorizontalAlignment.Left);

            //GRID LINE CATEGORIA
            ltView_Categorias.View = View.Details;
            ltView_Categorias.GridLines = true;
            ltView_Categorias.FullRowSelect = true;

            ltView_Categorias.Columns.Add("I_COD_CATEGORIA", 50, HorizontalAlignment.Left);
            ltView_Categorias.Columns.Add("S_NM_CATEGORIA", 50, HorizontalAlignment.Left);
            #endregion
        }

        //BOTÔES CLIENTE
        #region Botão Json Clientes
        private void btn_jsonCliente_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*",
                Multiselect = true
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string conteudo = File.ReadAllText(openFileDialog.FileName);
                    dynamic objetoJson = JsonConvert.DeserializeObject(conteudo);
                    ltView_Cliente.Items.Clear();
                    BDCliente bdCliente = new BDCliente();
                    foreach (var item in objetoJson)
                    {
                        Cliente cliente = new Cliente();
                        {
                            ListViewItem ListViewItem = new ListViewItem(item["I_COD_CLIENTE"].ToString());
                            ListViewItem.SubItems.Add(item["S_MAIL_CLIENTE"].ToString());
                            ListViewItem.SubItems.Add(item["S_NM_CLIENTE"].ToString());
                            ListViewItem.SubItems.Add(item["S_CEL_CLIENTE"].ToString());
                            ListViewItem.SubItems.Add(item["S_CNPJ_CLIENTE"].ToString());
                            ltView_Cliente.Items.Add(ListViewItem);
                        }
                        // Insere o pedido no banco de dados
                        bdCliente.Incluir(cliente);

                        // Adiciona o pedido ao ListView
                        ListViewItem listViewItem = new ListViewItem(cliente.Cod_Cliente.ToString());
                        listViewItem.SubItems.Add(cliente.Mail_Cliente.ToString());
                        listViewItem.SubItems.Add(cliente.Nm_Cliente.ToString());
                        listViewItem.SubItems.Add(cliente.Cel_Cliente.ToString());
                        listViewItem.SubItems.Add(cliente.CNPJ_Cliente.ToString());
                        ltView_Cliente.Items.Add(listViewItem);
                    }
                    MessageBox.Show("Conteúdo do arquivo lido e inserido no banco de dados");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao ler o arquivo: {ex.Message}");
                }
            }
        }
        #endregion
        #region Botão CSV Clientes
        private void btn_csvClientes_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*",
                Multiselect = true
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try 
                {
                    var clientes = new List<Cliente>();
                    ltView_Cliente.Items.Clear(); // Limpa a ListView antes de adicionar novos itens

                    foreach (string fileName in openFileDialog.FileNames)
                    {
                        using (var reader = new StreamReader(fileName))
                        {
                            while (!reader.EndOfStream)
                            {
                                var line = reader.ReadLine();
                                var values = line.Split(',');

                                var cliente = new Cliente
                                {
                                    Cod_Cliente = int.Parse(values[0]),
                                    Nm_Cliente = values[1],
                                    CNPJ_Cliente = values[2],
                                    Mail_Cliente = values[3],
                                    Cel_Cliente = int.Parse(values[4])
                                };

                                clientes.Add(cliente);

                                // Adiciona o cliente à ListView
                                var listViewItem = new ListViewItem(cliente.Cod_Cliente.ToString());
                                listViewItem.SubItems.Add(cliente.Nm_Cliente);
                                listViewItem.SubItems.Add(cliente.CNPJ_Cliente);
                                listViewItem.SubItems.Add(cliente.Mail_Cliente);
                                listViewItem.SubItems.Add(cliente.Cel_Cliente.ToString());
                                ltView_Cliente.Items.Add(listViewItem);
                            }
                        }
                    }
                   
                    var bdCliente = new BDCliente();
                    foreach (var cliente in clientes)
                    {
                        bdCliente.Incluir(cliente);
                    }

                    MessageBox.Show("Conteúdo do arquivo lido e inserido no banco de dados");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao ler o arquivo: {ex.Message}");
                }
            }
        }
        #endregion
        #region Botão XML cliente
        private void btn_xmlCliente_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*",
                Multiselect = true
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var clientes = new List<Cliente>();
                    ltView_Cliente.Items.Clear(); // Limpa a ListView antes de adicionar novos itens

                    foreach (string fileName in openFileDialog.FileNames)
                    {
                        var xmlDoc = new XmlDocument();
                        xmlDoc.Load(fileName);

                        XmlNodeList clienteNodes = xmlDoc.SelectNodes("//Cliente");

                        foreach (XmlNode node in clienteNodes)
                        {
                            var cliente = new Cliente
                            {
                                Cod_Cliente = int.Parse(node["I_COD_CLIENTE"].InnerText),
                                Nm_Cliente = node["S_NM_CLIENTE"].InnerText,
                                CNPJ_Cliente = node["S_CNPJ_CLIENTE"].InnerText,
                                Mail_Cliente = node["S_MAIL_CLIENTE"].InnerText,
                                Cel_Cliente = int.Parse(node["S_CEL_CLIENTE"].InnerText)
                            };

                            clientes.Add(cliente);

                            // Adiciona o cliente à ListView
                            var listViewItem = new ListViewItem(cliente.Cod_Cliente.ToString());
                            listViewItem.SubItems.Add(cliente.Nm_Cliente);
                            listViewItem.SubItems.Add(cliente.Mail_Cliente);
                            listViewItem.SubItems.Add(cliente.Cel_Cliente.ToString());
                            listViewItem.SubItems.Add(cliente.CNPJ_Cliente);
                            ltView_Cliente.Items.Add(listViewItem);
                        }
                    }

                    var bdCliente = new BDCliente();
                    foreach (var cliente in clientes)
                    {
                        bdCliente.Incluir(cliente);
                    }

                    MessageBox.Show("Conteúdo do arquivo lido e inserido no banco de dados");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao ler o arquivo: {ex.Message}");
                }
            }
        }
        #endregion



        //BOTÔES PEDIDOS
        #region botão Json Pedido 
        private void btn_JsonPedido_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*",
                Multiselect = false
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string conteudo = File.ReadAllText(openFileDialog.FileName);
                    dynamic objetoJson = JsonConvert.DeserializeObject(conteudo);
                    ltView_Cliente.Items.Clear();
                    BDPedido bdPedido = new BDPedido();
                    foreach (var item in objetoJson)
                    {
                        Pedido pedido = new Pedido
                        {
                            Cod_Pedido = Convert.ToInt16(item["I_COD_PEDIDO"]),
                            Cod_Cliente = Convert.ToInt16(item["I_COD_CLIENTE"]),
                            Data_Pedido = Convert.ToString(item["S_DATA_PEDIDO"]),
                            Tot_Pedido = Convert.ToDouble(item["D_TOT_PEDIDO"])
                        };

                        // Insere o pedido no banco de dados
                        bdPedido.Incluir(pedido);

                        // Adiciona o pedido ao ListView
                        ListViewItem listViewItem = new ListViewItem(pedido.Cod_Pedido.ToString());
                        listViewItem.SubItems.Add(pedido.Cod_Cliente.ToString());
                        listViewItem.SubItems.Add(pedido.Data_Pedido.ToString());
                        listViewItem.SubItems.Add(pedido.Tot_Pedido.ToString());
                        ltView_Cliente.Items.Add(listViewItem);
                    }
                    MessageBox.Show("Conteúdo do arquivo lido e inserido no banco de dados");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao ler o arquivo: {ex.Message}");
                }
            }
        }
        #endregion

        private void btn_jsonItens_Click(object sender, EventArgs e)
        {

        }
    }
}

