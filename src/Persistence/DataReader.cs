using System.Collections.Generic;
using System.IO;

namespace Chinook.Persistence
{
	/// <summary>
	/// Helper class for creating <see cref="IDataReader"/>
	/// </summary>
	public static class DataReader
	{
		/// <summary>
		/// Create an <see cref="IDataReader"/> from a file in the application package.
		/// </summary>
		public static IDataReader<T> CreateFromFile<T>(
			string filePath,
			Uno.FuncAsync<Stream, T> read,
			IEqualityComparer<T> comparer = null
		)
		{
			return new FileDataReader<T>(filePath, read, fileIsUnmodifiable: true, comparer: comparer);
		}
	}
}
