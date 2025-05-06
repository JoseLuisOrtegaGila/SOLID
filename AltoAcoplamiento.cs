using System;

namespace HighCouplingExample
{
    public enum Gender { M, F }

    public class Person
    {
        public string FirstName { get; }
        public string LastName { get; }
        public Gender Gender { get; }
        public DateTime Birthdate { get; }

        public Person(string firstName, lastName, Gender gender, DateTime birthdate)
        {
            FirstName = firstName;
            LastName = LastName;
            Gender = gender;
            Birthdate = birthdate;
        }
    }

    public class User : Person
    {
        public string Email { get; }
        public string Role { get; }
        private DateTime LastAccess { get; set; }

        public User(string email, string role, string firstname,string LastName, Gender gender, DateTime birthdate)
            : base(firstName,LastName, gender, birthdate)
        {
            Email = email;
            Role = role;
            LastAccess = DateTime.Now;
        }

        public bool CheckCredentials()
        {
            return true;
        }
    }

    public class UserSettings : User
    {
        public string WorkingDirectory { get; }
        public string LastFolderOpen { get; }

        public UserSettings(string workingDirectory, string lastFolderOpen, string email, string role, string name, Gender gender, DateTime birthdate)
            : base(email, role, firstName, lastName, gender, birthdate)
        {
            WorkingDirectory = workingDirectory;
            LastFolderOpen = lastFolderOpen;
        }
    }

    class Program
    {
        static void Main()
        {
            var userSettings = new UserSettings(
                "/usr/home",
                "/development",
                "fernando@google.com",
                "F",
                "Fernando",
                "Pelaez",
                Gender.M,
                new DateTime(1985, 10, 21)
            );

            Console.WriteLine($"User: {userSettings.Name}, Email: {userSettings.Email}, Credentials Valid: {userSettings.CheckCredentials()}");
        }
    }
}
