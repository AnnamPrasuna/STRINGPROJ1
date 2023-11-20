using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STRINGPROJ1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            String s1 = "hi";
            string s2 = " Hello Good morning Hello ";

            //concat method 
            String s3 = String.Concat(s1,"prasuna how are you");
            Console.WriteLine(s3);

            //Compare(string,string) will return integer 
            int CompareStatus = string.Compare(s1,s2);
            Console.WriteLine(CompareStatus);


            //compare to method will compare two strings it will return 0 for true and 1 for false

            int i1 = s2.CompareTo(s1);
            Console.WriteLine(i1);

            //contains method will checks whether the specified character or string is exists or not  it will return boolean value
            bool b = s2.Contains(s1);
            Console.WriteLine(b);

            //Endswith method will checks the specified character will ends the string or not
            bool b1=s1.EndsWith("h");
            Console.WriteLine(b1);

            //create a clone of s1 return type is object
            String s4=(String)s1.Clone();
            Console.WriteLine("clone of a string s1 "+s4);

            //indexof will return the index position of first occurence of specified character
           int indexPos =s2.IndexOf('i');
            Console.WriteLine(indexPos);

            //Equals method will compare two strings will return boolean value
            bool boolEquals=s1.Equals(s2);
            Console.WriteLine( boolEquals);

            //insert the string or character at the specified position: insert method present in stringBuilder
            StringBuilder sb = new StringBuilder(s1);
            sb.Insert(2," prasuna");
            Console.WriteLine(sb);

            //convert into lower
           String ToLowerString= s1.ToLower();
            Console.WriteLine(ToLowerString);


            //convert into upper
            String ToUpperString=s1.ToUpper();
            Console.WriteLine(ToUpperString);

            //Last Index position of the specified string
            char targetChar = 'o';
            int lastCharIndex = s2.LastIndexOf(targetChar);
            Console.WriteLine("Last Index of '" + targetChar + "': " + lastCharIndex);

            //Length is a string property it returns length of a string
            Console.WriteLine("Length of a string is " + s2.Length);

            //Remove method will remove all the characters until the specified index
            String AfterRemove= s2.Remove(0, s2.Length-6);
            Console.WriteLine("after removing of a string :"+AfterRemove);

            //Replace method
            String AfterReplace = s2.Replace("o","p");
            Console.WriteLine(AfterReplace);

            //split method
            String[] StrArr = s2.Split(' ');
            Console.WriteLine( "after splitting the characters");
            for (int i = 0; i < StrArr.Length; i++)
            {
                Console.WriteLine(StrArr[i]);
            }
            //startswith it checks whether the first character of a string is same as the specified character
            bool status= s2.StartsWith("H");
            Console.WriteLine(status);
            Console.WriteLine();

            //substring method in the first argument index starts position and the second argument number of characters.
            Console.WriteLine(s2);
            String subString1=s2.Substring(0,10);
            Console.WriteLine(subString1);

            //Tochararry method will convert string into character array
            Console.WriteLine( "after converting into character array:-");
            char[] ch = s2.ToCharArray();
            for (int i = 0;i < ch.Length;i++) {
                Console.WriteLine(ch[i]+" ");
            }

            //Trim() wil remove the white spaces at the edges of the corner
            Console.WriteLine(s2.Trim());

            //Formatted string It is used to replace one or more format items in a specified string with the string representation of a specified object.
            String FormattedString = String.Format("{0} my name is prasuna", s1);
            Console.WriteLine( FormattedString);

            //get hashCode method
            int hc1=s1.GetHashCode();
            Console.WriteLine(hc1);

            string originalString = "hell097777o";
            string normalizedString =originalString.Normalize(NormalizationForm.FormD);
            Console.WriteLine(normalizedString);

            //it checks whether the given string is null or empty
            String s = "";
          bool status2= String.IsNullOrEmpty(s);
            Console.WriteLine(status2);

            //get the type of an instance
            Console.WriteLine(s.GetType());

            //It is used to retrieve the system's reference to the specified String.
            string str1 = "Hello C#";
            string str2 = string.Intern(str1);
            Console.WriteLine(str2);



            Console.ReadKey();
        }
    }
}
