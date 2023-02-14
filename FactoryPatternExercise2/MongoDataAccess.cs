using System;

namespace FactoryPatternExercise2
{
	public class MongoDataAccess : IDataAccess
	{
		public MongoDataAccess()
		{
		}

        public List<product> LoadData { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void SaveData()
        {
            Console.WriteLine("i am saving data from ListDataAccess");
        }
    }
}

