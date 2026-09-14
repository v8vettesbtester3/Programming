using System.Resources;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection;
using static System.Formats.Asn1.AsnWriter;

namespace P01_worldCapitalQuiz
{
    public partial class QuizShowForm : Form
    {
        private IList<Question> questions;
        private IList<RadioButton> answerButtons;
        private int currentQuestion = 0;
        private bool hasAnswered = false;
        private int score = 0;
        private Random random;

        private readonly int NumberOfQuestions = 3;
        public QuizShowForm()
        {
            InitializeComponent();

            random = new Random();
            questions = getRandomQuestions(NumberOfQuestions);
            answerButtons = new List<RadioButton> { rdoAnswer1, rdoAnswer2, rdoAnswer3, rdoAnswer4 };
            LoadQuestion(questions.First());
        }

        private IList<Question> getRandomQuestions(int numberOfQuestions)
        {
            var questionsFromFile = readQuestionsFromFile();
            var randomizedQuestions = new List<Question>();
            for (var i = questionsFromFile.Count; i > 0; i--)
            {
                var randomIndex = random.Next(0, i);
                randomizedQuestions.Add(questionsFromFile[randomIndex]);
                questionsFromFile.RemoveAt(randomIndex);
            }
            return randomizedQuestions.Take(numberOfQuestions).ToList();
        }
        private IList<Question> readQuestionsFromFile()
        {
            var questions = new List<Question>();
            FileStream inFile = new FileStream("quizquestions.txt", FileMode.Open, FileAccess.Read);
            StreamReader inReader = new StreamReader(inFile);
            string? recordIn = inReader.ReadLine();
            while (recordIn != null)
            {
                //var questionsAndAnswers = Resources.quizquestions.Split(new[] {Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
                //questionsAndAnswers.RemoveAt(0);
                //foreach (var qna in questionsAndAnswers)
                //{
                var parts = recordIn.Split(',');
                if (parts.Length != 6)
                {
                    MessageBox.Show("Input file is not formatted correctly; line cannot be parsed into six parts");
                    Application.Exit();
                }
                if (!int.TryParse(parts[5], out int correctAnswer))
                {
                    MessageBox.Show("Input file is not formatted correctly; correct answer index is not a number");
                    Application.Exit();
                }
                var answers = new List<string> { parts[1], parts[2], parts[3], parts[4] };
                if (correctAnswer < 1 || correctAnswer > answers.Count)
                {
                    MessageBox.Show("Input file is not formatted correctly; correct answer index does not represent a valid answer position");
                    Application.Exit();
                }
                var question = new Question
                {
                    QuestionText = parts[0],
                    Answers = answers,
                    CorrectAnswerIndex = correctAnswer - 1

                };
                questions.Add(question);
                //}
                recordIn = inReader.ReadLine();
            }
            return questions;
        }
        private void LoadQuestion(Question question)
        {
            resetAnswers();
            txtQuestion.Text = question.QuestionText;
            if (question.Answers != null)
            {
                rdoAnswer1.Text = question.Answers[0];
                rdoAnswer2.Text = question.Answers[1];
                rdoAnswer3.Text = question.Answers[2];
                rdoAnswer4.Text = question.Answers[3];
            }
        }
        private void resetAnswers()
        {
            foreach (var answer in answerButtons)
            {
                answer.BackColor = Color.Transparent;
                answer.Checked = false;
            }
        }
        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            var current = questions[currentQuestion];
            if (current.Answers != null)
            {
                for (var i = 0; i < current.Answers.Count; i++)
                {
                    if (i == current.CorrectAnswerIndex)
                    {
                        answerButtons[i].BackColor = Color.DarkGreen;

                        if (answerButtons[i].Checked)
                        {

                            score++;
                        }
                    }
                    else
                    {
                        answerButtons[i].BackColor = Color.DarkRed;
                    }
                }
            }
            hasAnswered = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!hasAnswered) return;
            if (currentQuestion < questions.Count - 1)
            {
                var nextQuestion = questions[++currentQuestion];
                LoadQuestion(nextQuestion);
            }
            else
            {
                MessageBox.Show($"You got {score} questions right out of {questions.Count}", "Congratulations on completing the quiz!");
                var dialogResponse = MessageBox.Show("Do you want to take the quiz again ? ", "Yes or No ? ", MessageBoxButtons.YesNo);
                if (dialogResponse == DialogResult.Yes)
                {
                    questions = getRandomQuestions(NumberOfQuestions);

                    LoadQuestion(questions.First());
                    currentQuestion = 0;
                    score = 0;

                }
                else
                {
                    Application.Exit();
                }
            }
            hasAnswered = false;
        }
    }
    public class Question
    {
        public string? QuestionText { get; set; }
        public IList<string>? Answers { get; set; }
        public int CorrectAnswerIndex { get; set; }
    }
}
