using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Administration_System_v2.BL
{
    enum Group
    {
        Science = 1, Commerce, Arts, NotApplicable
    };
    public class AIUBPerson
    {
        string firstName;
        string lastName;
        string fullName;
        string gender;
        string fatherName;
        string motherName;
        string address;
        string mobile;
        string email;
        string dob;
        string bloodGroup;
        string country;
        string religion;

    }

    public class AdmissonExamResult
    {
        string writtenResult;
        string VivaResult;
        Teacher writtenExaminer;
        Teacher vivaExaminer;
    }

    public class Department
    {
        string deptName;
        string deptID;
        string responsibilities;
    }
    public enum Designation { AssistantProfessor, Professor, HeadMaster, Principle };
    public class Employee : AIUBPerson
    {
        string employeeID;
        bool maritalStatus;
        Group group;
        string prevWorkedInstitution;
        Designation designation;
        double salary;
        Department dept;
        DateTime joinedDate;
        DateTime ResignedDate;
    }

    public enum StatusTeacher { StudyLeave = 1, TemporaryLeave, Suspended, Terminated, Resigned };

    public class Teacher : Employee
    {
        StatusTeacher status;
        DateTime statusTimeFrom;
        DateTime statusTimeTo;
        DateTime lastLoginDate;
        string password;
    }

    public class Staff : Employee
    {

    }

    public class AdminBody : Employee
    {

    }

    public class Fees
    {
        string trasactionID;
        DateTime printedDate;
        double admissionFee;
        double maintenanceFee;
        double libraryFee;
        double medicalFee;
        double idCardFee;
        double developmentFee;
        double monthlyFee;
        double lateFineFee;
        string remarks;

    }



    public class AdmissionStudent : AIUBPerson
    {
        string admissionSession;
        static int totalStudent;
        static int totalEnrolled;
        string id;
        string currentSchool;
        string currentSchoolAvgMarks;
        string currentGrade;
        string interestedGrade;
        Group group;
        AdmissonExamResult admissionExamResult;
        DateTime admissionDate;
        Teacher registeredBy;
        Fees fees;

    }

    public enum StatusStudent { Active, Droped, Terminated, Passed }

    public class Student : AdmissionStudent
    {
        Grade grade;
        StatusStudent status;
        DateTime passedTime;

    }

    public class Grade
    {
        int gradeName;
        Group gradeGroup;
        List<Subjects> subjectList;

    }

    public class Schedule
    {

    }

    public class Subjects
    {
        string subjectName;
        string subjectID;
        string description;
        ClassRoom classRoom;
        public TimeSpan time;

    }
    public class ClassRoom
    {
        string classRoomID;
        string classRoomLevel;
        int size;
        //Staff assistant;
    }

    public enum Tasks { Invesilator, VivaExam, WrittenExamScriptCheck, Other };

    public class Task
    {
        string taskID;
        string description;
        string remarks;
        Tasks taskCatagory;
    }

    public class Recruit
    {
        DateTime recruitmentDate;
        string recruitSession;


    }

    public class Program
    {
        
    }
}
