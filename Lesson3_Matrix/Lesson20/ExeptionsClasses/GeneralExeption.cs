namespace Lesson20.ExeptionClasses
{
    public class GeneralExeption:Exception
    {
        public GeneralExeption(string msg) : base(msg)
        {
            msg = "Server error";
        }
    }
}
