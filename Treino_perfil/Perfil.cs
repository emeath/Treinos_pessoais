namespace Treino_Perfil
{
	class Pessoa
	{
		public string Nome { get; set; }
		public string Endereco { get; set; }
		public int Id { get; private set; }
		public long Telefone { get; set; }

		public Pessoa(string nome, string endereco, int id, long telefone)
		{
			Nome = nome;
			Endereco = endereco;
			Id = id;
			Telefone = telefone;
		}
	}
}