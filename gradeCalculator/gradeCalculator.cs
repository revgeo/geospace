using System;
// Problem description: Your instructor needs to calculate individual student grades for another class.

// Requirements/User stories:

// The instructor will provide the number of students for which grades need to be calculated.  This number must be at least one.
// For each student, the instructor will provide five homework grades, three quiz grades, and two exam grades.  All grades must be between 0 and 100 inclusively.
// A student's final grade average is calculated by adding together 50% of the homework average, 30% of the quiz average and 20% of the exam average.
// A student's final grade is calculated  based on the final grade average.  If it is 90% or greater, it is an A; 80% or better is a B; 70% or better is a C; 60% or better is a D; and anything less than 60% is an F.
// Once calculated, the program will display the student's name, homework average, quiz average, exam average, final average and final grade.

// MAKE METHODS
// --to collect int get int >= 1 || int <= 100
// --to average collected ints ToDouble


// Prompt 
//Number of strudents
//--validate number >=1 ***


// for () loops to display
// --send students to method
// --assign students to array?
// --send grade int to method
// --send average double
// --assign

// (maybe)
// either method or in a loop 
// --assign collected strings && ints to lists, convert lists to arrays?

namespace gradeCalculator
{
    class Program
    {
//methods area
        static bool GreaterThanZero(int checkValue)
        {
            return checkValue >= 1;
        }
        static bool GradeValidation(int checkGrade)
        {
            return checkGrade >= 0 && checkGrade <= 100;
        }

        // static int GradeCollector (string gradeCount)
        // {
        //     var gradeTotal = 0;
        //     var validGradeCount = false;
        //     do 
        //     {
        //         gradeCount = Convert.ToInt32(Console.ReadLine());
        //         validGradeCount = GreaterThanZero(gradeCount);
        //     }while (!validGradeCount);

        //     int[] totalGradeCount = new int[gradeCount];
            
        //     var gradeEntry = 0;
        //     var validGrade = false;
        //     var arrayElement = 0;
        //     for (var gradeAssignment = 0; gradeAssignment < gradeCount;  gradeAssignment++)
        //     {
        //         do
        //         {
        //             Console.Write("Please enter the grade : ");
        //             gradeEntry = Convert.ToInt32(Console.ReadLine());
        //             validGrade = GradeValidation(gradeEntry);
        //         }while (!validGrade);
        //         totalGradeCount[arrayElement] = gradeEntry;
        //         arrayElement++;

        //         gradeTotal = gradeEntry;
        //     }
        //     return (gradeTotal);
        // }

//end Methods
        static void Main(string[]args)
        {
            var numberOfStudents = 0;
            var validStudentCount = false;
            Console.WriteLine("Hello, Welcome to the Student Grade Calculator!");
            
            do
            {
                Console.Write("Please enter the number of students you'll be grading today (minimum of 1) : ");
                numberOfStudents = Convert.ToInt32(Console.ReadLine());
                validStudentCount = GreaterThanZero(numberOfStudents);
            }while (!validStudentCount);

//name collection from user
//            Console.WriteLine("Great! Let's start ");
           

            int[] studentCount = new int[numberOfStudents];
            // Console.WriteLine(studentCount.Length);
            Console.WriteLine("Let's start by getting the students' homework grades.");
            var gradeCount = 0;
            var validGradeCount = false;

//start of method            
            do 
            {
                Console.Write("How many grades are there to enter? (minimum of 1) : ");
                gradeCount = Convert.ToInt32(Console.ReadLine());
                validGradeCount = GreaterThanZero(gradeCount);
            }while (!validGradeCount);

            int[] totalGradeCount = new int[gradeCount];
            
            var gradeTotal = 0;
            
            var gradeEntry = 0;
            var validGrade = false;
            var arrayElement = 0;
            for (var gradeAssignment = 0; gradeAssignment < gradeCount;  gradeAssignment++)
            {
                do
                {
                    Console.Write("Please enter the grade : ");
                    gradeEntry = Convert.ToInt32(Console.ReadLine());
                    validGrade = GradeValidation(gradeEntry);
                }while (!validGrade);
                totalGradeCount[arrayElement] = gradeEntry;
                arrayElement++;

                gradeTotal = gradeEntry;
            }
            //end of method            

            Console.WriteLine("My homework averages : " + gradeTotal / gradeCount);
            var homeworkAverage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Next, let's enter by the students' homework grades.");
            // do
            // {
            //     Console.Write("How many assingments are there to grade? (minimum of 1) : ");
            //     homeworkCount = Convert.ToInt32(Console.ReadLine());
            //     validHomeworkCount = GreaterThanZero(homeworkCount);
            // }while (!validHomeworkCount);

            // int[] homeworkGrades = new int[homeworkCount];
            

            // int homeworkTotal = 0;
            
            // int homeworkGrade;
            // var validGrade = false;
            // int arrayElement=0;
            // for (var homeworkAssignment = 0; homeworkAssignment < homeworkCount;  homeworkAssignment++)
            // {
            //     do
            //     {
            //         Console.Write("Please enter the grade : ");
            //         homeworkGrade = Convert.ToInt32(Console.ReadLine());
            //         validGrade = GradeValidation(homeworkGrade);
            //     }while (!validGrade);
            //     homeworkGrades[arrayElement] = homeworkGrade;
            //     arrayElement++;

            //     homeworkTotal = homeworkGrade;
            // }
            // Console.WriteLine("My homework averages : " + homeworkTotal / homeworkCount);
            // var homeworkAverage = Convert.ToInt32(Console.ReadLine());
            

            // Console.WriteLine(homeworkGrades.Length);

            // foreach (int assignmentGrade in homeworkGrades)
            // {
            // Console.WriteLine(assignmentGrade);
            // }
            // Console.WriteLine(homeworkGrades
            //     do
            //     {
            //         var listNumber = 1;
            //         var listItem = 0;
            //         var validGrade = false;
            //         do
            //         {
            //         Console.Write($"Please enter student grade {listNumber} : ");
            //         listItem = Convert.ToInt32(Console.ReadLine());
            //         validGrade = GradeValidation(listItem);
            //         } while (!validGrade);
            //         listNumber++;
            //     }
            // }homeworkGrades[0] = (listItem);
            
            //for 
            
            // do
            // {
            //     Console.Write("Please enter student's grade (0 - 100 inclusive): ");
            //     grade = Convert.ToInt32(Console.ReadLine());
            //     validGradeRange = GradeValidation(grade);
            // }while (!validGradeRange);



            

            Console.ReadKey();

        }//main

    }//class

}//namespace