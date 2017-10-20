using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursesLibrary
{
    public class CourseManager
    {
        private readonly Course[] courses;

        int currentIndex = 0;

        public CourseManager()
        {
            courses = InitCourses();
        }

        private Course[] InitCourses()
        {
            var initCourses = new Course[] {
                new Course()
                {
                    Title = "Martin's Course",
                    Description = "Martin will lead this course",
                    Image = "member04_on"
                },
                new Course()
                {
                    Title = "John's Course",
                    Description = "John will lead this course",
                    Image = "member03_on"
                },
                new Course()
                {
                    Title = "Alick's Course",
                    Description = "Alick will lead this course",
                    Image = "member02_on"
                },
                new Course()
                {
                    Title = "Ev's Course",
                    Description = "Ev will lead this course",
                    Image = "member01_on"
                }
            };

            return initCourses;

        }

        public void MoveFirst()
        {
            currentIndex = 0;
        }

        public void MovePrev()
        {
            if (currentIndex > 0)
            {
                currentIndex--;
            }
        }

        public void MoveNext()
        {
            if (currentIndex < courses.Length - 1)
            {
                currentIndex++;
            }
        }

        public Course Current
        {
            get
            {
                return courses[currentIndex];
            }

        }
    }
}
