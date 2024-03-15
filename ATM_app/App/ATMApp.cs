// See https://aka.ms/new-console-template for more information
using ATM_app.Domain.Entities;
using ATM_app.UI;
using System.Collections.Generic;

class ATMApp {
    private List<UserAccount> userAccountList;
    private UserAccount SelectedAccounnt;

    public void IntializeData()
    {
        userAccountList = new List<UserAccount>()
        {
             new UserAccount{Id = 1 , FullName = "Sara Ahmed",AccountBalance=3000,AccountNumber=123,CardNumber=123123,CardPin=123123,IsLocked=false},
             new UserAccount{Id = 2 , FullName = "Sara mo",AccountBalance=200,AccountNumber=1234,CardNumber=234234,CardPin=234234,IsLocked=false},
             new UserAccount{Id = 3 , FullName = "nouran hany",AccountBalance=4000,AccountNumber=12345,CardNumber=345345,CardPin=345345,IsLocked=false}
        };
    }
    static  void Main(string[] args)
    {
        AppScreen.welcome();
        int cardNum = Validator.Convert<int>("Your card number");
        Console.WriteLine($"Your Card number is {cardNum}");

    }
  
}
