using PFD.Models.AccountantPlans;

namespace PFD.Models.Accounts;

public class SubAccount : IAccount
{
    public string Name { get; set; }
    public string Email { get; set; }
    public List<AccountantPlan> AccountantPlans { get; set; }
    
    public SubAccount(string name, string email)
    {
        Name = name;
        Email = email;
        AccountantPlans = new List<AccountantPlan>();
    }
    
    public void AssignAccountantPlan(AccountantPlan ap)
    {
        AccountantPlans.Add(ap);
    }
}