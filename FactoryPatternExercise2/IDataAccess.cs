using System;
namespace FactoryPatternExercise2
{
	public interface IDataAccess
	{
        List<product> LoadData { get; set; }

        void SaveData();
	}
}

