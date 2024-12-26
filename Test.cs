namespace workspace;
class Test
{
    static void Main(string[] args)
    {
        // 練習
        string flg = "No";
        string input1 = Console.ReadLine();
        string input2 = Console.ReadLine();
        string[] stringArray1 = input1.Split(' ');
        string[] stringArray2 = input2.Split(' ');
        for (int i = 0 ;i < int.Parse(stringArray1[0]); i++){
            if (stringArray1[1].Equals(stringArray2[i])) {
                flg = "Yes";
                break;
            }
        }
        Console.WriteLine(flg);
    }
}
