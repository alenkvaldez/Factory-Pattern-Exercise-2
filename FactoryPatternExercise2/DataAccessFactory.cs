using System;
namespace FactoryPatternExercise2
{
	static class DataAccessFactory
	{
		public static IDataAccess GetDataAccess(string databaseType)
		{
			switch (databaseType.ToLower())
			{
				case "list":
					return new ListDataAccess();

				case "mysql":
				case "sql":
				case "my":
					return new SQLDataAccess();

				case "mongo":
					return new MongoDataAccess();

				default:
					return new ListDataAccess();
				

			}
		}
	}
}

