namespace PasswordStrengthCheckerLogic
{
    public class PWStrengthLogic
    {
        public PWStrengthLogic()
        {

        }

        public string GetPasswordStrengthLabel(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                return "UNKNOWN";
            }

            double entropy = CalculatePasswordEntropy(password);

            if (entropy < 36)
            {
                return "Very Weak";
            }
            else if (entropy < 60)
            {
                return "Weak";
            }
            else if (entropy < 120)
            {
                return "Strong";
            }
            else
            {
                return "Very Strong";
            }
        }
        internal double CalculatePasswordEntropy (string password)
        {
             int pool = CalculatePool(password);

             return Math.Log(Math.Pow(pool, password.Length));
        }

        internal int CalculatePool(string password)
        {
            int sum = 0;

            bool hasDigit = password.Any(c => char.IsDigit(c));
            bool hasSpecialChar = password.Any(c => !char.IsLetterOrDigit(c));
            bool hasUpperCase = password.Any(c => char.IsUpper(c));
            bool hasLowerCase = password.Any(c => char.IsLower(c));

            if (hasDigit)
            {
                sum += 10;
            }
            if (hasSpecialChar)
            {
                sum += 32;
            }
            if (hasUpperCase)
            {
                sum += 26;
            }
            if (hasLowerCase)
            {
                sum += 26;
            }

            return sum;
        }
    }
}
