using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Issue8735
{
    public class Class1
    {
        public string JoinNames(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }

    }
}