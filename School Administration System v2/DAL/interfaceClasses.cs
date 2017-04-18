
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School_Administration_System_v2;

namespace School_Administration_System_v2.DAL
{
    public interface StudentInt
    {
        List<Student> getAllStudents();
        Student getStudent(string id);

        bool addStudent(string id);

        void updateStudent(Student student);
        void deleteStudent(Student student);
    }

    public interface AdmissionStudentInt
    {
        List<Admission_Student> getAllAdmissionStudent();
        Admission_Student getAdmissionStudent(string id);
        
        void updateAdmissionStudent(Admission_Student AdmissionStudent);
        void deleteAdmissionStudent(Admission_Student AdmissionStudent);
    }
}
