using System;

namespace FactoryPatternExercise2
{
	public class ListDataAccess : IDataAccess
	{
		public ListDataAccess()
		{
		}

        public List<product> LoadData { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void SaveData()
        {
            Console.WriteLine("i am saving data from a SQLDataAccess ..");
        }
    }
}

