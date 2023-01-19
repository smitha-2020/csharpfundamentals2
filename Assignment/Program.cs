class Program
{

    static void Main(string[] args)
    {
        //Challenge 1
        int[][] arr1 = { new int[] { 1, 2 }, new int[] { 2, 1, 5 } };
        int[] arr1Common = CommonItems(ref arr1); //implemented using List and Arrays
        /* write method to print arr1Common */
        for (int s = 0; s < arr1Common.Length; s++)
        {
            Console.WriteLine(arr1Common[s]);
        }

        //Challenge 2
        int[][] arr2 = { new int[] { 1, 2 }, new int[] { 1, 2, 3 } }; 
        InverseJagged(arr2); // return type of the method is declared as void,data displayed in the method.
        /* write method to print arr2 */

        //Challenge 3
        int[][] arr3 = { new int[] { 1, 2 }, new int[] { 1, 2, 3 } };
        CalculateDiff(ref arr3); // return type of the method is declared as void,data displayed in the method.
        /* write method to print arr3 */

        //Challenge 4
        // int[,] arr4 = { { 1, 2, 3 }, { 4, 5, 6 } };
        // int[,] arr4Inverse = InverseRec(arr4);
        /* write method to print arr4Inverse */

        //Challenge 5
        // Demo("hello", 1, 2, "world");

        //Challenge 6

        //Challenge 7
        // string firstName, middleName, lastName;
        // ParseNames("Mary Elizabeth Smith", firstName, middleName, lastName);
        // Console.WriteLine($"First name: {firstName}, middle name: {middleName}, last name: {lastName}");

        //Challenge 8
        //GuessingGame();
    }

    /*
    Challenge 1. Given a jagged array of integers (two dimensions).
    Find the common elements in the nested arrays.
    Example: int[][] arr = { new int[] {1, 2}, new int[] {2, 1, 5}}
    Expected result: int[] {1,2} since 1 and 2 are both available in sub arrays.
    */
    static int[] CommonItems(ref int[][] jaggedArray)
    {
        int[] newArr = new int[2];  //did not find any other solution as cannot set the array size dynamically.
        List<int> list = new List<int>();
        List<int> resultList = new List<int>();
        int counter = default;
        for (int i = 0; i < jaggedArray.Length; i++) //gives number of rows in jagged array
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                list.Add(jaggedArray[i][j]);
            }
        }
        foreach (int element in list)
        {
            if (list.IndexOf(element) != list.LastIndexOf(element))
            {
                if (!resultList.Contains(element))
                {
                    resultList.Add(element);
                    newArr[counter] = element;
                    counter++;
                }
            }
        }
        return newArr;
    }

    /* 
    Challenge 2. Inverse the elements of a jagged array.
    For example, int[][] arr = {new int[] {1,2}, new int[]{1,2,3}} 
    Expected result: int[][] arr = {new int[]{2, 1}, new int[]{3, 2, 1}}
     */
    static void InverseJagged(int[][] jaggedArray)
    {
        int counter = default;
        int[][] jagged = new int[jaggedArray.Length][];
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            counter = jaggedArray[i].Length - 1;
            int[] newJagged = new int[jaggedArray[i].Length];
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                newJagged[counter] = jaggedArray[i][j];
                counter--;
            }
            jagged[i] = newJagged;
        }
        for (int s = 0; s < jagged.Length; s++)
        {
            for (int m = 0; m < jagged[s].Length; m++)
            {
                Console.Write($"{jagged[s][m]} ");
            }
            Console.WriteLine();
        }
    }

    /* 
    Challenge 3.Find the difference between 2 consecutive elements of an array.
    For example, int[][] arr = {new int[] {1,2}, new int[]{1,2,3}} 
    Expected result: int[][] arr = {new int[] {-1}, new int[]{-1, -1}}
     */
    static void CalculateDiff(ref int[][] jaggedArray)
    {
        int[][] newJagged = new int[jaggedArray.Length][];
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            int[] newArr = new int[jaggedArray[i].Length - 1];
            for (int j = 0; j < jaggedArray[i].Length - 1; j++)
            {
                newArr[j] = jaggedArray[i][j] - jaggedArray[i][j + 1];
            }
            newJagged[i] = newArr;
        }
        for (int s = 0; s < newJagged.Length; s++)
        {
            for (int m = 0; m < newJagged[s].Length; m++)
            {
                Console.Write($"{newJagged[s][m]} ");
            }
            Console.WriteLine();
        }
    }

    /* 
    Challenge 4. Inverse column/row of a rectangular array.
    For example, given: int[,] arr = {{1,2,3}, {4,5,6}}
    Expected result: {{1,2},{3,4},{5,6}}
     */
    // static int[,] InverseRec(int[,] recArray)
    // {

    // int[][]? newJagged = default;
    //     for (int i = 0; i<jaggedArray.Length; i++)
    //     {
    //         for (int j =0;j<jaggedArray[i].Length; j++)
    //         {
    //             Console.WriteLine("Hey");
    //             newJagged = new int[jaggedArray[i].Length][];
    //             Console.WriteLine(jaggedArray[i][j]);
    //         }

    //     }

    // }

    /* 
    Challenge 5. Write a function that accepts a variable number of params of any of these types: 
    string, number. 
    - For strings, join them in a sentence. 
    - For numbers then sum them up. 
    - Finally print everything out. 
    Example: Demo("hello", 1, 2, "world") 
    Expected result: hello world; 3 */
    static void Demo()
    {

    }

    /* Challenge 6. Write a function to swap 2 objects but only if they are of the same type 
    and if they’re string, lengths have to be more than 5. 
    If they’re numbers, they have to be more than 18. */
    static void SwapTwo()
    {

    }

    /* Challenge 7. Write a function to parse the first name, middle name, last name given a string. 
    The names will be returned by using out modifier */
    // static void ParseNames(
    //     string input,
    //     out string firstName,
    //     out string middleName,
    //     out string lastName)
    // {

    // }

    /* Challenge 8. Write a function that does the guessing game. 
    The function will think of a random integer number (lets say within 100) 
    and ask the user to input a guess. 
    It’ll repeat the asking until the user puts the correct answer. */
    static void GuessingGame()
    {

    }
}
