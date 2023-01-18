using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
    internal abstract class House
    {
        // alla hus ärver härifrån. 
        public string? HouseGhost { get; set; }
        public string? Mascot { get; set; }
        public string? Members { get; set; }
        public string? Password { get; set; }
        public Gryffindor? Gryffindor { get; set; }
        public Hufflepuff? Hufflepuff { get; set; }
        public Ravenclaw? Ravenclaw { get; set; }
        public Slytherin? Slytherin { get; set; }

        //public List<House> Houses { get; set; } = new List<House>();
        //public House()
        //{
        //    wizards = new List<Wizard>();
        //}

        //public List<Member> Members { get; set; }
        //Members = new List<Member>();
        //Members = new List<Member>();
        public Wizard? Wizard { get; set; }

        //protected string? password;
        protected virtual bool HasCorrectPasswordFormat(string newPassword)
        {
            return true;

        }
        public virtual bool SetPassword(string currentPassword, string newPassword)
        {
            if (HasCorrectPasswordFormat(newPassword) && currentPassword == Password)


            {

                {
                    Password = newPassword;
                    return true;

                }
               

            }
            return false;
        }
        public virtual bool PasswordCheck(string newPassword, string currentPassword)
        {
            return SetPassword(currentPassword, newPassword);
        }
        
        //Wizard mywizard = new Wizard();
        //mywizard.Name = "Harry Potter";
        //Ravenclaw ravenclaw = new Ravenclaw();
        //Hufflepuff hufflepuff = new Hufflepuff();
        //Slytherin slytherin = new Slytherin();
        //Gryffindor gryffindor = new Gryffindor();
    }
}
