using Microsoft.AspNetCore.Identity;

namespace Shared.Models;

public class ChargeSharedUserModel : IdentityUser<int>
{
    public List<AdresModel> Aresses { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public bool IsValidUser { get; set; }
    public DateTime DateOfBirth { get; set; }

    public int Age
    {
        get
        {
            //https://stackoverflow.com/a/1595311/14119518
            int age = DateTime.Now.Year - DateOfBirth.Year;

            // For leap years we need this
            if (DateOfBirth > DateTime.Now.AddYears(-age))
                age--;

            return age;
        }
    }
}