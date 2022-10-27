namespace Lesson20.ExeptionClasses
{
    public class PasswordCheckExeption:Exception
    {
        public PasswordCheckExeption(string msg) : base(msg)
        {
        }
    }
}
