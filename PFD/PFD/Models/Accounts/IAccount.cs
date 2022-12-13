using PFD.Models.AccountantPlans;

namespace PFD.Models.Accounts;

public interface IAccount
{
    string Name { get; set; }
    string Email { get; set; }

    void AssignAccountantPlan(AccountantPlan ap);
}