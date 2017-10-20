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
            textDescription.Text = "this is the description that displays when PREVIOUS IS CLICKED with new images";
            imageCourse.Image = UIImage.FromBundle("member04_on");
        }

        private void ButtonNext_TouchUpInside(object sender, EventArgs e)
        {
            labelTitle.Text = "Next Clicked";
            textDescription.Text = "this is the description that displays when NEXT IS CLICKED with new images too";
            imageCourse.Image = UIImage.FromBundle("member03_on");
        }
        
        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

