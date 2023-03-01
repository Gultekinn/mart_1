//1. Ədədlərdən ibarət arrayın elementleri cemini tapan alqoritm


//int[] array = { 1, 5, 8, 12, 24, 29 };
//int sum = 0;
//for (int i = 0; i < array.Length; i++)
//{
//    sum += array[i];

//    {
//        Console.WriteLine(sum);
//    }
//}

//2. Sozlerden ibaret arrayde uzunlugu 4-den boyuk olan sozleri ekrana çap edin
int a=4;
string[] students = { "gulu", "gunay", "lale", "nergiz", "ayde", "nezi" };
for (int i = 0; i < students.Length; i++) 
{
    if (students[i].Length>4)
    {

        Console.WriteLine(students[i]);
    }

    
}