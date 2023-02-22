using System;
using static System.Console;

namespace ClubInterface
{
    class program
    {
        static void Main(string[] args)
        {
            VideoGameClub newMember = new VideoGameClub();
            newMember.Id = 10;
            newMember.FirstName = "Luxanna";
            newMember.LastName = "Crownguard";
            newMember.HoursPerWeek = 5;
            newMember.GameTypePreference = "MOBA";
            newMember.ConsolePreference = "PC";
            VideoGameClub secondMemnber= new VideoGameClub(20, "Garen", "Crownguard", "MOBA", 10, "PC");
            newMember.DisplayMember();
            secondMemnber.DisplayMember();
        }
    }

    interface IClub
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Fullname();
    }

    class VideoGameClub : IClub
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string GameTypePreference { get; set; }
        public int HoursPerWeek { get; set; }
        public string ConsolePreference { get; set; }

        public VideoGameClub() 
        {
            Id= 0;
            FirstName = "";
            LastName = "";
            GameTypePreference = "";
            HoursPerWeek = 0;
            ConsolePreference = "";
        }
        public VideoGameClub(int id, string firstName, string lastName, string gameTypePreference, int hoursPerWeek, string consolePreference)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            GameTypePreference = gameTypePreference;
            HoursPerWeek = hoursPerWeek;
            ConsolePreference = consolePreference;
        }

        public string Fullname()
        {
            return FirstName+ " " + LastName;
        }
        public void DisplayMember()
        {
            WriteLine("Member Information");
            WriteLine($"Member Id: {Id}");
            WriteLine($"Member Name: {Fullname()}");
            WriteLine($"Game Preference: {GameTypePreference}");
            WriteLine($"Hours Played Per Week: {HoursPerWeek}");
            WriteLine($"Console Preference: {ConsolePreference}");
        }

    }
}