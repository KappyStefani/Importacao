namespace Importação.Formulários
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tab_control = new TabControl();
            tab_Cliente = new TabPage();
            ltView_Cliente = new ListView();
            btn_csvClientes = new Button();
            btn_xmlCliente = new Button();
            btn_jsonCliente = new Button();
            tab_Pedido = new TabPage();
            ltView_Pedido = new ListView();
            button4 = new Button();
            button3 = new Button();
            btn_JsonPedido = new Button();
            tab_Itens = new TabPage();
            ltView_Itens = new ListView();
            button7 = new Button();
            button8 = new Button();
            btn_jsonItens = new Button();
            tab_Produtos = new TabPage();
            ltView_Produtos = new ListView();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            tab_Categoria = new TabPage();
            ltView_Categorias = new ListView();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            tab_control.SuspendLayout();
            tab_Cliente.SuspendLayout();
            tab_Pedido.SuspendLayout();
            tab_Itens.SuspendLayout();
            tab_Produtos.SuspendLayout();
            tab_Categoria.SuspendLayout();
            SuspendLayout();
            // 
            // tab_control
            // 
            tab_control.Controls.Add(tab_Cliente);
            tab_control.Controls.Add(tab_Pedido);
            tab_control.Controls.Add(tab_Itens);
            tab_control.Controls.Add(tab_Produtos);
            tab_control.Controls.Add(tab_Categoria);
            tab_control.Location = new Point(12, 12);
            tab_control.Name = "tab_control";
            tab_control.SelectedIndex = 0;
            tab_control.Size = new Size(776, 426);
            tab_control.TabIndex = 0;
            // 
            // tab_Cliente
            // 
            tab_Cliente.Controls.Add(ltView_Cliente);
            tab_Cliente.Controls.Add(btn_csvClientes);
            tab_Cliente.Controls.Add(btn_xmlCliente);
            tab_Cliente.Controls.Add(btn_jsonCliente);
            tab_Cliente.Location = new Point(4, 24);
            tab_Cliente.Name = "tab_Cliente";
            tab_Cliente.Padding = new Padding(3);
            tab_Cliente.Size = new Size(768, 398);
            tab_Cliente.TabIndex = 0;
            tab_Cliente.Text = "Cliente";
            tab_Cliente.UseVisualStyleBackColor = true;
            // 
            // ltView_Cliente
            // 
            ltView_Cliente.Location = new Point(0, 0);
            ltView_Cliente.Name = "ltView_Cliente";
            ltView_Cliente.Size = new Size(664, 398);
            ltView_Cliente.TabIndex = 7;
            ltView_Cliente.UseCompatibleStateImageBehavior = false;
            // 
            // btn_csvClientes
            // 
            btn_csvClientes.Location = new Point(670, 100);
            btn_csvClientes.Name = "btn_csvClientes";
            btn_csvClientes.Size = new Size(92, 41);
            btn_csvClientes.TabIndex = 6;
            btn_csvClientes.Text = "Inserir Dados CSV";
            btn_csvClientes.UseVisualStyleBackColor = true;
            // 
            // btn_xmlCliente
            // 
            btn_xmlCliente.Location = new Point(670, 53);
            btn_xmlCliente.Name = "btn_xmlCliente";
            btn_xmlCliente.Size = new Size(92, 41);
            btn_xmlCliente.TabIndex = 5;
            btn_xmlCliente.Text = "Inserir Dados XML";
            btn_xmlCliente.UseVisualStyleBackColor = true;
            // 
            // btn_jsonCliente
            // 
            btn_jsonCliente.Location = new Point(670, 6);
            btn_jsonCliente.Name = "btn_jsonCliente";
            btn_jsonCliente.Size = new Size(92, 41);
            btn_jsonCliente.TabIndex = 4;
            btn_jsonCliente.Text = "Inserir Dados JSON";
            btn_jsonCliente.UseVisualStyleBackColor = true;
            btn_jsonCliente.Click += btn_jsonCliente_Click;
            // 
            // tab_Pedido
            // 
            tab_Pedido.Controls.Add(ltView_Pedido);
            tab_Pedido.Controls.Add(button4);
            tab_Pedido.Controls.Add(button3);
            tab_Pedido.Controls.Add(btn_JsonPedido);
            tab_Pedido.Location = new Point(4, 24);
            tab_Pedido.Name = "tab_Pedido";
            tab_Pedido.Padding = new Padding(3);
            tab_Pedido.Size = new Size(768, 398);
            tab_Pedido.TabIndex = 1;
            tab_Pedido.Text = "Pedido";
            tab_Pedido.UseVisualStyleBackColor = true;
            // 
            // ltView_Pedido
            // 
            ltView_Pedido.Location = new Point(0, 0);
            ltView_Pedido.Name = "ltView_Pedido";
            ltView_Pedido.Size = new Size(664, 398);
            ltView_Pedido.TabIndex = 8;
            ltView_Pedido.UseCompatibleStateImageBehavior = false;
            // 
            // button4
            // 
            button4.Location = new Point(670, 100);
            button4.Name = "button4";
            button4.Size = new Size(92, 41);
            button4.TabIndex = 3;
            button4.Text = "Inserir Dados CSV";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(670, 53);
            button3.Name = "button3";
            button3.Size = new Size(92, 41);
            button3.TabIndex = 2;
            button3.Text = "Inserir Dados XML";
            button3.UseVisualStyleBackColor = true;
            // 
            // btn_JsonPedido
            // 
            btn_JsonPedido.Location = new Point(670, 6);
            btn_JsonPedido.Name = "btn_JsonPedido";
            btn_JsonPedido.Size = new Size(92, 41);
            btn_JsonPedido.TabIndex = 1;
            btn_JsonPedido.Text = "Inserir Dados JSON";
            btn_JsonPedido.UseVisualStyleBackColor = true;
            // 
            // tab_Itens
            // 
            tab_Itens.Controls.Add(ltView_Itens);
            tab_Itens.Controls.Add(button7);
            tab_Itens.Controls.Add(button8);
            tab_Itens.Controls.Add(btn_jsonItens);
            tab_Itens.Location = new Point(4, 24);
            tab_Itens.Name = "tab_Itens";
            tab_Itens.Size = new Size(768, 398);
            tab_Itens.TabIndex = 2;
            tab_Itens.Text = "Itens";
            tab_Itens.UseVisualStyleBackColor = true;
            // 
            // ltView_Itens
            // 
            ltView_Itens.Location = new Point(0, 0);
            ltView_Itens.Name = "ltView_Itens";
            ltView_Itens.Size = new Size(664, 398);
            ltView_Itens.TabIndex = 8;
            ltView_Itens.UseCompatibleStateImageBehavior = false;
            // 
            // button7
            // 
            button7.Location = new Point(670, 100);
            button7.Name = "button7";
            button7.Size = new Size(92, 41);
            button7.TabIndex = 6;
            button7.Text = "Inserir Dados CSV";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(670, 53);
            button8.Name = "button8";
            button8.Size = new Size(92, 41);
            button8.TabIndex = 5;
            button8.Text = "Inserir Dados XML";
            button8.UseVisualStyleBackColor = true;
            // 
            // btn_jsonItens
            // 
            btn_jsonItens.Location = new Point(670, 6);
            btn_jsonItens.Name = "btn_jsonItens";
            btn_jsonItens.Size = new Size(92, 41);
            btn_jsonItens.TabIndex = 4;
            btn_jsonItens.Text = "Inserir Dados JSON";
            btn_jsonItens.UseVisualStyleBackColor = true;
            // 
            // tab_Produtos
            // 
            tab_Produtos.Controls.Add(ltView_Produtos);
            tab_Produtos.Controls.Add(button10);
            tab_Produtos.Controls.Add(button11);
            tab_Produtos.Controls.Add(button12);
            tab_Produtos.Location = new Point(4, 24);
            tab_Produtos.Name = "tab_Produtos";
            tab_Produtos.Size = new Size(768, 398);
            tab_Produtos.TabIndex = 3;
            tab_Produtos.Text = "Produtos";
            tab_Produtos.UseVisualStyleBackColor = true;
            // 
            // ltView_Produtos
            // 
            ltView_Produtos.Location = new Point(0, 0);
            ltView_Produtos.Name = "ltView_Produtos";
            ltView_Produtos.Size = new Size(664, 398);
            ltView_Produtos.TabIndex = 8;
            ltView_Produtos.UseCompatibleStateImageBehavior = false;
            // 
            // button10
            // 
            button10.Location = new Point(670, 100);
            button10.Name = "button10";
            button10.Size = new Size(92, 41);
            button10.TabIndex = 9;
            button10.Text = "Inserir Dados CSV";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Location = new Point(670, 53);
            button11.Name = "button11";
            button11.Size = new Size(92, 41);
            button11.TabIndex = 8;
            button11.Text = "Inserir Dados XML";
            button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Location = new Point(670, 6);
            button12.Name = "button12";
            button12.Size = new Size(92, 41);
            button12.TabIndex = 7;
            button12.Text = "Inserir Dados JSON";
            button12.UseVisualStyleBackColor = true;
            // 
            // tab_Categoria
            // 
            tab_Categoria.Controls.Add(ltView_Categorias);
            tab_Categoria.Controls.Add(button13);
            tab_Categoria.Controls.Add(button14);
            tab_Categoria.Controls.Add(button15);
            tab_Categoria.Location = new Point(4, 24);
            tab_Categoria.Name = "tab_Categoria";
            tab_Categoria.Size = new Size(768, 398);
            tab_Categoria.TabIndex = 4;
            tab_Categoria.Text = "Categorias";
            tab_Categoria.UseVisualStyleBackColor = true;
            // 
            // ltView_Categorias
            // 
            ltView_Categorias.Location = new Point(0, 0);
            ltView_Categorias.Name = "ltView_Categorias";
            ltView_Categorias.Size = new Size(664, 398);
            ltView_Categorias.TabIndex = 8;
            ltView_Categorias.UseCompatibleStateImageBehavior = false;
            // 
            // button13
            // 
            button13.Location = new Point(670, 100);
            button13.Name = "button13";
            button13.Size = new Size(92, 41);
            button13.TabIndex = 12;
            button13.Text = "Inserir Dados CSV";
            button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            button14.Location = new Point(670, 53);
            button14.Name = "button14";
            button14.Size = new Size(92, 41);
            button14.TabIndex = 11;
            button14.Text = "Inserir Dados XML";
            button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            button15.Location = new Point(670, 6);
            button15.Name = "button15";
            button15.Size = new Size(92, 41);
            button15.TabIndex = 10;
            button15.Text = "Inserir Dados JSON";
            button15.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tab_control);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Principal";
            Text = "Principal";
            tab_control.ResumeLayout(false);
            tab_Cliente.ResumeLayout(false);
            tab_Pedido.ResumeLayout(false);
            tab_Itens.ResumeLayout(false);
            tab_Produtos.ResumeLayout(false);
            tab_Categoria.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tab_control;
        private TabPage tab_Cliente;
        private TabPage tab_Pedido;
        private TabPage tab_Itens;
        private TabPage tab_Produtos;
        private TabPage tab_Categoria;
        private Button btn_JsonPedido;
        private Button button4;
        private Button button3;
        private Button btn_csvClientes;
        private Button btn_xmlCliente;
        private Button btn_jsonCliente;
        private Button button7;
        private Button button8;
        private Button btn_jsonItens;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private ListView ltView_Cliente;
        private ListView ltView_Pedido;
        private ListView ltView_Itens;
        private ListView ltView_Produtos;
        private ListView ltView_Categorias;
    }
}