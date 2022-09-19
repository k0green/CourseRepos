namespace Lesson20.ExeptionClasses
{
    public class CustomExeption3:Exception
    {
        public CustomExeption3(string msg) : base(msg)
        {
            msg = "Server error";
        }
    }
}
