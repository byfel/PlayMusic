using System;

using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;


namespace Music_Player.Controle
{
    /// <summary>
    /// Interação lógica para MusicPopular.xam
    /// </summary>
    public partial class MusicPopular : UserControl
    {
        public MusicPopular()
        {
            InitializeComponent();
        }

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }
        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register
            ("Title", typeof(string), typeof(MusicPopular));

        public string Time
        {
            get { return (string)GetValue(TimeProperty); }
            set { SetValue(TimeProperty, value); }
        }
        public static readonly DependencyProperty TimeProperty = DependencyProperty.Register
            ("Time", typeof(string), typeof(MusicPopular));

        public bool IsActive
        {
            get { return (bool)GetValue(IsActiveProperty); }
            set { SetValue(IsActiveProperty, value); }
        }
        public static readonly DependencyProperty IsActiveProperty = DependencyProperty.Register
            ("IsActive", typeof(bool), typeof(MusicPopular));

        public string Imagem
        {
            get { return (string)GetValue(ImagemProperty); }
            set { SetValue(ImagemProperty, value); }
        }
        public static readonly DependencyProperty ImagemProperty = DependencyProperty.Register
            ("Imagem", typeof(string), typeof(MusicPopular));

    }
}
