using System.ComponentModel.DataAnnotations;

namespace Teknowlegde.Models.Enum
{
    public enum Department
    {
        [Display(Name = "Information Technology")]
        IT = 1,

        [Display(Name = "Human Resources")]
        HR = 2,

        [Display(Name = "Finance")]
        Finance = 3,

        [Display(Name = "Marketing")]
        Marketing = 4,

        [Display(Name = "Sales")]
        Sales = 5,

        [Display(Name = "Operations")]
        Operations = 6,

        [Display(Name = "Customer Service")]
        CustomerService = 7,

        [Display(Name = "Research & Development")]
        ResearchAndDevelopment = 8,

        [Display(Name = "Legal")]
        Legal = 9,

        [Display(Name = "Administration")]
        Administration = 10
    }
}
