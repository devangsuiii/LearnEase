namespace LearnEase;

public class CourseDetailPage : ContentPage
{
    public CourseDetailPage(string courseName)
    {
        Title = courseName; // Set the title of the page to the course name

        // Here, you would add elements to display the course details.
        // For this example, we're just adding a simple label.
        Content = new StackLayout
        {
            Children = {
                
            }
        };
    }
}

