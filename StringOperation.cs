using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOperation
{
    class StringOperation: IStringOperation
    {
        public string GetStringAfter(string searchstring, string actualString)
        {
            int endIndex = searchstring.Length;
            string stringAfter = actualString.Substring(endIndex+1);
            return stringAfter;
        }

        public string NumberType(string keyword)
        {
            switch (keyword)
            {
                case "W":
                    return "Work";
                case "M":
                    return "Mobile";
                case "H":
                    return "Home";
                default:
                    return "Unknown Type";
            }
        }

        public string ReadAfterSecondOccurance(string searchstring, string actualString)
        {
            int index = actualString.IndexOf(searchstring, actualString.IndexOf(searchstring) + 1 )+ searchstring.Length;
            var afterText = actualString.Substring(index);
            return afterText;

        }

        public int? ReadPhoneNumber(string searchstring, string actualString)
        {
            var keywords = stringArray(actualString);
            foreach(var keyword in keywords)
            {
                int.TryParse(keyword, out int numericKeyword);
                if (keyword.Length>6) return numericKeyword;
            }
            return null;
        }


        //
        public string SearchStringExist(string searchString, string actualString)
        {
            if (actualString.Contains(searchString))
            {
                return ($"user Input {searchString} exist in the string: {actualString}");
            }
            else
            {
                return ($"user Input {searchString} not exist in the string: {actualString}");
            }
        }

        public string[] stringArray(string actualString)
        {
            return actualString.Split();
        }

        public string StringOccurances(string searchstring, string actualString)
        {
            var keywords = stringArray(actualString);
            var occurancesList = keywords.Where(item => item.Contains(searchstring)).ToList();
            if (occurancesList.Count>=2 )
                return $"{searchstring} number of occurances found {occurancesList.Count}";
            else
                return "Two Occurances not found";
        }

       


        //
    }
}
