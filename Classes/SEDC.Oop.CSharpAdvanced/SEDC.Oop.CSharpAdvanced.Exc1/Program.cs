// See https://aka.ms/new-console-template for more information

using SEDC.Oop.CSharpAdvanced.Exc1;
using SEDC.Oop.CSharpAdvanced.Exc1.Interfaces;

ITeacher teacher1 = new Teacher();
ITeacher teacher2 = new Teacher();

IStudent student1 = new Student();
IStudent student2 = new Student();

teacher1.PrintUser();
teacher2.PrintUser();

student1.PrintUser();
student2.PrintUser();

IUser user1 = new Teacher();
ITeacher user2 = new Teacher();
User user3 = new Teacher();
