namespace FinalAlgorithmApp
{
    struct Messages
    {
        /// <summary>
        /// Messege : Invaild input, enter number
        /// </summary>
        static public string Numeric
        {
            get { return " Invaild input, enter number"; }
        }

        /// <summary>
        /// Messege : Do you want to <paramref name="what"/>
        /// </summary>
        static public string QuestionYesNo(string what)
        {
            return " Do you want to" + what;
        }

        /// <summary>
        /// Messege : No <paramref name="what"/> Found
        /// </summary>
        static public string NotFound(string what)
        {
            return " No " + what + " Found ";
        }

        /// <summary>
        /// Messege : This <paramref name="what"/> isn't belong to 
        /// the <paramref name="what"/> list of this <paramref name="owner"/>
        /// </summary>
        static public string NotBelong(string what, string owner)
        {
            return " This " + what + " isn't belong to the "
                + what + " list of this " + owner;
        }
    }
}
