using _092821Code_Challenge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _092821CA_CodingChallenge
{
    class CAFaceBook
    {
        public List<FaceBookProf> _faceBookProfs = new List<FaceBookProf>();
    
        static void Main(string[] args) {
        
    
        FaceBookProf firstProfile = new FaceBookProf();

        firstProfile.FirstName = "Tristan";
        firstProfile.LastName = "Auer";
        firstProfile.Education = "IUPUI";
        firstProfile.DateOfBirth = new DateTime(1998, 09, 13);
        firstProfile.Gameing = GameingSystem.Nintendo;

        Console.WriteLine(firstProfile.GetFullDescription(firstProfile));
        Console.ReadLine();

        }

    }

}
