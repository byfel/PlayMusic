
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;


namespace Music_Player.Controle
{
    /// <summary>
    /// Interação lógica para Playlist.xam
    /// </summary>
    public partial class Playlist : UserControl
    {
        public Playlist()
        {
            InitializeComponent();
        }
        public string Title2
        {
            get { return (string)GetValue(Title2Property); }
            set { SetValue(Title2Property, value); }
        }
        public static readonly DependencyProperty Title2Property = DependencyProperty.Register
            ("Title2", typeof(string), typeof(MusicItem), new PropertyMetadata(null));

        public string Desc
        {
            get { return (string)GetValue(DescProperty); }
            set { SetValue(DescProperty, value); }
        }
        public static readonly DependencyProperty DescProperty = DependencyProperty.Register
            ("Desc", typeof(string), typeof(MusicItem), new PropertyMetadata(null));

        public ImageSource Imagem2
        {
            get { return (ImageSource)GetValue(Imagem2Property); }
            set { SetValue(Imagem2Property, value); }
        }
        public static readonly DependencyProperty Imagem2Property = DependencyProperty.Register
            ("Imagem2", typeof(ImageSource), typeof(MusicItem), new PropertyMetadata(null));

        public bool IsActive2
        {
            get { return (bool)GetValue(IsActive2Property); }
            set { SetValue(IsActive2Property, value); }
        }
        public static readonly DependencyProperty IsActive2Property = DependencyProperty.Register
            ("IsActive2", typeof(bool), typeof(MusicItem), new PropertyMetadata(null));
    }
}
