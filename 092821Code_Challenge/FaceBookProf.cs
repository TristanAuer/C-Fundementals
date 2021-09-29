using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _092821Code_Challenge
{
    public enum GameingSystem { Nintendo, Xbox, Playstation, PC, Genesis }
    public class FaceBookProf
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int AgeInYears
        {
            get
            {
                TimeSpan ageSpan = DateTime.Now - DateOfBirth;
                double totalAgeInYears = ageSpan.TotalDays / 365.25;
                return Convert.ToInt32(Math.Floor(totalAgeInYears));

            }
        }
        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }
        public string Education { get; set; }
        public GameingSystem Gameing { get; set; }

        public string GetFullDescription(FaceBookProf profile)
        {
            string fullDescription = $"{profile.FullName} {profile.Education} {profile.AgeInYears} {profile.Gameing}";
            return fullDescription;

        }
    }
}
