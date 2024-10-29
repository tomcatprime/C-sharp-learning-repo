using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myBuddy
{
    internal class Trainee
    {

        public int pcNumber;
        public string traineeName;
        public string phoneNumber;
        public string emailId;
        public string traineeGender;
        public DateTime dateOfBirth;

        public string GetAllDetails()
        {
            return $"PC Number: {pcNumber} \nTrainee Name: {traineeName} \nPhone Number: {phoneNumber} " +
                $"\nTrainee Gender: {traineeGender} \nEmail-Id: {emailId} \nDate of Birth: {dateOfBirth}";
        }



    }
}
