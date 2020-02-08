using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OIBValidation.Models.Validators
{
    public class OIBValidatorAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (!string.IsNullOrEmpty((string)value) && ((string)value).Length == 11)
            {
                string j = ((string)value)[0].ToString();

                int znamenka = int.Parse(j);
                int znamenka2 = 0;

                znamenka = znamenka + 10;

                for (int i = 1; i <= 10; i++)
                {
                    string a = ((string)value)[i].ToString();
                    int b = int.Parse(a);

                    znamenka = znamenka % 10;
                    if (znamenka == 0)
                    {
                        znamenka = 10;
                    }

                    znamenka = znamenka * 2;

                    znamenka2 = znamenka - 11;
                    if (znamenka2 <= 0)
                    {
                        znamenka2 = znamenka;
                    }

                    znamenka = znamenka2 + b;
                }
                znamenka = 11 - znamenka2;
                if (znamenka == 10)
                {
                    znamenka = 0;
                }

                string x = ((string)value)[10].ToString();
                int z = int.Parse(x);
                if (z == znamenka)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}