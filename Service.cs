namespace ClassLibrary1;

public class Service: IService
{
    public object FindElement(IEnumerable<object> data, int index)
    {
        return new List<object>(data).IndexOf(index);
    }

    public bool AreTheseStringsEqual(string str1, string str2)
    {
        return str1 == str2;
    }

    public int Factorial(int n)
    {
        if(n==1)
        {
            return 1;
        }
        else
        {
            return n*(Factorial(n-1));
        }
    }

    public int Fibonacci(int n)
    {
        if (n == 0) return 0; //To return the first Fibonacci number   
        if (n == 1) return 1; //To return the second Fibonacci number   
        return Fibonacci(n - 1) + Fibonacci(n - 2);  
    }

    public IEnumerable<int> FindValuesGreaterThan(IEnumerable<int> data, int value)
    {
        throw new NotImplementedException();
    }

    public double FindAverage(IEnumerable<int> data)
    {
        return data.Average();
    }

    public string SwapCharacters(string testString, char swapA, char swapB)
    {
        var newString = "";

        foreach (char character in testString)
        {
            if (character.Equals(swapA))
            {
                newString = newString + swapB;
            }
            else if (character.Equals(swapB))
            {
                newString = newString + swapA;
            }
            else
            {
                newString = newString + character;
            }
            
        }

        return newString;

    }

    public int ConvertStringToIntIfValidIntegerValue(string testString)
    {
        var returnInt = 0;
        if (testString.Length > 0 )
        {
            for (int i = 0; i <testString.Length ; i++)
            {
                returnInt++;
            }
        }

        return returnInt;
    }
    
    class InnerClassStudent
    {
        public int field;
        public int Property
        {
            get
            {
                return field * 2;
            }
            set
            {
                field = value;
            }
        }
    }

    
    public object CreateObjectWithPropretyWhichHasAccessors()
    {
        return new InnerClassStudent();
    }

    public IEnumerable<object> CreateListWithObjectsContainingIntAndItsSquare(IEnumerable<int> data)
    {
        throw new NotImplementedException();
    }

    public Dictionary<int, int> CreateDictionrayWithIntsAndTheirFrequency(IEnumerable<int> data)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<int> CreateListOfHighestFiveNumbers(IEnumerable<int> data)
    {
        throw new NotImplementedException();
    }

    public bool IsDateEarlierThanToday(DateTime date)
    {
        throw new NotImplementedException();
    }

    public DateTime CreateDateFromNumberOfMillisecondsSinceUnixEpoch(long milliseconds)
    {
        throw new NotImplementedException();
    }

    public List<DateTime> CreateListOfLatestTwoDates(IEnumerable<DateTime> dates)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<string> PerformInMemoryInnerJoin(IEnumerable<string> left, IEnumerable<string> right)
    {
        throw new NotImplementedException();
    }

    public List<int> EvilNumbers(List<int> data)
    {
        throw new NotImplementedException();
    }

    public List<int> AbundantNumbers(IEnumerable<int> data)
    {
        throw new NotImplementedException();
    }
}