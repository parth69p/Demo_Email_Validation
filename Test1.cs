using Microsoft.VisualStudio.TestTools.UnitTesting;
using Demo_Email_Validation;

namespace EmailValidation.MsTestProject
{
    [TestClass]
    public sealed class Test1
    {
        private EmailValidator Validator;
        [TestInitialize]
       public void TestInitialize()
        {
            // Initialization code can go here if needed
            Validator = new EmailValidator();
        }

        [TestMethod]
        public void IsEmail_shouldReturnFalseForInvalidEmail()
        {
            string invalidEmail = "invalid-email.com";
            bool result = Validator.IsValidEmail(invalidEmail);
           Assert.IsFalse(result);// we are checkin for valid email value
        }

        [TestMethod]
        public void IsEmail_shouldReturnTrueForValidEmail()
        {
            string validEmail = "Ivalid@example.com";
            bool result = Validator.IsValidEmail(validEmail);
            Assert.IsTrue(result); // we are checkin for valid email value
        }
    }
}
