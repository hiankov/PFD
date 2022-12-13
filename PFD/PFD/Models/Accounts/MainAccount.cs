using PFD.Models.AccountantPlans;

namespace PFD.Models.Accounts;

public class MainAccount : IAccount
{
    public string Name { get; set; }
    public string Email { get; set; }

    private List<SubAccount> SubAccounts { get; set; }
    private List<AccountantPlan> AccountantPlans { get; set; }

    public MainAccount(string name, string email, List<SubAccount> subAccounts)
    {
        Name = name;
        Email = email;
        SubAccounts = subAccounts;
        AccountantPlans = new List<AccountantPlan>();
    }

    public void AddSubAccount(SubAccount subAccount)
    {
        SubAccounts.Add(subAccount);
    }
    
    public void AssignAccountantPlan(AccountantPlan accountantPlan)
    {
        AccountantPlans.Add(accountantPlan);
    }
}