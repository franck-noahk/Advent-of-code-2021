using System;
using System.Linq;

namespace Conversion
{
    public static class Conversion
    {
        public static ReturnType ToType<ReturnType> (object valueToConvert){
            
            if (valueToConvert is ReturnType)
            {
                return (ReturnType)valueToConvert;
            }
            Type ConversionType = typeof(ReturnType);

            if (ConversionType.IsEnum)
            {
                int numericValue;
                if (!Int32.TryParse(valueToConvert.ToString(), out numericValue))
                {
                    //It is the string representation of the enum - convert it to its underlying type

                    Array enumValues = Enum.GetValues(ConversionType);
                    ReturnType result = (from ReturnType value in enumValues where value.ToString() == valueToConvert.ToString() select value).FirstOrDefault();
                    return result;
                }
                return (ReturnType)Convert.ChangeType(valueToConvert,Enum.GetUnderlyingType(ConversionType));
            }else
            {
                return (ReturnType)Convert.ChangeType(valueToConvert,ConversionType);
            }
        }
    }
}
