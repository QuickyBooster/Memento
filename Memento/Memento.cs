namespace Memento
{
	public class Memento
	{
		private string Text;

		public string GetText()
		{
			return Text;
		}
		public void setText(string txt)
		{
			Text = txt;
		}

		public Memento(string text)
		{
			Text = text;
		}
	}


}
