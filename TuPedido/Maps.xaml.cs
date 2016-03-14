using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Controls.Maps;

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=234238

namespace TuPedido
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Maps : Page
    {
        public Maps()
        {
            this.InitializeComponent();

            MapControl MapControl2 = new MapControl();
            MapControl2.ZoomInteractionMode = MapInteractionMode.GestureAndControl;
            MapControl2.TiltInteractionMode = MapInteractionMode.GestureAndControl;
            MapControl2.MapServiceToken = "IwNwSoT9V0jrzVgRERgc~cXNlL1E5mh1VyOBC6LiPDg~AvH3hNCp2o6lz2uDb-JrzU3vpbDsMOJuD1ssoqZ9xqyrvxSP2tCgGLsdeYS-jLJ5";
            pageGrid.Children.Add(MapControl2);

        }
    }
}
