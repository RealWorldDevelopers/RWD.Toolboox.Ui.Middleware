
using System.Collections.Generic;

namespace RWD.Toolbox.Ui.Middleware.SecurityHeaders
{
    /// <summary>
    /// Defines the policy for customizing security headers for a request.
    /// </summary>
    public class SecurityHeadersPolicy
    {
        /// <summary>
        /// Add Header
        /// </summary>
        public IDictionary<string, string> SetHeaders { get; } = new Dictionary<string, string>();

        /// <summary>
        /// Remove Header
        /// </summary>
        public ISet<string> RemoveHeaders { get; } = new HashSet<string>();

    }
}
