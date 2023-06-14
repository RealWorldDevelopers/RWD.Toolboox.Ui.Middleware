using System;
using System.Security.Cryptography;


namespace RWD.Toolbox.Ui.Middleware.CspHeader.TagHelpers
{
   /// <summary>
   /// Helpers for creating hashing algorithms
   /// </summary>
   internal static class CryptographyAlgorithms
   {
      /// <summary>
      /// Create an instance of the required hashing algorithm
      /// </summary>
      /// <param name="algorithm">The CSP algorithm to create</param>
      /// <returns>The hashing algorithm instance</returns>
      public static HashAlgorithm Create(CSPHashType algorithm)
      {
         return algorithm switch
         {
            CSPHashType.SHA256 => CreateSHA256(),
            CSPHashType.SHA384 => CreateSHA384(),
            CSPHashType.SHA512 => CreateSHA512(),
            _ => throw new InvalidOperationException($"Unknown CSP Hash Type: {algorithm}"),
         };
      }

      /// <summary>
      /// Creates an instance of <see cref="SHA256"/>
      /// </summary>
      /// <returns>An instance of <see cref="SHA256"/></returns>
      private static SHA256 CreateSHA256()
      {
         return SHA256.Create();
      }

      /// <summary>
      /// Creates an instance of <see cref="SHA384" />
      /// </summary>
      /// <returns>An instance of <see cref="SHA384"/></returns>
      private static SHA384 CreateSHA384()
      {
         return SHA384.Create();
      }

      /// <summary>
      /// Creates an instance of <see cref="SHA512"/>
      /// </summary>
      /// <returns>An instance of <see cref="SHA512"/></returns>
      private static SHA512 CreateSHA512()
      {
         return SHA512.Create();
      }

   }
}
