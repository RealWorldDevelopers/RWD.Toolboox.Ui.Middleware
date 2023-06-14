
namespace RWD.Toolbox.Ui.Middleware.PermissionsPolicy
{
   /// <summary>
   /// Permissions Policy Directive
   /// </summary>
   public interface IDirective
   {
      /// <summary>
      /// Permissions Policy Directive Header Value
      /// </summary>
      string? Header { get; set; }

      /// <summary>
      /// Permissions Policy Directive Token Value
      /// </summary>
      string? Token { get; set; }

      /// <summary>
      /// Permissions Policy Directive Source Value
      /// </summary>
      IList<string> Sources { get; set; }
   }
}
