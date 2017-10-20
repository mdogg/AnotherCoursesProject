using CoursesLibrary;
using System;

using UIKit;

namespace AnotherCoursesProjectIOS
{
    public partial class AnotherCourseViewController : UIViewController
    {
        CourseManager courseManager;

        public AnotherCourseViewController() : base("AnotherCourseViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            buttonPrevious.TouchUpInside += ButtonPrevious_TouchUpInside;
            buttonNext.TouchUpInside += ButtonNext_TouchUpInside;

            courseManager = new CourseManager();
            courseManager.MoveFirst();
            UpdateUI();
        }

        private void ButtonPrevious_TouchUpInside(object sender, EventArgs e)
        {
            courseManager.MovePrev();
            UpdateUI();
            //labelTitle.Text = "Prevoius Clicked";
            //textDescription.Text = "this is the description that displays when PREVIOUS IS CLICKED with new images";
            //imageCourse.Image = UIImage.FromBundle("member04_on");
        }


        private void ButtonNext_TouchUpInside(object sender, EventArgs e)
        {
            courseManager.MoveNext();
            UpdateUI();
            //labelTitle.Text = "Next Clicked";
            //textDescription.Text = "this is the description that displays when NEXT IS CLICKED with new images too";
            //imageCourse.Image = UIImage.FromBundle("member03_on");
        }


        private void UpdateUI()
        {
            labelTitle.Text = courseManager.Current.Title;
            textDescription.Text = courseManager.Current.Description;
            imageCourse.Image = UIImage.FromBundle(courseManager.Current.Image);
            buttonPrevious.Enabled = courseManager.CanMovePrev;
            buttonNext.Enabled = courseManager.CanMoveNext;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

