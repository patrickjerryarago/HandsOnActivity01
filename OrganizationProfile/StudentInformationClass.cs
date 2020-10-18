using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationProfile
{
    public delegate string Info(string arg);


    class StudentInformationClass
    {
        public static long SetStudentNo = 0;
        public static long SetContactNo = 0;
        public static int SetAge;
        public static string SetGender = "";
        public static string SetProgram = "";
        public static string SetBirthday = "";
        public static string SetFullName = "";
    }
}
