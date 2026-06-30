//addition of two matrices
// int[,] arr1 ={
//                 {1, 2, 3},
//                 {4, 5, 6}
//               };

// int[,] arr2 ={
//                 {7, 8, 9},
//                 {10, 11, 12}
//              };
            

// int [,]result=new int[2,3];
// for (int i = 0; i < 2; i++)
// {
//     for (int j = 0; j < 3; j++)
//     {
//         result[i, j] = arr1[i, j] + arr2[i, j];
//     }
// }


//transpode matrix
// int[,] matrix =
//         {
//             {1, 2, 3},
//             {4, 5, 6},
//             {7, 8, 9}
//         };

//         int rows = matrix.GetLength(0);
//         int cols = matrix.GetLength(1);

//         int[,] transpose = new int[cols, rows];

//         // Create transpose
//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < cols; j++)
//             {
//                 transpose[j, i] = matrix[i, j];
//             }
//         }

//         // Print transpose
//         Console.WriteLine("Transpose Matrix:");

// for (int i = 0; i < cols; i++)
// {
//     for (int j = 0; j < rows; j++)
//     {
//         Console.Write(transpose[i, j] + "\t");
//     }
//     Console.WriteLine();
// }


//muliply two matrices

        int[,] A =
        {
            {1,2,3},
            {4,5,6}
        };

        int[,] B =
        {
            {7,8},
            {9,10},
            {11,12}
        };

        int rowsA = A.GetLength(0);
        int colsA = A.GetLength(1);

        int rowsB = B.GetLength(0);
        int colsB = B.GetLength(1);

        int[,] result = new int[rowsA, colsB];

        for(int i = 0; i < rowsA; i++)
        {
            for(int j = 0; j < colsB; j++)
            {
                for(int k = 0; k < colsA; k++)
                {
                    result[i, j] += A[i, k] * B[k, j];
                }
            }
        }

        for(int i = 0; i < rowsA; i++)
        {
            for(int j = 0; j < colsB; j++)
            {
                Console.Write(result[i, j] + "\t");
            }
            Console.WriteLine();
        }





      
    
