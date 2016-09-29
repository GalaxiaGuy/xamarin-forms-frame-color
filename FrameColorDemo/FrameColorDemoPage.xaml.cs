using System.Collections.Generic;
using Xamarin.Forms;

namespace FrameColorDemo
{
    public partial class FrameColorDemoPage : ContentPage
    {
        public FrameColorDemoPage()
        {
            InitializeComponent();
            BindingContext = new List<Color>
            { 
                Color.Aqua, 
                Color.Black, 
                Color.Blue, 
                Color.Fuchsia, 
                Color.Gray, 
                Color.Green, 
                Color.Lime, 
                Color.Maroon, 
                Color.Navy, 
                Color.Olive, 
                Color.Pink, 
                Color.Purple, 
                Color.Red, 
                Color.Silver, 
                Color.Teal, 
                Color.White, 
                Color.Yellow };
        }
    }
}
