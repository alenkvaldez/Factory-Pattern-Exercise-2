using System;

namespace FactoryPatternExercise2
{
	public class SQLDataAccess : IDataAccess
	{
		public SQLDataAccess()
		{
		}

        public List<product> LoadData { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void SaveData()
        {
            Console.WriteLine("i am saving data from MongoDataAccess");
        }
    }
}

