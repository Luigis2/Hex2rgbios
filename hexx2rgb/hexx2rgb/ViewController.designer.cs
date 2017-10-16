// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace hexx2rgb
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel blueValueLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton coolButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel greenValueLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField hexValueTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel redValueLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (blueValueLabel != null) {
                blueValueLabel.Dispose ();
                blueValueLabel = null;
            }

            if (coolButton != null) {
                coolButton.Dispose ();
                coolButton = null;
            }

            if (greenValueLabel != null) {
                greenValueLabel.Dispose ();
                greenValueLabel = null;
            }

            if (hexValueTextField != null) {
                hexValueTextField.Dispose ();
                hexValueTextField = null;
            }

            if (redValueLabel != null) {
                redValueLabel.Dispose ();
                redValueLabel = null;
            }
        }
    }
}