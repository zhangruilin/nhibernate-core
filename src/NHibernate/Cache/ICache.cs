namespace NHibernate.Cache
{
	/// <summary>
	/// Implementors define a caching algorithm.
	/// </summary>
	/// <remarks>
	/// All implementations MUST be threadsafe.
	/// 
	/// <para>
	/// The key is the <c>id</c> of the object that is being cached and the 
	/// value is a <see cref="CachedItem"/>.
	/// </para>
	/// </remarks>
	public interface ICache
	{
		/// <summary>
		/// Get the object from the Cache
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		object Get( object key );

		/// <summary>
		/// 
		/// </summary>
		/// <param name="key"></param>
		/// <param name="value"></param>
		void Put( object key, object value );

		/// <summary>
		/// Remove an item from the Cache.
		/// </summary>
		/// <param name="key">The Key of the Item in the Cache to remove.</param>
		/// <exception cref="CacheException"></exception>
		void Remove( object key );

		/// <summary>
		/// Clear the Cache
		/// </summary>
		/// <exception cref="CacheException"></exception>
		void Clear();

		/// <summary>
		/// Clean up.
		/// </summary>
		/// <exception cref="CacheException"></exception>
		void Destroy();

		/// <summary>
		/// Sets the Cache Region name.
		/// </summary>
		/// <exception cref="CacheException"></exception>
		string Region { set; }

	}


}