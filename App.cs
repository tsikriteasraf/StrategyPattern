using Assignment3.Views;

namespace Assignment3
{
    class App
    {
        public static void Run()
        {
            BankTransfer bank = new BankTransfer();
            Cash cash = new Cash();
            CreditDebitCard creditCard = new CreditDebitCard();
            Database database = new Database(bank,cash,creditCard);
            GeneralView.ViewItemsPrice(Helper.ListCreator(database));
        }
    }
}
