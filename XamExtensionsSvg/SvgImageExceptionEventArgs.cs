using System;
namespace Xamarin.Forms.Extensions.Svg
{
	public class SvgImageExceptionEventArgs : EventArgs
	{
		private SvgImageException _svgImageException;
		public SvgImageException SvgImageException => _svgImageException;

		public SvgImageExceptionEventArgs(SvgImageException ex)
		{
			_svgImageException = ex;
		}
	}
}

