using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Demo4ka.UserControls
{

    public partial class Product : UserControl
    {
        public Product()
        {
            InitializeComponent();
        }

        public ImageSource Source
        {
            get { return (ImageSource)GetValue(SourceProperty); }
            set { SetValue(SourceProperty, value); }
        }

        public static readonly DependencyProperty SourceProperty = DependencyProperty.Register("Source", typeof(ImageSource), typeof(Product));

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register("Source", typeof(ImageSource), typeof(Product));

        public string Ref
        {
            get { return (string)GetValue(RefProperty); }
            set { SetValue(RefProperty, value); }
        }

        public static readonly DependencyProperty RefProperty = DependencyProperty.Register("Source", typeof(string), typeof(Product));

        public string Color
        {
            get { return (string)GetValue(ColorProperty); }
            set { SetValue(SourceProperty, value); }
        }

        public static readonly DependencyProperty ColorProperty = DependencyProperty.Register("Source", typeof(string), typeof(Product));

        public string Count
        {
            get { return (string)GetValue(CountProperty); }
            set { SetValue(SourceProperty, value); }
        }

        public static readonly DependencyProperty CountProperty = DependencyProperty.Register("Source", typeof(string), typeof(Product));

    }
}
