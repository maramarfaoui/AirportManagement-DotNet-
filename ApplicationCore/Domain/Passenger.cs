using ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Domain
{
    public class Passenger
    {
        [Key]
        [StringLength(7)]
        public string PasseportNumber { get; set; }
        public FullName FullName { get; set; }
        [EmailAddress]
        public string EmailAddress { get; set; }
    
        [RegularExpression(@"^[0-9]{8}$")]
        public string PhoneNumber { get; set; }
        [Display(Name ="Date of Birth")]
        [DataType(DataType.DateTime)]
        public DateTime BirthDate { get; set; }
        public ICollection<Flight> Flights { get; set; }

        //public bool CheckProfile(string fn,string ln)
        //{
        //    if (FullName.FirstName==fn && FullName.LastName==ln)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        //public bool CheckProfile(string fn, string ln,string email)
        //{
        //    if (FullName.FirstName == fn && FullName.LastName == ln && EmailAddress==email)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        public bool CheckProfile(string fn, string ln, string email=null)
        {
            if (email!=null)
            {
                if (FullName.FirstName == fn && FullName.LastName == ln && EmailAddress == email)
                {
                    return true;
                }
                return false;
            }
           else { return false; }
        }
        public virtual void PassengerType()
        {
            Console.WriteLine("I'm a passenger");
        }
    }
}
