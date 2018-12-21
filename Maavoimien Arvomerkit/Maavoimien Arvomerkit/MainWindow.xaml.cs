using System;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Collections.Generic;

//Finnish Defence Forces rank quiz
//Mikael Huovinen 2018

namespace Maavoimien_Arvomerkit
{
    public partial class MainWindow : Window
    {
        static Random rnd = new Random();
        static string correctAnswer = null;
        static int questionNum = 0;
        static int correctAnswers = 0;
        int[] arvomerkit = new int[21];
        List<int> menneetArvomerkit = new List<int>(); //List for ranks that have been asked already.

        public MainWindow()
        {
            InitializeComponent();
            int random = rnd.Next(arvomerkit.Length);
            SetQuestion(random);
        }

        public void SetQuestion(int random)
        {
            questionNum++; //Increase the question number by one.
            currentQuestionLabel.Content = questionNum + "/" + arvomerkit.Length.ToString(); //Change question label number to current
            menneetArvomerkit.Add(random); //Add current rank to the used ones

            //Find the question with the random index then set the image and answer to the corresponding rank.
            switch (random)
            {
                case 0:
                    arvomerkki_image.Source = new BitmapImage(new Uri("pack://application:,,,/Maavoimien Arvomerkit;component/Resources/sotamies.png", UriKind.Absolute));
                    correctAnswer = "Sotamies";
                    break;
                case 1:
                    arvomerkki_image.Source = new BitmapImage(new Uri("pack://application:,,,/Maavoimien Arvomerkit;component/Resources/korpraali.png", UriKind.Absolute));
                    correctAnswer = "Korpraali";
                    break;
                case 2:
                    arvomerkki_image.Source = new BitmapImage(new Uri("pack://application:,,,/Maavoimien Arvomerkit;component/Resources/alig.png", UriKind.Absolute));
                    correctAnswer = "Alikersantti";
                    break;
                case 3:
                    arvomerkki_image.Source = new BitmapImage(new Uri("pack://application:,,,/Maavoimien Arvomerkit;component/Resources/ukokelas.png", UriKind.Absolute));
                    correctAnswer = "Upseerioppilas";
                    break;
                case 4:
                    arvomerkki_image.Source = new BitmapImage(new Uri("pack://application:,,,/Maavoimien Arvomerkit;component/Resources/kessu.png", UriKind.Absolute));
                    correctAnswer = "Kersantti";
                    break;
                case 5:
                    arvomerkki_image.Source = new BitmapImage(new Uri("pack://application:,,,/Maavoimien Arvomerkit;component/Resources/ukokelas2.png", UriKind.Absolute));
                    correctAnswer = "Upseerikokelas";
                    break;
                case 6:
                    arvomerkki_image.Source = new BitmapImage(new Uri("pack://application:,,,/Maavoimien Arvomerkit;component/Resources/ylig.png", UriKind.Absolute));
                    correctAnswer = "Ylikersantti";
                    break;
                case 7:
                    arvomerkki_image.Source = new BitmapImage(new Uri("pack://application:,,,/Maavoimien Arvomerkit;component/Resources/vääpeli.png", UriKind.Absolute));
                    correctAnswer = "Vääpeli";
                    break;
                case 8:
                    arvomerkki_image.Source = new BitmapImage(new Uri("pack://application:,,,/Maavoimien Arvomerkit;component/Resources/ylivääpeli.png", UriKind.Absolute));
                    correctAnswer = "Ylivääpeli";
                    break;
                case 9:
                    arvomerkki_image.Source = new BitmapImage(new Uri("pack://application:,,,/Maavoimien Arvomerkit;component/Resources/sotilasmestari.png", UriKind.Absolute));
                    correctAnswer = "Sotilasmestari";
                    break;
                case 10:
                    arvomerkki_image.Source = new BitmapImage(new Uri("pack://application:,,,/Maavoimien Arvomerkit;component/Resources/vänrikki.png", UriKind.Absolute));
                    correctAnswer = "Vänrikki";
                    break;
                case 11:
                    arvomerkki_image.Source = new BitmapImage(new Uri("pack://application:,,,/Maavoimien Arvomerkit;component/Resources/luti.png", UriKind.Absolute));
                    correctAnswer = "Luutnantti";
                    break;
                case 12:
                    arvomerkki_image.Source = new BitmapImage(new Uri("pack://application:,,,/Maavoimien Arvomerkit;component/Resources/yliluti.png", UriKind.Absolute));
                    correctAnswer = "Yliluutnantti";
                    break;
                case 13:
                    arvomerkki_image.Source = new BitmapImage(new Uri("pack://application:,,,/Maavoimien Arvomerkit;component/Resources/kapt.png", UriKind.Absolute));
                    correctAnswer = "Kapteeni";
                    break;
                case 14:
                    arvomerkki_image.Source = new BitmapImage(new Uri("pack://application:,,,/Maavoimien Arvomerkit;component/Resources/majuri.png", UriKind.Absolute));
                    correctAnswer = "Majuri";
                    break;
                case 15:
                    arvomerkki_image.Source = new BitmapImage(new Uri("pack://application:,,,/Maavoimien Arvomerkit;component/Resources/eveluti.png", UriKind.Absolute));
                    correctAnswer = "Everstiluutnantti";
                    break;
                case 16:
                    arvomerkki_image.Source = new BitmapImage(new Uri("pack://application:,,,/Maavoimien Arvomerkit;component/Resources/eversti.png", UriKind.Absolute));
                    correctAnswer = "Eversti";
                    break;
                case 17:
                    arvomerkki_image.Source = new BitmapImage(new Uri("pack://application:,,,/Maavoimien Arvomerkit;component/Resources/pkenraali.png", UriKind.Absolute));
                    correctAnswer = "Prikaatikenraali";
                    break;
                case 18:
                    arvomerkki_image.Source = new BitmapImage(new Uri("pack://application:,,,/Maavoimien Arvomerkit;component/Resources/kenraalimaju.png", UriKind.Absolute));
                    correctAnswer = "Kenraalimajuri";
                    break;
                case 19:
                    arvomerkki_image.Source = new BitmapImage(new Uri("pack://application:,,,/Maavoimien Arvomerkit;component/Resources/kenraaliluti.png", UriKind.Absolute));
                    correctAnswer = "Kenraaliluutnantti";
                    break;
                case 20:
                    arvomerkki_image.Source = new BitmapImage(new Uri("pack://application:,,,/Maavoimien Arvomerkit;component/Resources/kenraali.png", UriKind.Absolute));
                    correctAnswer = "Kenraali";
                    break;
                default:
                    MessageBox.Show("Out of range.");
                    break;
            }
        }

        //Guess button pressed event
        private void guess_button_Click(object sender, RoutedEventArgs e)
        {
            //Correct answer
            if(guess_textbox.Text == correctAnswer)
            {
                MessageBox.Show("Oikea vastaus!", "", MessageBoxButton.OK, MessageBoxImage.Information);
                correctAnswers++;
            }
            else
                MessageBox.Show(string.Format("Väärä vastaus! Oikea vastaus:\n{0}", correctAnswer), "", MessageBoxButton.OK, MessageBoxImage.Error);

            //Clear the guess box and set correct answer to null
            guess_textbox.Text = "";
            correctAnswer = null;
            PickNextQuestion();
        }

        private void PickNextQuestion()
        {
            //Check if the question number is less than the amount of questions
            if (questionNum != arvomerkit.Length)
            {
                //Generate random index for the question
                int random = rnd.Next(arvomerkit.Length);

                //Test if generated index does NOT correspond to a question asked, if it is generate a new index
                if (menneetArvomerkit.Contains(random) == false)
                    SetQuestion(random);
                else
                    PickNextQuestion();
            }
            else //Victory
                MessageBox.Show(string.Format("Peli ohi.\nOikeat vastaukset: {0} / {1}.", correctAnswers.ToString(), arvomerkit.Length.ToString()), "", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
