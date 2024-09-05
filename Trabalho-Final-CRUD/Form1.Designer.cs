namespace Trabalho_Final_CRUD
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btCadastrarCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btAtualizarCliente = new System.Windows.Forms.Button();
            this.btListarClientes = new System.Windows.Forms.Button();
            this.btExcluirCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCadastrarCliente
            // 
            this.btCadastrarCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarCliente.Location = new System.Drawing.Point(129, 160);
            this.btCadastrarCliente.Name = "btCadastrarCliente";
            this.btCadastrarCliente.Size = new System.Drawing.Size(190, 47);
            this.btCadastrarCliente.TabIndex = 0;
            this.btCadastrarCliente.Text = "Cadastrar cliente";
            this.btCadastrarCliente.UseVisualStyleBackColor = true;
            this.btCadastrarCliente.Click += new System.EventHandler(this.btCadastrarCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Área do Cliente";
            // 
            // btAtualizarCliente
            // 
            this.btAtualizarCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtualizarCliente.Location = new System.Drawing.Point(129, 230);
            this.btAtualizarCliente.Name = "btAtualizarCliente";
            this.btAtualizarCliente.Size = new System.Drawing.Size(190, 47);
            this.btAtualizarCliente.TabIndex = 2;
            this.btAtualizarCliente.Text = "Atualizar cliente";
            this.btAtualizarCliente.UseVisualStyleBackColor = true;
            this.btAtualizarCliente.Click += new System.EventHandler(this.btAtualizarCliente_Click);
            // 
            // btListarClientes
            // 
            this.btListarClientes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListarClientes.Location = new System.Drawing.Point(129, 298);
            this.btListarClientes.Name = "btListarClientes";
            this.btListarClientes.Size = new System.Drawing.Size(190, 47);
            this.btListarClientes.TabIndex = 3;
            this.btListarClientes.Text = "Listar todos clientes";
            this.btListarClientes.UseVisualStyleBackColor = true;
            this.btListarClientes.Click += new System.EventHandler(this.btListarClientes_Click);
            // 
            // btExcluirCliente
            // 
            this.btExcluirCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluirCliente.Location = new System.Drawing.Point(129, 368);
            this.btExcluirCliente.Name = "btExcluirCliente";
            this.btExcluirCliente.Size = new System.Drawing.Size(190, 47);
            this.btExcluirCliente.TabIndex = 4;
            this.btExcluirCliente.Text = "Excluir cliente";
            this.btExcluirCliente.UseVisualStyleBackColor = true;
            this.btExcluirCliente.Click += new System.EventHandler(this.btExcluirCliente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 515);
            this.Controls.Add(this.btExcluirCliente);
            this.Controls.Add(this.btListarClientes);
            this.Controls.Add(this.btAtualizarCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCadastrarCliente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCadastrarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAtualizarCliente;
        private System.Windows.Forms.Button btListarClientes;
        private System.Windows.Forms.Button btExcluirCliente;
    }
}

