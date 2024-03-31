using Microsoft.Maui.Controls;
using System;
using System.Linq;

namespace LearnEase
{
    public partial class QuizPage : ContentPage
    {
        public QuizPage()
        {
            InitializeComponent();
        }

        private void OnSubmitQuizClicked(object sender, EventArgs e)
        {
            // Calculate the score based on selected options
            int score = 0;

            // Question 1
            var selectedOption1 = Question1Options.Children.FirstOrDefault(rb => ((RadioButton)rb).IsChecked);
            if (selectedOption1 != null && ((RadioButton)selectedOption1).Content == "Hyper Text Markup Language")
                score++;

            // Question 2
            var selectedOption2 = Question2Options.Children.FirstOrDefault(rb => ((RadioButton)rb).IsChecked);
            if (selectedOption2 != null && ((RadioButton)selectedOption2).Content == "Java")
                score++;

            // Question 3
            var selectedOption3 = Question3Options.Children.FirstOrDefault(rb => ((RadioButton)rb).IsChecked);
            if (selectedOption3 != null && ((RadioButton)selectedOption3).Content == "10")
                score++;

            // Question 4
            var selectedOption4 = Question4Options.Children.FirstOrDefault(rb => ((RadioButton)rb).IsChecked);
            if (selectedOption4 != null && ((RadioButton)selectedOption4).Content == "Stack")
                score++;

            // Question 5
            var selectedOption5 = Question5Options.Children.FirstOrDefault(rb => ((RadioButton)rb).IsChecked);
            if (selectedOption5 != null && ((RadioButton)selectedOption5).Content == "9")
                score++;


            if (score > 3)
            {
                DisplayAlert("Quiz Result", $"Your score is {score}/5\nYou Completed the course Yaahoo....!!!", "OK");
            }
            else
            {
                DisplayAlert("Quiz Result", $"Your score is {score}/5\nYou have failed the course...!!!", "OK");
            }
            // Display the score
            
        }
    }
}
