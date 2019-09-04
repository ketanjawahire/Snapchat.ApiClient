namespace Snapchat.ApiClient
{
    /// <summary>
    /// Represents wrapper object received in API response.
    /// </summary>
    /// <typeparam name="TEntity">Any object of type <see cref="IEntity"/>.</typeparam>
    public interface IWrapper<TEntity>
        where TEntity : IEntity
    {
        /// <summary>
        /// Gets or sets sub request status.
        /// </summary>
        string SubRequestStatus { get; set; }

        /// <summary>
        /// Gets or sets API entity of type <typeparamref name="TEntity"/>.
        /// </summary>
        TEntity Entity { get; set; }
    }
}
