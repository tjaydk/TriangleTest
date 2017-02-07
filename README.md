# Triangle Test
####By Dennis Andersen

This repository consists of a dotnet core console app that calculates the type of triangle given 3 integer inputs representing side lenghts. Futhermore 6 unit test of the calculation method.

Here is a list of the test cases

                                       TESTCASES
        /// =====================================================================================================                                        
        ///     INPUT           EXP. OUTPUT         (OUTPUT) WAIT WITH THIS             Test type
        /// ---------------------------------------------------------------------
        /// |   3, 3, 3     |   Equilateral     |                               |       Correct type of triangle
        /// ---------------------------------------------------------------------
        /// |   2, 2, 1     |   Isosceles       |                               |       Correct type of triangle
        /// ---------------------------------------------------------------------
        /// |   3, 4, 5     |   Scalene         |                               |       Correct type of triangle
        /// ---------------------------------------------------------------------
        /// |   a, b, c     |   invalid input   |                               |       Only int numbers allowed
        /// ---------------------------------------------------------------------
        /// |   -1, 3, 3    |   invalid input   |                               |       Only positive values
        /// ---------------------------------------------------------------------
        /// |   0, 3, 3     |   invalid input   |                               |       No zero values 
        /// ---------------------------------------------------------------------
        /// |   1, 3, 6     |   invalid input   |                               |       Inequality test
        /// ---------------------------------------------------------------------
        /// |   max+1, 3, 6 |   invalid input   |                               |       Not an integer value
        /// ---------------------------------------------------------------------
        /// =====================================================================================================
