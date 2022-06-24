
using System.Windows;
using System.Windows.Controls;


namespace Music_Player.Controle
{
    /// <summary>
    /// Interação lógica para MusicItem.xam
    /// </summary>
    public partial class MusicItem : UserControl
    {
        public MusicItem()
        {
            InitializeComponent();
        }

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }
        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register
            ("Title", typeof(string), typeof(MusicItem), new PropertyMetadata(null));

        public string Number
        {
            get { return (string)GetValue(NumberProperty); }
            set { SetValue(NumberProperty, value); }
        }
        public static readonly DependencyProperty NumberProperty = DependencyProperty.Register
            ("Number", typeof(string), typeof(MusicItem), new PropertyMetadata(null));

        public string Time
        {
            get { return (string)GetValue(TimeProperty); }
            set { SetValue(TimeProperty, value); }
        }
        public static readonly DependencyProperty TimeProperty = DependencyProperty.Register
            ("Time", typeof(string), typeof(MusicItem), new PropertyMetadata(null));

        public bool IsActive
        {
            get { return (bool)GetValue(IsActiveProperty); }
            set { SetValue(IsActiveProperty, value); }
        }
        public static readonly DependencyProperty IsActiveProperty = DependencyProperty.Register
            ("IsActive", typeof(bool), typeof(MusicItem), new PropertyMetadata(null));
















    }
}
