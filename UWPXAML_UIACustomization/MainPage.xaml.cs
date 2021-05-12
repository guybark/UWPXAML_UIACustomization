using Windows.UI.Xaml.Automation.Peers;
using Windows.UI.Xaml.Controls;

namespace UWPXAML_UIACustomization
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
    }


    public class MyGraph : UserControl
    {
        // If it's necessary for the custom control to have its own
        // custom AutomationPeer, then additional customization of the
        // UIA representation can be made through the peer.
        //protected override AutomationPeer OnCreateAutomationPeer()
        //{
        //    return new MyGraphAutomationPeer(this);
        //}
    }

    //public class MyGraphAutomationPeer : FrameworkElementAutomationPeer
    //{
    //    public MyGraphAutomationPeer(MyGraph owner) :
    //        base(owner)
    //    {
    //    }
    //}

}
