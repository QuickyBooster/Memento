namespace Memento
{
	public class Originator
	{
		private string _text;

		public Memento SaveState() => new Memento(_text);

		public void RestoreState(Memento memento) => _text = memento.GetText();

		public void Write(string text) => _text += text;

		public override string ToString() => _text;
	}


}
