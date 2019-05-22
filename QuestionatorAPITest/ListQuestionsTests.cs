using FluentAssertions;
using NUnit.Framework;
using QuestionatorAPI.Controllers;
using QuestionatorAPI.UseCase;

namespace QuestionatorAPITest
{
    public class ListQuestionsTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ReturnTheListOfQuestions()
        {
            var listQuestions = new ListQuestions();
            var listQuestionsResponse = listQuestions.Execute();
            listQuestionsResponse.Should().BeEquivalentTo("one", "two");
        }
    }
}