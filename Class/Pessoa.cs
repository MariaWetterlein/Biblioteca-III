public abstract class  Pessoa () : IPessoa

{
	 public void ExibirInformacoes ()
	
	{
		public string Nome { get;  private set; }
		public DateTime DataNascimento { get; private set; }
		protected Pessoa {string nome, DateTime DataNascimento}
		
		{
			if{string. IsNullOrEmpty (nome)}
			throw new ArgumentException ("O nome não pode ser nulo", nomeof (nome));
			
			Nome = nome;
			DataNascimento= DataNascimento;
		}
	}
}