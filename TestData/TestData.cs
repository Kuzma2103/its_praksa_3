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

        public static class UpdateContactInfo
        {
            // Register user
            public const string firstName = "Kilian",
                                lastName = "Mbape",
                                address = "Neka francuska ulica",
                                city = "Parizzzzz",
                                state = "Franceeeee",
                                zipCode = "49000",
                                phone = "00381631072590",
                                ssn = "123456789101",
                                password = "lazniMbape-lazniPasos2",
                                // Update Contact Info
                                firstNameUpdated = "Da Silva Dos Santos Junior",
                                lastNameUpdated = "Neymar",
                                addressUpdated = "Neka francuska ulica",
                                cityUpdated = "Parizzzzz",
                                stateUpdated = "Franceeeee",
                                zipCodeUpdated = "49000",
                                phoneUpdated = "00381631072590";
        }

        public static class TransferFunds
        {
            public const string amount = "33533",
                                fromAccount = "15453",
                                toAccount = "23334";
        }

        public static class BillPay
        {
            public const string address = "Neka adresa",
                                city = "Rio",
                                state = "Brasil",
                                zipCode = "12345",
                                phone = "12345678",
                                account = "555",
                                verifyAccount = account,
                                amount = "322323",
                                fromAccount = "15453";
        }
    }
}

