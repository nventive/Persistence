namespace Chinook.Persistence
{
	/// <summary>
	/// Something that may have multiple format version
	/// </summary>
	/// <remarks>
	/// The version number is for the format, not the data.
	/// </remarks>
	public interface IVersionable
	{
		/// <summary>
		/// The version of the format for this object
		/// </summary>
		int Version { get; }
	}
}
