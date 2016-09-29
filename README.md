**In Xamarin Forms on iOS, the frame control background color does not match the color of other elements due to differences between `CGColor` and `UIColor`.**

Most iOS renderers work using `UIKit` and `UIColor`. The background color for instance is set using `UIView.BackgroundColor`.

Frame however works using `CoreGraphics` and `CGColor` and manipulating a view's layer. The background color is set using `UIView.Layer.BackgroundColor`.

For cross platform support, Xamarin Forms defines it's own `Color` class and has helper methods to convert to the platform colors. The iOS conversion to `CGColor` [here](https://github.com/xamarin/Xamarin.Forms/blob/eb79ff842e701ca4d2c9e1c9d02f654fd2c0f058/Xamarin.Forms.Platform.iOS/Extensions/ColorExtensions.cs) is a little naive.

Both the `ToCGColor` and `ToUIColor` methods simply take the red, green, blue, and alpha components of the Xamarin `Color` directly.
iOS is a bit more sophisticated than that, in that it supports different color spaces, making the conversion between `CGColor` and `UIColor` more complicated.

The bottom line, for consistency, `ToCGColor` should be defined as follows:
```cs
public static CGColor ToCGColor(this Color color)
{
  return color.ToUIColor().CGColor;
}
```

Below is a screenshot with a frame inside a contentview, with the same Xamarin `Color` as the background color for each.

![Screenshot](/screenshot.png?raw=true)
