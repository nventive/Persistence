namespace Nventive.Persistence
{
	/// <summary>
	/// Properties of the folder
	/// </summary>
	public enum FolderType
	{
		/// <summary>
		/// Folder who is never deleted nor backed up by the operating system.
		/// </summary>
		WorkingData,

		/// <summary>
		/// Folder who is backed up (never deleted) by the operating system.
		/// </summary>
		/// <remarks>
		/// It's backed up on supporting operating system when activated by the user.
		/// </remarks>
		BackedUpData,

		/// <summary>
		/// Folder to store caching data who can be deleted by the operating system.
		/// </summary>
		/// <remarks>
		/// It's usually deleted when the app is not running.
		/// </remarks>
		Caching,

		/// <summary>
		/// Folder to store temporary data.
		/// </summary>
		/// <remarks>
		/// As soon the a file is closed, there's no guarantee the file will stay there.
		/// </remarks>
		Temporary
	}
}
