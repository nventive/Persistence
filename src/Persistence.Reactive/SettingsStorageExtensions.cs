using System.Collections.Generic;

namespace Nventive.Persistence
{
	public static class SettingsStorageExtensions
	{
		/// <summary>
		/// Create a DataPersister over a SettingsStorage
		/// </summary>
		/// <param name="storage">The SettingsStorage provider</param>
		/// <param name="key">The key to use in the storage</param>
		/// <param name="comparer">An optional comparer, if a custom comparer should be used for the stored value.</param>
		public static IObservableDataPersister<T> ToDataPersister<T>(this ISettingsStorage storage, string key, IEqualityComparer<T> comparer = null)
		{
			return new SettingsStorageObservableDataPersisterAdapter<T>(storage, key, comparer);
		}
	}
}
