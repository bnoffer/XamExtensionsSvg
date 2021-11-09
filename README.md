# Xamarin.Forms.Extensions.Svg

SkiaSharp based component to load SVG images from the Embedded Resources of an Xamarin.Forms Application.

## Setup

Install the library via Nuget, add the latest version of SkiaSharp to your Apps Shared and Platform Projects and add the following line to your Apps `App.xaml.cs`:

```csharp
        public App()
        {
            InitializeComponent();

            // ...

            Xamarin.Forms.Extensions.Svg.SvgImage.RegisterAssembly();

            // ...

            MainPage = new MainPage();
        }
```

## Usage

First add your SVG images to your Shared Project as _EmbeddedResource_.

Afterwards you can use the SvgImage View in your App:

```xml
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:svg="clr-namespace:Xamarin.Forms.Extensions.Svg;assembly=XamExtensionsSvg"
             x:Class="SVGSample.MainPage">
<!-- ... -->
      <svg:SvgImage Source="tiger.svg" WidthRequest="100" HeightRequest="100" />
<!-- ... -->
</ContentPage>
```

If you want to change the SVGs color you can use the `TintColor` property:

```xml
       <svg:SvgImage Source="colours.svg" WidthRequest="20" HeightRequest="20" TintColor="#fcd303" />
```

## Sample

This project contains a Sample Application in the folder `Sample`.

## Acknowledgements

This work is based on an article and code sample by

[@AlexPshul](https://github.com/AlexPshul) http://www.pshul.com/2018/01/25/xamarin-forms-using-svg-images-with-skiasharp/

and some inspiration and sample assets from [muak/SvgImageSource](https://github.com/muak/SvgImageSource) by [@muak](https://github.com/muak).

## License

[MIT](https://github.com/bnoffer/XamExtensionsSvg/blob/master/LICENSE)

## Author(s)

[@bnoffer](https://github.com/bnoffer)
