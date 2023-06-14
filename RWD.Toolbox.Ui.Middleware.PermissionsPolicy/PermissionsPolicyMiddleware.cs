using Microsoft.AspNetCore.Http;

namespace RWD.Toolbox.Ui.Middleware.PermissionsPolicy
{
   /// <summary>
   /// An ASP.NET middleware for adding Permissions Policy header.
   /// </summary>
   public sealed class PermissionsPolicyMiddleware
   {
      private const string PolicyHeader = "Permissions-Policy";
      private readonly RequestDelegate _next;
      private readonly IPermissionsPolicyDirectives _directives;

      /// <summary>
      /// Instantiates a new <see cref="PermissionsPolicyMiddleware"/>.
      /// </summary>
      /// <param name="next">The next middleware in the pipeline.</param>
      /// <param name="directives">An instance of <see cref="IPermissionsPolicyDirectives"/>.</param>        
      public PermissionsPolicyMiddleware(RequestDelegate next, IPermissionsPolicyDirectives directives)
      {
         _next = next ?? throw new ArgumentNullException(nameof(next));
         _directives = directives ?? throw new ArgumentNullException(nameof(directives));
      }

      /// <summary>
      /// Invoke the middleware
      /// </summary>
      /// <param name="context">The current context</param>
      /// <returns></returns>
      public async Task Invoke(HttpContext context)
      {
         if (context == null)
            throw new ArgumentNullException(nameof(context));

         context.Response.Headers.Add(PolicyHeader, GetHeaderValue());
         await _next(context);
      }

      /// <summary>
      /// Supportive Function to build Header Value
      /// </summary>
      private string GetHeaderValue()
      {
         var value = string.Empty;

         foreach (var directive in _directives.DirectiveList)
         {
            if (directive.Token != null && directive.Header != null)
               value += GetDirective(directive.Header, directive.Token, directive.Sources);
         }

         return value.Remove(value.Length - 2);
      }

      /// <summary>
      /// Supportive Function to compile a directive for Header Value
      /// </summary>
      /// <param name="directive">Directive Name as <see cref="string"/></param>
      /// <param name="token">Token name as<see cref="string"/></param>
      /// <param name="origin">List of origin web address as <see cref="IList{String}"/></param>
      /// <returns>Compiled directive as a <see cref="string"/></returns>      
      private static string GetDirective(string directive, string token, IList<string> origin)
      {
         if (token == "*")
            return $"{directive}={token}, ";

         return $"{directive}=({token}{string.Join("", origin)}), ";
      }
   }
}
