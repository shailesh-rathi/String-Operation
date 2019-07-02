using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOperation
{
    interface IStringOperation
    {
        string SearchStringExist(string searchString, string actualString);

        string StringOccurances(string searchstring, string actualString);

        string GetStringAfter(string searchstring, string actualString);

        int? ReadPhoneNumber(string searchstring, string actualString);

        string NumberType(string keyword);

        string[] stringArray(string actualString);

        string ReadAfterSecondOccurance(string searchstring, string actualString);
    }
}
