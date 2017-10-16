using System;

using UIKit;

namespace hexx2rgb
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

			convertButton.TouchUpInside += ConvertButton_TouchUpInside;
		}

		void ConvertButton_TouchUpInside(object sender, EventArgs e)
		{
			string hexValue = hexValueTextField.Text;
			string redHexValue = hexValue.Substring(0, 2);
			string greenHexValue = hexValue.Substring(2, 2);
			string blueHexValue = hexValue.Substring(4, 2);

		}

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
