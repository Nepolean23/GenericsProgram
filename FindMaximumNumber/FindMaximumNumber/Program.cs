using FindMaximumNumber;
using System.Xml;//*MaximumIntengersNumbers
//int intoutput=UC_1.MaximumIntengersNumbers(1,2,3);
//Console.WriteLine(intoutput);
//*MaximumFloatNumbers
//double doubleoutput=UC_2.MaximumNumbers(1.1,2.1,3.1);
//Console.WriteLine(doubleoutput);
//*MaximumStringNumbers
 //string stringoutput = UC_3.MaximumStringNumbers("Apple", "Peach", "Bananna");
//Console.WriteLine(stringoutput);
//*Generics methods
//int  intoutput=Refactor1.MaximumNumbers<int>(1,2,3);
//Console.WriteLine(intoutput);
//double doubleoutput = Refactor1.MaximumNumbers<double>(187, 195, 298);
//Console.WriteLine(doubleoutput);
//string stringoutput = Refactor1.MaximumNumbers<string>("Tiger", "Lion", "Elephant");
//Console.WriteLine(stringoutput);
//*Generics class
//int intoutput=Refactor2<int>.MaximumNumbers(100,200,300);
//Console.WriteLine(intoutput);
//double doubleoutput = Refactor2<double>.MaximumNumbers(35.9, 59.4, 98.5);
//Console.WriteLine(doubleoutput);
//string stringoutput = UC_4<string>.MaximumNumbers("Pen", "Scale", "Sharpner");
//Console.WriteLine(stringoutput);
//*Generics Method Which Called Internaly To Test MaximumVlaue
int[] arr = {100,200,300,400,500};
UC_5<int>generic=new UC_5<int>(arr);
generic.PrintMaxValue();