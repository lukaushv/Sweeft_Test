using Sweeft_test;
using System.Text.Json;

string palindrome_test1 = "first test case";
string palindrome_test2 = "  ";
string palindrome_test3 = "ana";
string palindrome_test4 = "trueeurt";
string palindrome_test5 = "ananas";


int minsplit_test1 = 256;
int minsplit_test2 = 289;
int minsplt_test3 = 54;


int[] contain_test1 = { };
int[] contain_test2 = {4,6,12,0,654,-12,54 };
int[] contain_test3 = {5,2,7,75,24,1 };
int[] contain_test4 = { 0, 1, 3, 2, 76, 42 };


string proper_test1 = "(()())";
string proper_test2 = "(((";
string proper_test3 = ")))(";
string proper_test4 = "";
string proper_test5 = "()()()()()()";


int stair_test1 = 45;
int stair_test2 = 0;
int stair_test3 = 4;
int stair_test4 = 1;
int stair_test5 = 10;


Console.WriteLine("Palindrome test: ");
Console.WriteLine(Algorithms.IsPalindrome(palindrome_test4) + "\n");

Console.WriteLine("Minimal split test: ");
Console.WriteLine(Algorithms.MinSplit(minsplit_test2) + "\n");

Console.WriteLine("Array containment test: ");
Console.WriteLine(Algorithms.NotContains(contain_test4) + "\n");

Console.WriteLine("Properly test:");
Console.WriteLine(Algorithms.IsProperly(proper_test1) + "\n");

Console.WriteLine("Staircase variants test:");
Console.WriteLine(Algorithms.CountVariants(stair_test5) + "\n");

GetTeachers.PrintTeachers("გიორგი");

RestAPI.GenerateCountryDataFiles();
Console.WriteLine("Country data files generated");
