using Team07.Models;
using System;
using System.Linq;

namespace Team07.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            //context.Database.EnsureCreated();

            // Look for any Degrees.
            if (context.Degrees.Any())
            {
                Console.WriteLine("Degrees already exist.");
            }
            else
            {
                var degrees = new Degree[]
                {
                    new Degree{DegreeId = 1 , DegreeAbrrev =  "ACS+2", DegreeName = "MS ACS +2" },
new Degree{DegreeId = 2 , DegreeAbrrev =  "ACS+DB", DegreeName = "MS ACS + DB"},
new Degree{DegreeId = 3 , DegreeAbrrev =  "ACS+NF", DegreeName = "MS ACS+  NF"},
new Degree{DegreeId = 4 , DegreeAbrrev =  "ACS", DegreeName = "MS ACS"},

                };
                Console.WriteLine($"Inserted {degrees.Length} new degrees.");
                foreach (Team07 d in degrees)
                {
                    context.Degrees.Add(d);
                }
                context.SaveChanges();
            }

             if (context.Requirements.Any())
            {
                Console.WriteLine("Requirements already exist.");
            }
            else
            {
                var requirement = new Requirement []
                {


                    new Requirement{ RequirementID = 460 , RequirementAbbrev = "DB" , CourseName = "44-460 Database"},
new Requirement{ RequirementID = 356 , RequirementAbbrev = "NF", CourseName = "44-356 Network Fundamentals"},
new Requirement{ RequirementID = 542 , RequirementAbbrev = "OOP" , CourseName = "44-542 Object Oriented Programming"},
new Requirement{ RequirementID = 563 , RequirementAbbrev = "Web apps" , CourseName = "44-563 Web apps"},
new Requirement{ RequirementID = 560 , RequirementAbbrev = "ADB" , CourseName = "44-560 Advance Database topics"},
new Requirement{ RequirementID = 555 , RequirementAbbrev = "NS" , CourseName = "44-555 Network Security"},
new Requirement{ RequirementID = 618 , RequirementAbbrev = "PM" , CourseName = "44-618 Project Management"},
new Requirement{ RequirementID = 1 , RequirementAbbrev = "MC" , CourseName = "Mobile Computing ios"},
new Requirement{ RequirementID = 664 , RequirementAbbrev = "UXD" , CourseName = "44-664  User Experience Design"},
new Requirement{ RequirementID = 10 , RequirementAbbrev = "E1" , CourseName = "Elective 1"},
new Requirement{ RequirementID = 20 , RequirementAbbrev = "E2" , CourseName = "Elective 2"},
new Requirement{ RequirementID = 691 , RequirementAbbrev = "GDP1" , CourseName = "GDP1"},
new Requirement{ RequirementID = 692 , RequirementAbbrev = "GDP2" , CourseName = "GDP2"},

};
                Console.WriteLine($"Inserted {requirement.Length} new reuirements.");
                foreach (Team07 d in degreeplan)
                {
                    context.Requirements.Add(d);
                }
                context.SaveChanges();
            }

            if (context.DegreePlans.Any())
            {
                Console.WriteLine("Degree Plans already exist.");
            }
            else
            {
                var degreeplan = new DegreePlan[]
                {
                    new DegreePlan{ DegreePlanId = 10 ,  DegreeID = 3 ,  StudentId = 531382 , DegreePlanAbbrev = "Super Fast" , DegreePlanName = "As Fast as I can"},
new DegreePlan{ DegreePlanId = 11 ,  DegreeID = 3 ,  StudentId = 531382 , DegreePlanAbbrev = "Slow and Easy" , DegreePlanName = "As Slow as I can"},
new DegreePlan{ DegreePlanId = 12 ,  DegreeID = 3 ,  StudentId = 531496 , DegreePlanAbbrev = "Super Fast" , DegreePlanName = "As Fast as I can"},
new DegreePlan{ DegreePlanId = 13 ,  DegreeID = 3 ,  StudentId = 531496 , DegreePlanAbbrev = "Slow and Easy" , DegreePlanName = "As Slow as I can"},
new DegreePlan{ DegreePlanId = 14 ,  DegreeID = 3 ,  StudentId = 531378 , DegreePlanAbbrev = "Slow and Easy" , DegreePlanName = "As Slow as I can"},
new DegreePlan{ DegreePlanId = 15 ,  DegreeID = 3 ,  StudentId = 531378 , DegreePlanAbbrev = "Super Fast" , DegreePlanName = "As Fast as I can"},
new DegreePlan{ DegreePlanId = 16 ,  DegreeID = 3 ,  StudentId = 534051 , DegreePlanAbbrev = "Super Fast" , DegreePlanName = "As Fast as I can"},
new DegreePlan{ DegreePlanId = 17 ,  DegreeID = 3 ,  StudentId = 534051 , DegreePlanAbbrev = "Slow and Easy" , DegreePlanName = "As Slow as I can"},
new DegreePlan{ DegreePlanId = 18 ,  DegreeID = 3 ,  StudentId = 533487 , DegreePlanAbbrev = "Slow and Easy" , DegreePlanName = "As Slow as I can"},
new DegreePlan{ DegreePlanId = 19 ,  DegreeID = 3 ,  StudentId = 533487 , DegreePlanAbbrev = "Super Fast" , DegreePlanName = "As Fast as I can"},

                };
                Console.WriteLine($"Inserted {degreeplan.Length} new degree plans.");
                foreach (DegreePlan d in degreeplan)
                {
                    context.DegreePlans.Add(d);
                }
                context.SaveChanges();
            }
            if (context.StudentTerms.Any())
            {
                Console.WriteLine("Student Terms already exist.");
            }
            else
            {
                var studentterm = new StudentTerm[]
                {
                     new StudentTerm { StudentTermId = 1 , StudentID = 531382 , Term = 1 , TermLabel = "Fall 2017" , DegreePlanId = 10}, 
 new StudentTerm { StudentTermId = 2 , StudentID = 531382 , Term = 2 , TermLabel = "Spring 2018" , DegreePlanId = 10}, 
 new StudentTerm { StudentTermId = 3 , StudentID = 531382 , Term = 3 , TermLabel = "Summer 2018" , DegreePlanId = 10}, 
 new StudentTerm { StudentTermId = 4 , StudentID = 531382 , Term = 4 , TermLabel = "Fall 2018" , DegreePlanId = 10}, 
 new StudentTerm { StudentTermId = 5 , StudentID = 531496 , Term = 1 , TermLabel = "Spring 2018" , DegreePlanId = 12}, 
 new StudentTerm { StudentTermId = 6 , StudentID = 531496 , Term = 2 , TermLabel = "Summer 2018" , DegreePlanId = 12}, 
 new StudentTerm { StudentTermId = 7 , StudentID = 531496 , Term = 3 , TermLabel = "Fall 2018" , DegreePlanId = 12}, 
 new StudentTerm { StudentTermId = 8 , StudentID = 531496 , Term = 4 , TermLabel = "Spring 2019" , DegreePlanId = 12}, 
 new StudentTerm { StudentTermId = 9 , StudentID = 531378 , Term = 1 , TermLabel = "Spring 2018" , DegreePlanId = 14}, 
 new StudentTerm { StudentTermId = 10 , StudentID = 531378 , Term = 2 , TermLabel = "Summer 2018" , DegreePlanId = 14}, 
 new StudentTerm { StudentTermId = 11 , StudentID = 531378 , Term = 3 , TermLabel = "Fall 2018" , DegreePlanId = 14}, 
 new StudentTerm { StudentTermId = 12 , StudentID = 531378 , Term = 4 , TermLabel = "Spring 2019" , DegreePlanId = 14}, 
 new StudentTerm { StudentTermId = 13 , StudentID = 531378 , Term = 5 , TermLabel = "Summer 2019" , DegreePlanId = 14}, 
 new StudentTerm { StudentTermId = 14 , StudentID = 531378 , Term = 6 , TermLabel = "Fall 2019" , DegreePlanId = 14}, 
 new StudentTerm { StudentTermId = 15 , StudentID = 534051 , Term = 1 , TermLabel = "Fall 2018" , DegreePlanId = 16}, 
 new StudentTerm { StudentTermId = 16 , StudentID = 534051 , Term = 2 , TermLabel = "Spring 2019" , DegreePlanId = 16}, 
 new StudentTerm { StudentTermId = 17 , StudentID = 534051 , Term = 3 , TermLabel = "Summer 2019" , DegreePlanId = 16}, 
 new StudentTerm { StudentTermId = 18 , StudentID = 534051 , Term = 4 , TermLabel = "Fall 2019" , DegreePlanId = 16}, 
 new StudentTerm { StudentTermId = 19 , StudentID = 533487 , Term = 1 , TermLabel = "Fall2018" , DegreePlanId = 18}, 
 new StudentTerm { StudentTermId = 20 , StudentID = 533487 , Term = 2 , TermLabel = "Spring2019" , DegreePlanId = 18}, 
 new StudentTerm { StudentTermId = 21 , StudentID = 533487 , Term = 3 , TermLabel = "Summer 2019" , DegreePlanId = 18}, 
 new StudentTerm { StudentTermId = 22 , StudentID = 533487 , Term = 4 , TermLabel = "Fall2019" , DegreePlanId = 18}, 
 new StudentTerm { StudentTermId = 23 , StudentID = 533487 , Term = 5 , TermLabel = "Spring 2020" , DegreePlanId = 18}, 
 new StudentTerm { StudentTermId = 24 , StudentID = 533487 , Term = 6 , TermLabel = "Summer 2020" , DegreePlanId = 18}, 


                };
                Console.WriteLine($"Inserted {studentterm.Length} new student terms.");
                foreach (StudentTerm d in studentterm)
                {
                    context.StudentTerms.Add(d);
                }
                context.SaveChanges();
            }
			if (context.Students.Any())
            {
                Console.WriteLine("Students already exist.");
            }
            else
            {
                var student = new Student[]
                {
					new Student{ StudentId = 531382 , First = "Sreelekha" , Last = "Vijaya" , Snumber =S531382 , 919 = 919562176},
new Student{ StudentId = 531496 , First = "Shivani Reddy" , Last = "Dodla" , Snumber =S531496 , 919 = 919565950},
new Student{ StudentId = 531378 , First = "Lokeswari" , Last = "Pittu" , Snumber =S531378 , 919 = 919563259},
new Student{ StudentId = 534051 , First = "Abhinay" , Last = "Kaitha" , Snumber =S534051 , 919 = 919570258},
new Student{ StudentId = 533487 , First = "Rakesh" , Last = "Avirineni" , Snumber =S533487 , 919 = 919568647},


                };
                Console.WriteLine($"Inserted {student.Length} new student.");
                foreach (Student d in student)
                {
                    context.Students.Add(d);
                }
                context.SaveChanges();
            }
			}}