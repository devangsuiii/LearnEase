using System.Windows.Input;

namespace LearnEase;

public partial class CourseDetailPage : ContentPage
{
    public string CourseTitle { get; set; }
    public string CourseDescription { get; set; }
    public string time { get; set; }
    public string Duration { get; set; }
    public ICommand ViewVideosCommand { get; }

    public CourseDetailPage(string courseName)
    {

        InitializeComponent();

        if (courseName == "Introduction to Programming")
        {
            Duration = "Duration: 6 weeks";
            CourseTitle = courseName;
            CourseDescription = "Explore the fundamentals of programming through this comprehensive course. Covering basic concepts such as variables, loops, and functions, you'll gain a solid understanding of programming logic and syntax. Through hands-on exercises and real-world examples, you'll apply your newfound knowledge to solve problems and develop simple applications.";
            time = "Learning Time: Approximately 2-3 hours per week";
        }
        else if (courseName == "Advanced Web Development")
        {
            Duration = "Duration: 8 weeks";
            CourseTitle = courseName;
            CourseDescription = "Elevate your web development skills with this advanced course. Delve into topics like responsive design, APIs, and database integration to create dynamic and interactive websites. Learn industry-standard tools and frameworks, and master techniques for optimizing performance and scalability. Through challenging projects and case studies, you'll refine your expertise and build sophisticated web applications.";
            time = "Learning Time: Approximately 3-4 hours per week.";
        }
        if (courseName == "Introduction to Digital Marketing")
        {
            Duration = "Duration: 4 weeks";
            CourseTitle = courseName;
            CourseDescription = "This course offers a comprehensive introduction to the dynamic field of digital marketing. Explore key concepts such as SEO, social media marketing, email marketing, and content strategy. Gain practical insights into leveraging digital channels effectively to reach target audiences and achieve marketing goals. Through case studies and hands-on exercises, you'll develop foundational skills essential for success in the digital marketing landscape.";
            time = "Learning Time: Approximately 2-3 hours per week.";
        }
        if (courseName == "Advanced Google Ads")
        {
            Duration = "Duration: 6 weeks";
            CourseTitle = courseName;
            CourseDescription = "Dive deeper into the world of online advertising with this advanced Google Ads course. Explore advanced strategies for campaign optimization, audience targeting, and ad performance analysis. Learn how to leverage advanced features such as remarketing, dynamic ads, and bid strategies to maximize ROI. Through practical assignments and real-world scenarios, you'll refine your expertise in Google Ads and gain the skills needed to drive impactful advertising campaigns";
            time = "Learning Time: Approximately 3-4 hours per week.";
        }
        else
        {
            Duration = "Duration: 6 weeks";
            CourseTitle = courseName;
            CourseDescription = "Explore the fundamentals of programming through this comprehensive course. Covering basic concepts such as variables, loops, and functions, you'll gain a solid understanding of programming logic and syntax. Through hands-on exercises and real-world examples, you'll apply your newfound knowledge to solve problems and develop simple applications.";
            time = "Learning Time: Approximately 2-3 hours per week";
        }
        // Sample data - replace with actual data




        // Set the binding context to this page
        BindingContext = this;



    }
    private async void OnEnrollNowClicked_videos(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new VideosPage());
    }
    private async void OnEnrollNowClicked_Quiz(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new QuizPage());
    }

}

