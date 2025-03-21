using System;

class Test
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        Console.WriteLine(3+3);

        //string name = "Arif";
        //Console.WriteLine(name);

        int myNum = 100;
        myNum = 101;
        Console.WriteLine(myNum);

        const int myValue = 15;
        Console.WriteLine(myValue);

       string firstName = "John";
       Console.WriteLine("Hello " + firstName);

       int x = 5, y = 6, z = 7;
       Console.WriteLine(x+y+z);

       int myInt = 9;
       double myDouble = myInt;
       Console.WriteLine("myInt value:" + myInt);
       Console.WriteLine("myDouble Value:" +myDouble);

       double myDoubleValue = 10.78;
       int myIntValue = (int) myDoubleValue;
       Console.WriteLine("myDoubleValue:" + myDoubleValue);
       Console.WriteLine("myIntValue:" + myIntValue);

       //Console.WriteLine("Enter the Age:");
       //int age = Convert.ToInt32(Console.ReadLine());
      // Console.WriteLine("Age:" + age);

       int xx = 5;
       int yy = 2;
       Console.WriteLine(xx % yy);

       int m = 5;
       m += 3;
       Console.WriteLine("m:" +m);

       Console.WriteLine("Maximum Value:" + Math.Max(5,10));
       Console.WriteLine("Minimum Value:" + Math.Min(5,10));
       Console.WriteLine("Squre Value:" + Math.Sqrt(64));
       Console.WriteLine("Absolute Value:" + Math.Abs(-5.7));
       Console.WriteLine("Round Value:" + Math.Round(9.99));

       string greeting = "Hello";
       Console.WriteLine("greeting:"+ greeting);
       string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
       Console.WriteLine("The length of the String:" + txt.Length);
       string txt1 = "Hello World";
       Console.WriteLine(txt1.ToUpper());
       Console.WriteLine(txt1.ToLower());

       string fName = "Arif";
       string lName = "Islam";
       string name = fName+" "+lName;
       string name1 = string.Concat(fName,lName);
       Console.WriteLine("concat function name:" + name);
       Console.WriteLine("concation Name:" + name);
       string name2 = $"My full name is: {fName} {lName}";
       Console.WriteLine("String Interpolation:" + name2);
       string myString = "Hello";
       Console.WriteLine(myString[0]);
       Console.WriteLine(myString[1]);
       Console.WriteLine(myString.IndexOf("l"));

       string fullName ="Arif Islam";
       Console.WriteLine(fullName.Substring(5));

       string specialTxt = "I am \"Arif islam \" ";
       string specialTxt1 = "I am \'Arif islam \' ";
       string specialTxt2 = "I am \\'Arif islam \' ";
       Console.WriteLine("Special Character" + specialTxt);
       Console.WriteLine("Special Character1" + specialTxt1);
       Console.WriteLine("Special Character2" + specialTxt2);

       bool isCharpFun = true;
       bool isFishTasty = false;
       Console.WriteLine(" Boolean Data Type:" + isCharpFun);
       Console.WriteLine(" Boolean Data Type:" + isFishTasty);

       int a = 10;
       int b = 9;
       Console.WriteLine(a > b);
       Console.WriteLine(a < b);

       if(a < b){
        Console.WriteLine("a is greater than b");
       }
       else{
        Console.WriteLine("a is not greater than b");
       }

 
       int day = 5;
       switch(day){
         case 1:
         Console.WriteLine("saterday");
         break;
         case 2:
         Console.WriteLine("sunday");
         break;
         case 3:
         Console.WriteLine("monday");
         break;
         case 4:
         Console.WriteLine("Thuesday");
         break;
         case 5:
         Console.WriteLine("wednesday");
         break;
         case 6:
         Console.WriteLine("thursday");
         break;
         case 7:
         Console.WriteLine("friday");
         break;
       }


       for(int i = 0; i <= 10; i++){
         Console.WriteLine("i::" + i);
       }

       int n = 0;
       while(n < 5){
         Console.WriteLine("While Loop:" + n);
         n++;
       }

    string[] cars = { "volvo","bmw","audi","ford"};
    cars[1] = "Toyata";
    Array.Sort(cars);
    Console.WriteLine("cars:" + cars[1]);
    Console.WriteLine("length of array:" + cars.Length);

    foreach(string i in cars){
        Console.WriteLine("Foreach Cars Value:"+i);
    }
    for(int i = 0; i< cars.Length; i++){
        Console.WriteLine("For Loop Value:" + cars [i]);
    }







    }
}