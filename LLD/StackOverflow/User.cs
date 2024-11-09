using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StackOverflow
{
    public class User
    {
        public int Id { get; }
        public string UserName { get; }
        public string Email { get; }
        public int Reputation { get; private set; }

        private readonly List<Question> _questions;
        private readonly List<Answer> _answers;
        private readonly List<Comment> _comments;

        public User(int id, string username, string email)
        {
            Id = id;
            Username = username;
            Email = email;
            Reputation = 0;
            _questions = new List<Question>();
            _answers = new List<Answer>();
            _comments = new List<Comment>();
        }

        public Question AskQuestion(string title, string content, List<string> tags)
        {
            var question = new Question(this, title, content, tags);
            _questions.Add(question);
            UpdateReputation(QuestionReputation);
            return question;
        }

        public Answer AnswerQuestion(Question question, string content)
        {
            var answer = new Answer(this, question, content);
            _answers.Add(answer);
            question.AddAnswer(answer);
            UpdateReputation(AnswerReputation);
            return answer;
        }

        public Comment AddComment(ICommentable commentable, string content)
        {
            var comment = new Comment(this, content);
            _comments.Add(comment);
            commentable.AddComment(comment);
            UpdateReputation(CommentReputation);
            return comment;
        }

        public void UpdateReputation(int value)
        {
            Reputation = System.Math.Max(0, Reputation + value);
        }

        public List<Question> GetQuestions()
        {
            return new List<Question>(_questions);
        }

        public List<Answer> GetAnswers()
        {
            return new List<Answer>(_questions);
        }
    }
}
