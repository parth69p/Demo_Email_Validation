using Xunit;// adding reference of the project
using Demo_Email_Validation;
namespace EmailValidation.XUnit
{
    public class UnitTest1
    {
        private EmailValidator Validator = new EmailValidator();

        [Fact]
        public void IsEmailValid_ShouldReturnFalseForInvalidEmail()
        {
            string input = "invalid-email.com";
            bool result = Validator.IsValidEmail(input);
            Assert.False(result);// for wrong email id;
        }
        [Fact]
        public void IsEmailValid_ShouldReturnTrueForValidEmail()
        {
            string input = "test@example.com";
            bool result = Validator.IsValidEmail(input);
            Assert.True(result);// for wrong email id;
        }
    }
}