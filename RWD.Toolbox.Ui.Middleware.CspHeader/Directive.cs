
using System.Collections.Generic;

namespace RWD.Toolbox.Ui.Middleware.CspHeader
{
    /// <inheritdoc/>
    public class Directive : IDirective
    {
        /// <inheritdoc/>
        public string Header { get; set; }

        /// <inheritdoc/>
        public IList<string> Sources { get; set; } = new List<string>();
    }
}
