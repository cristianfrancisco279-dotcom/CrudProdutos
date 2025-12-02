namespace CrudProdutos
{
	partial class Form1
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		private void InitializeComponent()
		{
			this.lblId = new System.Windows.Forms.Label();
			this.lblNome = new System.Windows.Forms.Label();
			this.lblPreco = new System.Windows.Forms.Label();
			this.lblEstoque = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.txtPreco = new System.Windows.Forms.TextBox();
			this.txtEstoque = new System.Windows.Forms.TextBox();
			this.btnCadastrar = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnConsultar = new System.Windows.Forms.Button();
			this.gridProdutos = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).BeginInit();
			this.SuspendLayout();

			// lblId
			this.lblId.AutoSize = true;
			this.lblId.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.lblId.Location = new System.Drawing.Point(12, 15);
			this.lblId.Name = "lblId";
			this.lblId.Size = new System.Drawing.Size(27, 20);
			this.lblId.Text = "ID:";

			// lblNome
			this.lblNome.AutoSize = true;
			this.lblNome.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.lblNome.Location = new System.Drawing.Point(12, 55);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(55, 20);
			this.lblNome.Text = "Nome:";

			// lblPreco
			this.lblPreco.AutoSize = true;
			this.lblPreco.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.lblPreco.Location = new System.Drawing.Point(12, 95);
			this.lblPreco.Name = "lblPreco";
			this.lblPreco.Size = new System.Drawing.Size(49, 20);
			this.lblPreco.Text = "Preço:";

			// lblEstoque
			this.lblEstoque.AutoSize = true;
			this.lblEstoque.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.lblEstoque.Location = new System.Drawing.Point(12, 135);
			this.lblEstoque.Name = "lblEstoque";
			this.lblEstoque.Size = new System.Drawing.Size(64, 20);
			this.lblEstoque.Text = "Estoque:";

			// txtId
			this.txtId.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.txtId.Location = new System.Drawing.Point(80, 12);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(80, 27);

			// txtNome
			this.txtNome.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.txtNome.Location = new System.Drawing.Point(80, 52);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(260, 27);

			// txtPreco
			this.txtPreco.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.txtPreco.Location = new System.Drawing.Point(80, 92);
			this.txtPreco.Name = "txtPreco";
			this.txtPreco.Size = new System.Drawing.Size(120, 27);

			// txtEstoque
			this.txtEstoque.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.txtEstoque.Location = new System.Drawing.Point(80, 132);
			this.txtEstoque.Name = "txtEstoque";
			this.txtEstoque.Size = new System.Drawing.Size(120, 27);

			// btnCadastrar
			this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.btnCadastrar.Location = new System.Drawing.Point(360, 15);
			this.btnCadastrar.Name = "btnCadastrar";
			this.btnCadastrar.Size = new System.Drawing.Size(120, 30);
			this.btnCadastrar.Text = "Cadastrar";
			this.btnCadastrar.UseVisualStyleBackColor = true;

			// btnEditar
			this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.btnEditar.Location = new System.Drawing.Point(360, 55);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(120, 30);
			this.btnEditar.Text = "Editar";

			// btnExcluir
			this.btnExcluir.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.btnExcluir.Location = new System.Drawing.Point(360, 95);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(120, 30);
			this.btnExcluir.Text = "Excluir";

			// btnConsultar
			this.btnConsultar.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.btnConsultar.Location = new System.Drawing.Point(500, 55);
			this.btnConsultar.Name = "btnConsultar";
			this.btnConsultar.Size = new System.Drawing.Size(120, 30);
			this.btnConsultar.Text = "Consultar";

			// gridProdutos
			this.gridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridProdutos.Location = new System.Drawing.Point(16, 180);
			this.gridProdutos.Name = "gridProdutos";
			this.gridProdutos.Size = new System.Drawing.Size(604, 260);

			// Form1
			this.ClientSize = new System.Drawing.Size(640, 460);
			this.Controls.Add(this.gridProdutos);
			this.Controls.Add(this.btnConsultar);
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnCadastrar);
			this.Controls.Add(this.txtEstoque);
			this.Controls.Add(this.txtPreco);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.lblEstoque);
			this.Controls.Add(this.lblPreco);
			this.Controls.Add(this.lblNome);
			this.Controls.Add(this.lblId);
			this.Name = "Form1";
			this.Text = "CRUD de Produtos";
			((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Label lblId;
		private System.Windows.Forms.Label lblNome;
		private System.Windows.Forms.Label lblPreco;
		private System.Windows.Forms.Label lblEstoque;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.TextBox txtPreco;
		private System.Windows.Forms.TextBox txtEstoque;
		private System.Windows.Forms.Button btnCadastrar;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.Button btnConsultar;
		private System.Windows.Forms.DataGridView gridProdutos;
	}
}
