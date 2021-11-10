using System;
namespace Xamarin.Forms.Extensions.Svg
{
    public class SvgImageException : Exception
    {
        public SvgImageException(string message)
            : base(message)
        {
        }

        public SvgImageException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
