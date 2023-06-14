
namespace RWD.Toolbox.Ui.Middleware.PermissionsPolicy
{
   /// <summary>
   /// Permissions Policy Directives Builder
   /// </summary>
   public sealed class PermissionsPolicyDirectivesBuilder
   {
      private readonly IPermissionsPolicyDirectives _directives = new PermissionsPolicyDirectives();

      internal PermissionsPolicyDirectivesBuilder() { }

      /// <summary>
      /// Builder for Accelerometer Src
      /// </summary>
      public PermissionsPolicySourceBuilder Accelerometer { get; set; } = new PermissionsPolicySourceBuilder();

      /// <summary>
      /// Builder for Autoplay Src
      /// </summary>
      public PermissionsPolicySourceBuilder Autoplay { get; set; } = new PermissionsPolicySourceBuilder();

      /// <summary>
      /// Builder for BlueTooth Src
      /// </summary>
      public PermissionsPolicySourceBuilder BlueTooth { get; set; } = new PermissionsPolicySourceBuilder();

      /// <summary>
      /// Builder for Geolocation Src
      /// </summary>
      ///<remarks>
      /// Controls whether the current document is allowed to use the Geolocation Interface.
      /// When this policy is disabled, calls to getCurrentPosition() and watchPosition()
      /// will cause those functions' callbacks to be invoked with a GeolocationPositionError code of PERMISSION_DENIED.
      /// </remarks>
      public PermissionsPolicySourceBuilder Geolocation { get; set; } = new PermissionsPolicySourceBuilder();

      /// <summary>
      /// Builder for Midi Src
      /// </summary>
      /// <remarks>
      /// Controls whether the current document is allowed to use the Web MIDI API.
      /// When this policy is disabled,
      /// the Promise returned by Navigator.requestMIDIAccess() will reject with a DOMException.
      /// </remarks>
      public PermissionsPolicySourceBuilder Midi { get; set; } = new PermissionsPolicySourceBuilder();

      /// <summary>
      /// Builder for PictureInPicture Src
      /// </summary>
      /// <remarks>
      /// 
      /// </remarks>
      public PermissionsPolicySourceBuilder PictureInPicture { get; set; } = new PermissionsPolicySourceBuilder();

      /// <summary>
      /// Builder for Serial Src
      /// </summary>
      ///<remarks>
      /// 
      /// </remarks>
      public PermissionsPolicySourceBuilder Serial { get; set; } = new PermissionsPolicySourceBuilder();

      /// <summary>
      /// Builder for SyncXhr Src
      /// </summary>
      ///<remarks>
      /// Controls whether the current document is allowed to make synchronous XMLHttpRequest requests.
      /// </remarks>
      public PermissionsPolicySourceBuilder SyncXhr { get; set; } = new PermissionsPolicySourceBuilder();
      /// <summary>
      /// Builder for Microphone
      /// </summary>
      ///<remarks>
      /// Controls whether the current document is allowed to use audio input devices.
      /// When this policy is disabled,
      /// the Promise returned by MediaDevices.getUserMedia() will reject with a NotAllowedError DOMException.
      /// </remarks>
      public PermissionsPolicySourceBuilder Microphone { get; set; } = new PermissionsPolicySourceBuilder();

      /// <summary>
      /// Builder for Camera Src
      /// </summary>
      ///<remarks>
      /// Controls whether the current document is allowed to use video input devices.
      /// When this policy is disabled,
      /// the Promise returned by getUserMedia() will reject with a NotAllowedError DOMException.
      /// </remarks>
      public PermissionsPolicySourceBuilder Camera { get; set; } = new PermissionsPolicySourceBuilder();

      /// <summary>
      /// Builder for Magnetometer Src
      /// </summary>
      ///<remarks>
      /// Controls whether the current document is allowed to
      /// gather information about the orientation of the device through the Magnetometer interface.
      /// </remarks>
      public PermissionsPolicySourceBuilder Magnetometer { get; set; } = new PermissionsPolicySourceBuilder();

      /// <summary>
      /// Builder for Gyroscope Src
      /// </summary>
      ///<remarks>
      /// Controls whether the current document is allowed to
      /// gather information about the orientation of the device through the Gyroscope interface.
      /// </remarks>
      public PermissionsPolicySourceBuilder Gyroscope { get; set; } = new PermissionsPolicySourceBuilder();

      /// <summary>
      /// Builder for Usb Src
      /// </summary>
      ///<remarks>
      ///
      /// </remarks>
      public PermissionsPolicySourceBuilder Usb { get; set; } = new PermissionsPolicySourceBuilder();

      /// <summary>
      /// Builder for Fullscreen Src
      /// </summary>
      /// <remarks>
      /// Controls whether the current document is allowed to use Element.requestFullscreen().
      /// When this policy is disabled, the returned Promise rejects with a TypeError.
      /// </remarks>
      public PermissionsPolicySourceBuilder Fullscreen { get; set; } = new PermissionsPolicySourceBuilder();

      /// <summary>
      /// Builder for PaymentRequest Src
      /// </summary>
      ///<remarks>
      /// Controls whether the current document is allowed to use the Payment Request API.
      /// When this policy is enabled, the PaymentRequest() constructor will throw a SecurityError DOMException.
      /// </remarks>
      public PermissionsPolicySourceBuilder Payment { get; set; } = new PermissionsPolicySourceBuilder();


      internal IPermissionsPolicyDirectives Build()
      {
         _directives.Accelerometer.Token = Accelerometer.Token;
         _directives.Autoplay.Token = Autoplay.Token;
         _directives.BlueTooth.Token = BlueTooth.Token;
         _directives.Camera.Token = Camera.Token;
         _directives.Fullscreen.Token = Fullscreen.Token;
         _directives.Geolocation.Token = Geolocation.Token;
         _directives.Gyroscope.Token = Gyroscope.Token;
         _directives.Magnetometer.Token = Magnetometer.Token;
         _directives.Microphone.Token = Microphone.Token;
         _directives.Midi.Token = Midi.Token;
         _directives.Payment.Token = Payment.Token;
         _directives.PictureInPicture.Token = PictureInPicture.Token;
         _directives.Serial.Token = Serial.Token;
         _directives.SyncXhr.Token = SyncXhr.Token;
         _directives.Usb.Token = Usb.Token;

         _directives.Accelerometer.Sources = Accelerometer.Sources;
         _directives.Autoplay.Sources = Autoplay.Sources;
         _directives.BlueTooth.Sources = BlueTooth.Sources;
         _directives.Camera.Sources = Camera.Sources;
         _directives.Fullscreen.Sources = Fullscreen.Sources;
         _directives.Geolocation.Sources = Geolocation.Sources;
         _directives.Gyroscope.Sources = Gyroscope.Sources;
         _directives.Magnetometer.Sources = Magnetometer.Sources;
         _directives.Microphone.Sources = Microphone.Sources;
         _directives.Midi.Sources = Midi.Sources;
         _directives.Payment.Sources = Payment.Sources;
         _directives.PictureInPicture.Sources = PictureInPicture.Sources;
         _directives.Serial.Sources = Serial.Sources;
         _directives.SyncXhr.Sources = SyncXhr.Sources;
         _directives.Usb.Sources = Usb.Sources;             


         return _directives;
      }

   }
}
