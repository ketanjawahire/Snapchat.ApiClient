using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snapchat.ApiClient.Enums
{
    /// <summary>
    /// Represents media types.
    /// </summary>
    public enum MediaType
    {
        /// <summary>
        /// None
        /// </summary>
        None,

        /// <summary>
        /// Image
        /// </summary>
        IMAGE = 1,

        /// <summary>
        /// Video
        /// </summary>
        VIDEO = 2,

        /// <summary>
        /// Lens package
        /// </summary>
#pragma warning disable CA1707 // Identifiers should not contain underscores
        LENS_PACKAGE = 3,
#pragma warning restore CA1707 // Identifiers should not contain underscores
    }
}
