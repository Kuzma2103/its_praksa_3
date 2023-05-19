namespace AutomationFramework.TestData
{
    public class TestData
    {
        public static class RegisterUser
        {
            public const string firstName = "Ronaldinho",
                                lastName = "Gaucho",
                                address = "Mozzart bet",
                                city = "Rio",
                                state = "Brazil",
                                zipCode = "49000",
                                phone = "00381631072590",
                                ssn = "123456789101",
                                username = "rocko",
                                password = "rocko10-lazniPasos2";
        }

        public static class Login
        {
            public const string username = "test",
                                password = "test";
        }

        public static class ForgotLoginInfo
        {
            public const string firstName = "Ronaldinho",
                                lastName = "Gaucho",
                                address = "Mozzart bet",
                                city = "Rio",
                                state = "Brazil",
                                zipCode = "49000",
                                ssn = "123456789101";
        }

        public static class ContactUs
        {
            public const string name = "Mita",
                                email = "bekrija@gmail.com",
                                phone = "0604778234",
                                message = "Neko fensi pitanje sa sve znakom upitnika na kraju?";
        }

        public static class OpenAccount
        {
            public const string checking = "CHECKING",
                                savings = "SAVINGS";
        }

        public static class FindTransaction
        {
            public const string accountNumber = "15453",
                                date = "05-19-2023";
        }
    }
}

