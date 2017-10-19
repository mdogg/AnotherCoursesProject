using System;

using UIKit;

namespace AnotherCoursesProjectIOS
{
    public partial class AnotherCourseViewController : UIViewController
    {
        public AnotherCourseViewController() : base("AnotherCourseViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            buttonPrevious.TouchUpInside += ButtonPrevious_TouchUpInside;
            buttonNext.TouchUpInside += ButtonNext_TouchUpInside;
        }

        private void ButtonPrevious_TouchUpInside(object sender, EventArgs e)
        {
            labelTitle.Text = "Prevoius Clicked";
        }

        private void ButtonNext_TouchUpInside(object sender, EventArgs e)
        {
            labelTitle.Text = "Next Clicked";
        }
        
        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

