
public class Program
{
    public static void Main(string[] args)
    {
        //true
        int[][] arr = new int[9][]
        {
            new int[] {5, 3, 4, 6, 7, 8, 9, 1, 2},
            new int[] {6, 7, 2, 1, 9, 5, 3, 4, 8},
            new int[] {1, 9, 8, 3, 4, 2, 5, 6, 7},
            new int[] {8, 5, 9, 7, 6, 1, 4, 2, 3},
            new int[] {4, 2, 6, 8, 5, 3, 7, 9, 1},
            new int[] {7, 1, 3, 9, 2, 4, 8, 5, 6},
            new int[] {9, 6, 1, 5, 3, 7, 2, 8, 4},
            new int[] {2, 8, 7, 4, 1, 9, 6, 3, 5},
            new int[] {3, 4, 5, 2, 8, 6, 1, 7, 9}
        };
        
        // false
        int[][] array = new int[9][];
        array[0] = new int[] { 5, 3, 4, 6, 7, 8, 9, 1, 2 };
        array[1] = new int[] { 6, 7, 2, 1, 9, 0, 3, 4, 8 };
        array[2] = new int[] { 1, 0, 0, 3, 4, 2, 5, 6, 0 };
        array[3] = new int[] { 8, 5, 9, 7, 6, 1, 0, 2, 0 };
        array[4] = new int[] { 4, 2, 6, 8, 5, 3, 7, 9, 1 };
        array[5] = new int[] { 7, 1, 3, 9, 2, 4, 8, 5, 6 };
        array[6] = new int[] { 9, 0, 1, 5, 3, 7, 2, 1, 4 };
        array[7] = new int[] { 2, 8, 7, 4, 1, 9, 6, 3, 5 };
        array[8] = new int[] { 3, 0, 0, 4, 8, 1, 1, 7, 9 };
        var x = ValidSolution(array);
        Console.WriteLine(x);
    }
    public static bool ValidSolution(int[][] board)
    {
        // check rows
        for (int row = 0; row < 9; row++)
        {
            int[] nums = new int[10];
            for (int col = 0; col < 9; col++)
            {
                int num = board[row][col];
                if (num < 1 || num > 9 || nums[num] == 1)
                {
                    return false;
                }
                nums[num] = 1;
            }
        }

        // check cols
        for (int col = 0; col < 9; col++)
        {
            int[] nums = new int[10];
            for (int row = 0; row < 9; row++)
            {
                int num = board[row][col];
                if (num < 1 || num > 9 || nums[num] == 1)
                {
                    return false;
                }
                nums[num] = 1;
            }
        }

        // check blocks
        for (int block = 0; block < 9; block++)
        {
            int[] nums = new int[10];
            for (int row = (block / 3) * 3; row < (block / 3) * 3 + 3; row++)
            {
                for (int col = (block % 3) * 3; col < (block % 3) * 3 + 3; col++)
                {
                    int num = board[row][col];
                    if (num < 1 || num > 9 || nums[num] == 1)
                    {
                        return false;
                    }
                    nums[num] = 1;
                }
            }
        }

        return true;
    }


}