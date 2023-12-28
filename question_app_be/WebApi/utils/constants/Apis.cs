namespace WebApi.utils.constants
{
    public abstract class Apis
    {
        public abstract class Auth
        {
            public const string LOGIN = "login";
            public const string REGISTER = "register";
        }

        public abstract class Question
        {
            public const string BASE_URL = "/questions";
            public const string getWithId = "{id}";
        }
    }
}
