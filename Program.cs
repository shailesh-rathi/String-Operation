using System;


namespace StringOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //look for the text1 which user enter ,look for two occurences of text2 starting from postion of text1
                //,skip 30th position from the second ocurences of text2 and read continues numbers
                //, read numeric and consider it as phone number, if end with M then mobile , end with H - Home 

                string test = "shailesh went to home along with venkat and venkat return at 6 with the phone number 12345678 - M"; ;

                Console.WriteLine("Enter word you want to search");
                string userInput = Console.ReadLine();

                StringOperation stringOp = new StringOperation();

                var stringOutput = stringOp.SearchStringExist(userInput, test);
                Console.WriteLine(stringOutput);

                Console.WriteLine($"Enter word which you want to search after {userInput} with two occurances");
                var userSecondInput = Console.ReadLine();

                var stringOutput2 = stringOp.GetStringAfter(userInput, test);

                var stringOccurances = stringOp.StringOccurances(userSecondInput, stringOutput2);

                Console.WriteLine(stringOccurances);

                var stringAfterSecondOccurance = stringOp.ReadAfterSecondOccurance(userSecondInput, stringOutput2);

                var readPhone = stringOp.ReadPhoneNumber(userSecondInput, stringAfterSecondOccurance.Substring(30));
                

                var endWith = test.Substring(test.Length-1) ;
                var PhoneType = stringOp.NumberType(endWith);
                Console.WriteLine($"{readPhone} is {PhoneType}");


            }


            catch (ApplicationException ex)
            {
                Console.WriteLine("Business rule voilation " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An Exception occurred " + ex.Message);
            }
            Console.ReadKey();

        }

    }

   
}

