using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace QuizProject
{
    internal class Quiz
    {


        private Question[] _questions;
        private int _score;


        public Quiz(Question[] questions)
        {
            this._questions = questions;
            _score = 0;
        }

        public void StartQuiz()
        {
            Console.WriteLine("Welcome to the quiz");
            int questionNumber = 1; //to display question numbers

            foreach(Question question in _questions)
            {
                Console.WriteLine($"Quesiton {questionNumber + 1}");
                DisplayQuestion(question);
                int userChoice = GetUserChoice();
                if (question.IsCorrectAnswer(userChoice))
                {
                    Console.WriteLine("Correct");
                    _score++;
                }
                else
                {
                    Console.WriteLine($"Wrong! The correct answer was: {question.Answers[question.CorrectAnswerIndex]}");
                }
            }
            DisplayResult();
        }

        private void DisplayResult()
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("+==============================================+\r\n|   ___  _   _ _____ ____ _____ ___ ___  _   _ |\r\n|  / _ \\| | | | ____/ ___|_   _|_ _/ _ \\| \\ | ||\r\n| | | | | | | |  _| \\___ \\ | |  | | | | |  \\| ||\r\n| | |_| | |_| | |___ ___) || |  | | |_| | |\\  ||\r\n|  \\__\\_\\\\___/|_____|____/ |_| |___\\___/|_| \\_||\r\n|                                              |\r\n+==============================================+");
            Console.ResetColor();

            Console.WriteLine($"Quiz finished. Your score is {_score} out of {_questions.Length}");

            double percentage = (double)_score / _questions.Length;
            if (percentage >= 0.8)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Excelent Work!");
            }
            else if (percentage >= 0.5)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Good Effort!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Keep Practicing");
            }
            Console.ResetColor();
        }

        private void DisplayQuestion(Question question)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*************************************\r\n* ____  _____ ____  _   _ _   _____ *\r\n*|  _ \\| ____/ ___|| | | | | |_   _|*\r\n*| |_) |  _| \\___ \\| | | | |   | |  *\r\n*|  _ <| |___ ___) | |_| | |___| |  *\r\n*|_| \\_\\_____|____/ \\___/|_____|_|  *\r\n*************************************");
            Console.ResetColor();
            Console.WriteLine(question.QuestionText);

            for (int i = 0; i < question.Answers.Length; i++)
            {

                Console.ForegroundColor = ConsoleColor.Cyan; //Changed the text color
                Console.Write("    ");
                Console.Write(i + 1);
                Console.ResetColor(); //resets the text color
                Console.WriteLine($". {question.Answers[i]}");

            }
        }

        private int GetUserChoice()
        {

            Console.Write("Your answer (number): ");
            string input = Console.ReadLine();
            int choice = 0;
            while (!int.TryParse(input, out choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid Choice, enter a number between 1 and 4");
                input = Console.ReadLine();
            }

            return choice -1; //adjust to 0-indexed array
        }
    }
}
