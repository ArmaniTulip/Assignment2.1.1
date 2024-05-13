namespace Assignment2._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student myStudent = new Student();
            myStudent.StudentId = 1;
            myStudent.StudentFName = "Armani";
            myStudent.StudentLName = "Tuileepa";
            myStudent.StudentGrade = 'F';
            Console.WriteLine("Student ID is " +  myStudent.StudentId);
            Console.WriteLine("Student first name is " + myStudent.StudentFName);
            Console.WriteLine("Student last name is " + myStudent.StudentLName);
            Console.WriteLine("Student grade is " + myStudent.StudentGrade);
        }
    }


    public class Student 
    {
    
        private int _studentId;

        public int StudentId
        {
            get { return _studentId; }
            set { _studentId = value; }
  
        }
        private string _studentFName;

        public string StudentFName
        {
            get { return _studentFName; }
            set { _studentFName = value; }
        }

        private string _studentLName;

        public string StudentLName
        {
            get { return _studentLName; }
            set { _studentLName = value; }
        }

        private char _studentGrade;
        public char StudentGrade 
        {
            get { return _studentGrade; }
            set { _studentGrade = value; }
        }
       

    }

   

    

}
