
namespace SEDC.Oop.Class3.StaticClasses.Utils
{
    public static class StringUtils
    {
        public static string CapitaliseFirstLetter(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return string.Empty;
            }
                      
            char firstLetter = text[0];
            string caputaliseLetter = firstLetter.ToString().ToUpper();
           
            if(text.Length == 1)
            {
                return caputaliseLetter;
            }
            
            
            return $"{ caputaliseLetter}{text.Substring(1)}";
        }

        public static int VerifyStringNumber(string input)
        {
            int result = 0;

            bool IsParsed = int.TryParse(input, out result);

            if (IsParsed)
            {
                return result;
            }

            else
            {
                return -1;
            }
        }


    }
}
