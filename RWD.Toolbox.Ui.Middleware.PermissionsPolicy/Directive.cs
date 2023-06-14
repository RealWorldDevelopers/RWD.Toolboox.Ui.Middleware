
namespace RWD.Toolbox.Ui.Middleware.PermissionsPolicy
{
   /// <inheritdoc/>
   public class Directive : IDirective
   {
      /// <inheritdoc/>
      public string? Header { get; set; }

      /// <inheritdoc />
      public string? Token { get; set; }

      /// <inheritdoc/>
      public IList<string> Sources { get; set; } = new List<string>();
   }

}
