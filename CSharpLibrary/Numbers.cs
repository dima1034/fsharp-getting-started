using System;

namespace CSharpLibrary
{
	public class Numbers
	{
		private int _number = 0;
		
		public int Getnumber()
		{
			return this._number++;
		}
	}

	public interface ICanAddNumber
	{
		int Add(int a, int b);
	}
}