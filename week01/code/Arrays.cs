public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {

        //-get the original number and the number of multiples
        //- create the blank list 
        //- for (i <= number of multiples)
        //- multiples= multiples + the original number
        //-add multiples to the list
        //- for end 
        //- return the list with the multiples 
        double originalNumber = number;
        int originalLength = length;
        double operation1 = 0;

        List<double> listOfMultiples = new List<double>();

        for (int i = 1; i <= originalLength; i++)
        {
            operation1 = operation1 + originalNumber;
            listOfMultiples.Add(operation1);
        }

        return listOfMultiples.ToArray(); // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
    
        //-get the data 
        //-check if the rotation is need 
        //-find the split point 
        //-split the list 
        //-put together the differents parts
        //and modify the dat
    int count = data.Count;


    if (count == 0 || amount == 0 || amount == count)
        return;

    int splitIndex = count - amount;

    List<int> endPart = data.GetRange(splitIndex, amount); 
    List<int> startPart = data.GetRange(0, splitIndex);    

    data.Clear();
    data.AddRange(endPart);
    data.AddRange(startPart);


    }
}
