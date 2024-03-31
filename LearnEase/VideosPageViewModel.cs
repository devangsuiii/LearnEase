using System.Collections.ObjectModel;
using System.Windows.Input;

namespace LearnEase;


    public class VideosPageViewModel 
    {
        public ObservableCollection<VideoItem> Videos { get; set; }

        public VideosPageViewModel()
        {
            Videos = new ObservableCollection<VideoItem>
            {
                new VideoItem { Title = "C Programming in One Shot | Part 1 | Variables, Operators and Input/ Output | C Complete Course", Description = "Sir will teach you C language from SCRATCH. This is Lecture 1 of the C Programming series. Topics covered are - Printing / Output, Variables, Operators, and Input. Additionally, 16 Problems are covered in this video. In the next lecture, we will cover Conditionals / Control Statements in C. ", VideoId = "rQoqCP7LX60?si=3jmgKEAukbnEkhpP" },
                new VideoItem { Title = "If Else in 1 Video | C Programming | Lecture 2 | Complete C Course", Description = "Sir will teach you IF ELSE statement in DETAIL. This is Lecture 2 of the C Programming series. Topics covered are - If-Else, Nested If-Else, Else If and Ternary Operator. Additionally, 22 Problems are covered in this video and 6 Homework questions are given. In the next lecture, we will cover LOOPS and PATTERN PRINTING in C.", VideoId = "7PSfRdeY5qE?si=zoy81AVkyZHD5vvU" },
                new VideoItem { Title = "Loops in One Shot | C Programming | Lecture 3 | Complete C Course", Description = "Sir will teach you LOOPS in DETAIL. This is Lecture 3 of the C Programming series. Topics covered are - For Loop, While Loop, Do While Loop and LOTS of QUESTIONS. Pattern Printing will be covered in the next Lecture in detail, coming SOON.", VideoId = "wYvrBXUfFfw?si=Tkjr5X3x5dF2C5EL" },
                new VideoItem { Title = "Pattern Printing in One Video | Lecture 4 | C Programming Series", Description = "Sir will teach you how to solve all the PATTERN PRINTING problems in DETAIL. This is Lecture 4 of the C Programming series. Topics covered are - All kinds of patterns, STAR, NUMBER, ALPHABET and all shapes like diamond, pyramid etc. Functions and Pointers will be covered in the next Lecture in detail, coming SOON.", VideoId = "clIcH1ALHMw?si=3iUChias8jLfg6u2" },
                new VideoItem { Title = "Functions & Pointers in One Shot | C Programming | Lecture 5 | Complete C Course", Description = "Sir will teach you about FUNCTIONS and POINTERS in DETAIL. This is Lecture 5 of the C Programming series. Topics covered are - function calls, return type, function prototype, pass by value, pass by reference and lots of questions. Recursion will be covered in the next Lecture in detail, coming SOON.", VideoId = "mIY3QVktHU8?si=dohaAvu-SabxqOXq" },
                new VideoItem { Title = "Recursion in One Shot | C Programming | Lecture 6 | Complete C Course", Description = "Sir will teach you about RECURSION in DETAIL. This is Lecture 6 of the C Programming series. Topics covered are - recurrence  relation, tree diagram, recursion after call, multiple calls, euler tour tree, call stack and LOTS of questions. ARRAYS will be covered in the next Lecture in detail, coming SOON.", VideoId = "Bd-1YM8taBc?si=UMJVx06eKnUvGUNG" },

            };
        }
    }

    public class VideoItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string VideoId { get; set; }
        public ICommand PlayVideoCommand { get; set; }

        public VideoItem()
        {
            PlayVideoCommand = new Command(PlayVideo);
        }

        private void PlayVideo()
        {
            App.Current.MainPage.Navigation.PushAsync(new VideoPlayerPage(VideoId));
        }
    }
