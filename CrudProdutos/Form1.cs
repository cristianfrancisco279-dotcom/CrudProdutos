namespace CrudProdutos
{
	public class Produto
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public double Preco { get; set; }
		public int Estoque { get; set; } 
	}
}


namespace CrudProdutos
{
	public partial class Form1 : Form
	{
		// LISTA EM MEMÓRIA
		private List<Produto> produtos = new List<Produto>();

		public Form1()
		{
			InitializeComponent();
		}

		private void btnCadastrar_Click(object sender, EventArgs e)
		{
			Produto p = new Produto()
			{
				Id = int.Parse(txtId.Text),
				Nome = txtNome.Text,
				Preco = double.Parse(txtPreco.Text),
				Estoque = int.Parse(txtEstoque.Text)
			};

			produtos.Add(p);
			AtualizarLista();
			MessageBox.Show("Produto cadastrado com sucesso!");
		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtId.Text);
			var prod = produtos.FirstOrDefault(x => x.Id == id);

			if (prod != null)
			{
				prod.Nome = txtNome.Text;
				prod.Preco = double.Parse(txtPreco.Text);
				prod.Estoque = int.Parse(txtEstoque.Text);

				AtualizarLista();
				MessageBox.Show("Produto atualizado!");
			}
			else
			{
				MessageBox.Show("ID não encontrado!");
			}
		}

		private void btnExcluir_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtId.Text);
			var prod = produtos.FirstOrDefault(x => x.Id == id);

			if (prod != null)
			{
				produtos.Remove(prod);
				AtualizarLista();
				MessageBox.Show("Produto excluído!");
			}
			else
			{
				MessageBox.Show("Produto não encontrado!");
			}
		}

		private void btnConsultar_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtId.Text);
			var prod = produtos.FirstOrDefault(x => x.Id == id);

			if (prod != null)
			{
				txtNome.Text = prod.Nome;
				txtPreco.Text = prod.Preco.ToString();
				txtEstoque.Text = prod.Estoque.ToString();
			}
			else
			{
				MessageBox.Show("Produto não encontrado!");
			}
		}

		// Atualiza o GRID
		private void AtualizarLista()
		{
			gridProdutos.DataSource = null;
			gridProdutos.DataSource = produtos;
		}
	}
}
 