namespace Memento
{
	class Program
	{
		static void Main(string[] args)
		{
			var textEditor = new Originator();
			var caretaker = new Caretaker();

			// Simulate writing text
			textEditor.Write("1 Hello-");
			caretaker.Save(textEditor.SaveState()); // First save
			Console.WriteLine("Current state 1: " + textEditor.ToString());

			textEditor.Write(" 2 World!-");
			caretaker.Save(textEditor.SaveState()); // Second save
			Console.WriteLine("Current state 2: " + textEditor.ToString());

			// Undo the last action
			textEditor.RestoreState(caretaker.Undo()); // Undo to the first saved state
			Console.WriteLine("After undo 3: " + textEditor.ToString());

			textEditor.RestoreState(caretaker.Undo()); // Undo to the first saved state
			Console.WriteLine("After undo 4: " + textEditor.ToString());
		}
	}


}
