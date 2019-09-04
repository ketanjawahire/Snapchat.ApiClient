using System.Collections.Generic;
using Snapchat.ApiClient.Entities.Api;

namespace Snapchat.ApiClient
{
    /// <summary>
    /// Represents root level object received in API response.
    /// </summary>
    /// <typeparam name="TWrapper">Any object of type <see cref="IWrapper{TEntity}"/>.</typeparam>
    /// <typeparam name="TEntity">Any object of type <see cref="IEntity"/>.</typeparam>
    public interface IRootObject<TWrapper, TEntity>
        where TWrapper : IWrapper<TEntity>
        where TEntity : IEntity
    {
        /// <summary>
        /// Gets or sets Request status.
        /// </summary>
        string RequestStatus { get; set; }

        /// <summary>
        /// Gets or sets request id.
        /// </summary>
        string RequestId { get; set; }

        /// <summary>
        /// Gets or sets paging.
        /// </summary>
        Paging Paging { get; set; }
#pragma warning disable CA2227 // Collection properties should be read only

        /// <summary>
        /// Gets or sets wrapper object collection of type <typeparamref name="TEntity"/>.
        /// </summary>
        List<TWrapper> WrapperCollection { get; set; }
#pragma warning restore CA2227 // Collection properties should be read only
    }
}
