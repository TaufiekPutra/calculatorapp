namespace TestingForm.Repository
{
    public class CalculatorRepository
    {

        #region Common Function
        public int ReverseNumber(int number)
        {
            int absNumber = Math.Abs(number);
            string reversed = new(absNumber.ToString().Reverse().ToArray());
            return int.Parse(reversed) * (number < 0 ? -1 : 1);
        }
        public int Calculate(int number)
        {
            int reversedNumber = ReverseNumber(number);
            return number - reversedNumber;
        }
        public bool IsValidInputChar(char inputChar)
        {
            return !char.IsDigit(inputChar) && inputChar != (char)Keys.Back;
        }

        public int CleanInput(string inputStr)
        {
            int resultInputInt = 0;

            if (inputStr == null)
                return 0;

            if (int.TryParse(inputStr, out int valueInt))
            {
                resultInputInt = valueInt;
            }
            else
            {
                string cleanedStr = new(inputStr.Where(char.IsDigit).ToArray());

                if (int.TryParse(cleanedStr, out int cleanedValueInt))
                {
                    resultInputInt = cleanedValueInt;
                }
                else
                {
                    resultInputInt = 0;
                }

            }

            return resultInputInt;
        }
        #endregion
    }
}
