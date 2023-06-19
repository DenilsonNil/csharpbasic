namespace CSharpBasic
{
	//Para criar uma Exception basta digitar Exception e pressionar double tab
	[Serializable]
	public class ContaCorrenteException : Exception
	{
		public ContaCorrenteException() { }
		public ContaCorrenteException(string message) : base(message) { }
		public ContaCorrenteException(string message, Exception inner) : base(message, inner) { }
		protected ContaCorrenteException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
