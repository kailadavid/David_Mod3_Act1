using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using David_Mod3_Act1.Model;
using Xamarin.Forms;

namespace David_Mod3_Act1.ViewModel
{
    class StudentViewModel : INotifyPropertyChanged
    {
        public Student StudentSet { get; set; }
        public Command SubmitEntry { get; set; }
        public Command ClearEntry { get; set; }

        public int StudentIDEntry { get; set; }
        public int StudentIDDisplay { get; set; }
        public string NameEntry { get; set; }
        public string NameDisplay { get; set; }
        public string CourseCodeEntry { get; set; }
        public string CourseCodeDisplay { get; set; }
        public string CourseTitleEntry { get; set; }
        public string CourseTitleDisplay { get; set; }
        public int UnitsEntry { get; set; }
        public int UnitsDisplay { get; set; }
        public DateTime AttendanceEntry { get; set; }
        public DateTime AttendanceDisplay { get; set; }

        public StudentViewModel()
        {
            SubmitEntry = new Command(() =>
            {
                StudentSet = new Student
                {
                    StudentID = StudentIDEntry,
                };

                StudentIDDisplay = StudentIDEntry;
                NameDisplay = NameEntry;
                CourseCodeDisplay = CourseCodeEntry;
                CourseTitleDisplay = CourseTitleEntry;
                UnitsDisplay = UnitsEntry;
                AttendanceDisplay = AttendanceEntry;

                OnPropertyChanged(nameof(StudentIDDisplay));
                OnPropertyChanged(nameof(StudentIDEntry));

                OnPropertyChanged(nameof(NameDisplay));
                OnPropertyChanged(nameof(NameEntry));

                OnPropertyChanged(nameof(CourseCodeDisplay));
                OnPropertyChanged(nameof(CourseCodeEntry));

                OnPropertyChanged(nameof(CourseTitleDisplay));
                OnPropertyChanged(nameof(CourseTitleEntry));

                OnPropertyChanged(nameof(UnitsDisplay));
                OnPropertyChanged(nameof(UnitsEntry));

                OnPropertyChanged(nameof(AttendanceDisplay));
                OnPropertyChanged(nameof(AttendanceEntry));
            });

            ClearEntry = new Command(() =>
            {
                StudentIDDisplay = 0;
                StudentIDEntry = 0;
                NameDisplay = "";
                NameEntry = "";
                CourseCodeDisplay = "";
                CourseCodeEntry = "";
                CourseTitleDisplay = "";
                CourseTitleEntry = "";
                UnitsDisplay = 0;
                UnitsEntry = 0;
                // AttendanceDisplay = "";
                // AttendanceEntry = "";

                OnPropertyChanged(nameof(StudentIDDisplay));
                OnPropertyChanged(nameof(StudentIDEntry));

                OnPropertyChanged(nameof(NameDisplay));
                OnPropertyChanged(nameof(NameEntry));

                OnPropertyChanged(nameof(CourseCodeDisplay));
                OnPropertyChanged(nameof(CourseCodeEntry));

                OnPropertyChanged(nameof(CourseTitleDisplay));
                OnPropertyChanged(nameof(CourseTitleEntry));

                OnPropertyChanged(nameof(UnitsDisplay));
                OnPropertyChanged(nameof(UnitsEntry));

                // OnPropertyChanged(nameof(AttendanceDisplay));
                // OnPropertyChanged(nameof(AttendanceEntry));
            });
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(String propertyName)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}