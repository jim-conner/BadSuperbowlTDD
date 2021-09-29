using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadSuperbowlTDD
{
    public class NumberTranslator
    {
        //why wouldn't auto generate?
        public string Translate(int numberToTranslate)
        {

            // refactor with switch expressions
            //return numberToTranslate switch //could declare this expression as a variable
            //{
            //    1 => "I",
            //    3 => "III",
            //    4 => "IV",
            //    _ => "" //underscore here is a "discard"
            //};

            //refactor fancier for a wider range of inputs
            var numeral = "";

            numeral += new string('L', numberToTranslate / 50);
            numberToTranslate %= 50;

            numeral += numberToTranslate == 40 ? "XL" : "";
            numberToTranslate %= 40;

            numeral += new string('X', numberToTranslate / 10);
            numberToTranslate %= 10;

            numeral += numberToTranslate == 9 ? "IX" : "";
            numberToTranslate %= 9;

            numeral += new string('V', numberToTranslate / 5);
            numberToTranslate %= 5;

            numeral += numberToTranslate == 4 ? "IV" : "";
            numberToTranslate %= 4;

            numeral += new string('I', numberToTranslate);

            return numeral;
            //refactor with switch
            //switch (numberToTranslate)
            //{
            //    case 1: 
            //        return "I";
            //    case 3: 
            //        return "I";
            //    case 4: 
            //        return "I";
            //    case 5:
            //        return "V";
            //    default:
            //        return "";
            //        //break; //why don't I need breaks above again?
            //}

            //original if() version
            /*
            if (numberToTranslate == 1)
                return "I";
            else if (numberToTranslate == 3)
                return "III";
            else if (numberToTranslate == 4)
                return "IV";

            return "Didn't work";
            */

        }
          
    }
}
