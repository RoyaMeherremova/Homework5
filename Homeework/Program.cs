


//using DLL;

//AccountService accountService = new AccountService();

//accountService.Login();


//using Homeework;

//Person person = new Person();
//person.Name = "Cemil";
//person.Age = 26;
//person.Surname = "Cemilov";

//Person person2 = new Person();
//person2.Name = "Pervin";
//person2.Age = 23;
//person2.Surname = "Velizade";



//Person[] arr = { person, person2 };

//GetPersonsByAge(arr);
//static void GetPersonsByAge(Person[] arr)
//{
//	foreach (var item in arr)
//	{
//		if (item.Age > 20)
//		{
//			Console.WriteLine($"{item.Name}- {item.Age} -{item.Surname}");
//		}
//	}
//}


//string search = "J";
//Search(search); 
//static void Search(string search)
//{
//	Student[] arr = GetStudent();
//	bool isExist = false;

//	foreach (var item in arr)
//	{
//		if (item.Name.ToLower().Contains(search.ToLower()) || item.Surname.ToLower().Contains(search.ToLower()))
//		{
//			Console.WriteLine(item.Name + " " + item.Surname);
//			isExist = true;
//		}	

//	}
//	if(!isExist)
//	{
//		Console.WriteLine("not found");
//	}
//}

//static Student[]GetStudent()
//{
//Student student = new Student();
//student.Name="Cemil";
//student.Surname = "Velizade";
//student.Age = 26;
//student.Addres = "Xetai";

//Student student1 = new Student();
//student1.Name = "Celal";
//student1.Surname = "Abdullayev";
//student1.Age = 23;
//student.Addres = "Baku";
//Student student2 = new Student();
//student2.Name = "Mirze";
//student2.Surname = "Memmedli";
//student2.Addres = "Sumqayit";
//student2.Age = 21;
//	Student[] arr= { student, student1, student2 };
//	return arr;
//}



using Homeework;
using Service;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

////Calculator calculator = new Calculator();
////calculator.Calculat();



//static Employee[] GetEmployee()
//{

//    Employee employee1 = new Employee();
//    employee1.Salary = 1100;
//    employee1.Name = "Selale";
//    employee1.Surname = "Ibadova";
//    employee1.Age = "23 yas";


//    Employee employee2 = new Employee();
//    employee2.Salary = 1500;
//    employee2.Name = "Ayse";
//    employee2.Surname = "Celilova";
//    employee2.Age = "26 yas";


//    Employee employee3 = new Employee();
//    employee3.Salary = 1800;
//    employee3.Name = "Tural";
//    employee3.Surname = "Qasimzade";
//    employee3.Age = "29 yas";

//    Employee employee4 = new Employee();
//    employee4.Salary = 1000;
//    employee4.Name = "Kenan";
//    employee4.Surname = "Velizade";
//    employee4.Age = "31 yas";


//    Employee employee5 = new Employee();
//    employee5.Salary = 1300;
//    employee5.Name = "Eli";
//    employee5.Surname = "Memedli";
//    employee5.Age = "35 yas";
//    Employee[] arr = { employee1, employee2, employee3, employee4, employee5 };
//    return arr;
//}



//Searchh(1000, 2000);
//static void Searchh(int n, int m)
//{
//    Employee[] arr = GetEmployee();
//    foreach (var item in arr)
//    {
//        if (item.Salary > n && item.Salary < m)
//        {
//            Console.WriteLine($"{item.Name}-{item.Surname}-{item.Age}");
//        }

//    }
//}

//static Doctor[] GetDoctors()
//{
    
//    Doctor doctor1 = new Doctor();
//    doctor1.Name = "Ibrahim";
//    doctor1.Surname = "Kerimov";
//    doctor1.Addres = "Baku";
//    doctor1.BirthDay = new DateTime(2000, 05, 04);
    
//    Doctor doctor2 = new Doctor();
//    doctor2.Name = "Cavid";
//    doctor2.Surname = "Veliyev";
//    doctor2.Addres = "Ehmedli";
//    doctor2.BirthDay = new DateTime(1999, 09, 10);

//    Doctor doctor3 = new Doctor();
//    doctor3.Name = "Mehemmed";
//    doctor3.Surname = "Qasimzade";
//    doctor3.Addres = "Quba";
//    doctor3.BirthDay =new DateTime (1995, 07, 08 );

//    Doctor doctor4 = new Doctor();
//    doctor4.Name = "Kerim";
//    doctor4.Surname = "Seyidli";
//    doctor4.Addres = "Qubadli";
//    doctor4.BirthDay = new DateTime(1996, 10, 08);

//    Doctor doctor5 = new Doctor();
//    doctor5.Name = "Ehmed";
//    doctor5.Surname = "Quliyev";
//    doctor5.Addres = "Novxani";
//    doctor5.BirthDay = new DateTime(2012, 11 , 26);

//    Doctor[] arr = { doctor1, doctor2, doctor3, doctor4, doctor5 };
//    return arr;

//}



//Getinformation(new DateTime(1993, 05, 25),new DateTime(2002, 12, 15));
//static void Getinformation(DateTime n, DateTime m)
//{
//    Doctor[] arr = GetDoctors();
//    foreach (var item in arr)
//    {
//        if (item.BirthDay>n && item.BirthDay<m)
//        {
//            Console.WriteLine($"{item.Name}-{item.Surname}-{item.Addres}");
//        }
//    }



//}




//CustomMath customMath = new CustomMath();

////customMath.Factorial(10);
//int[] arr = { 2, 4, 6, 7, 9, 5, 3,11 };
//customMath.Array(arr);