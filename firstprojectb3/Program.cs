// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int a = 5;
int b = 3;
if (a + b > 10)
	Console.WriteLine("The answer is greater than 10");
else if(a + b < 10)
	Console.WriteLine("The answer is not greater than 10");
else
    Console.WriteLine("default answer");

 void str()
 {
	Console.WriteLine("hello str function here");
}
str();

void add(int i, int j)
{
	int k = i + j;
    Console.WriteLine(k);
}
add(4, 5);

//public class students
//{
//	public void fullname()
//	{
//        Console.WriteLine("std1");
//    }

//object std1 = new students();

//std1.fullname();
//}


//string fullname()
//{
//    return "Ali";
//}
//string name = fullname();
//Console.WriteLine(name);
//string SayHi(string name)
//{
//	return $"Hi {name}";
//}
//static string GetText(string path, string filename)
//{
//	var reader = File.OpenText($"{AppendPathSeparator(path)}{filename}");
//	var text = reader.ReadToEnd();
//	return text;

//	string AppendPathSeparator(string filepath)
//	{
//		return filepath.EndsWith(@"\") ? filepath : filepath + @"\";
//	}
//}
////int[] scores = new int[5];
//int[] scores = { 1, 2, 3, 4 };
//Console.WriteLine(scores[2]);


// ternary operator

int x = 4;
int y = 5;

object stat = (x > y) ? "x is greater than y" : 5;
Console.WriteLine(stat);

var n = null ?? "university";
Console.WriteLine(n);

int u = 0;

//while(u <= 10)
//{
//	u++;
//    Console.WriteLine(u);
//}

Console.WriteLine("for loop");

for(int i = 0; i < 10; i++)
{
	if(i % 2 == 0)
	{
		continue;
	}
    Console.WriteLine($"Ebad Uddin ahmed {i}");
}




//do
//{
//	Console.WriteLine(u);
//	u++;
//} while (u < 11);

// Arrays


int[] marks = new int[4];
marks[0] = 60;
marks[1] = 90;
marks[2] = 89;
marks[3] = 98;

string[] names = new string[4] { "Ali", "Usama", "Salman", "Talha" };
Array.Sort(names);
Array.Reverse(names);
Console.WriteLine(marks[2]);

//for(int i = 0;i < 4; i++)
//{
//	Console.WriteLine($"index {i}). {names[i]}");
//}

Console.WriteLine(marks.Length);
Console.WriteLine(marks.Min());
Console.WriteLine(marks.Max());
Console.WriteLine(marks.Contains(87));

// multidimensional 2D array

int[,] arr2D = new int[2,3] { 
	{ 2, 3, 4 }, 
	{ 5, 6, 7 },
	
};

int row = arr2D.GetLength(0);
int col = arr2D.GetLength(1);

//for(int i = 0; i < row; i++)
//{
//	for(int j = 0; j < col; j++)
//	{
//		Console.WriteLine(arr2D[i,j]);
//    }
//}
foreach (var value in arr2D)
{
    Console.WriteLine(value);
}


Console.WriteLine(row + "and" +  col);

// 3D Array

int[,,] arr3D = new int[3,2,3]  {
	{ 
		{ 2, 3, 4 },
		{ 5, 6, 7 },

	},
	{
		{ 2, 3, 4 },
		{ 5, 6, 7 },
		
	},
	{
		{ 2, 3, 4 },
		{ 5, 6, 7 },
	}

};
Console.WriteLine("3D array");
int row3d = arr3D.GetLength(0);
int each_arr_row = arr3D.GetLength(1);
int col3d = arr3D.GetLength(2);

foreach (var item in arr3D)
{
    Console.WriteLine(item);
}

Console.WriteLine(row3d + "and" + col3d + "lastindex" + each_arr_row + "length" + arr3D.Length);

// Jagged Array

Console.WriteLine("Jagged Array");

int[][] jagged_array = new int[3][];

jagged_array[0] = new int[] { 1,2};
jagged_array[1] = new int[] { 3,4,5};
jagged_array[2] = new int[] { 1,5};

Console.WriteLine(jagged_array[1][1]);




























