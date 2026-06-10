using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DagDrop_POPRAWNY
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RedRectangle_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragDrop.DoDragDrop(RedRectangle, RedRectangle, DragDropEffects.Move);
            }
        }

        private void Canvas_Drop(object sender, DragEventArgs e)
        {
            //Point dropPosition =  e.GetPosition(myCanvas);
            //Canvas.SetLeft(RedRectangle, dropPosition.X);
            //Canvas.SetTop(RedRectangle, dropPosition.Y);
        }

        private void myCanvas_DragOver(object sender, DragEventArgs e)
        {
            Point dropPosition = e.GetPosition(myCanvas);
            Canvas.SetLeft(RedRectangle, dropPosition.X);
            Canvas.SetTop(RedRectangle, dropPosition.Y);
        }
    }
}