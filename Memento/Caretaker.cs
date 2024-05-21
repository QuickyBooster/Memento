namespace Memento
{
	public class Caretaker
	{
		private readonly Stack<Memento> _mementos = new Stack<Memento>();

		public void Save(Memento memento)
		{
			_mementos.Push(memento);
		}

		public Memento Undo()
		{
			if (_mementos.Count == 0) return null;
			var lastMemento = _mementos.Pop();
			return lastMemento;
		}
	}


}
