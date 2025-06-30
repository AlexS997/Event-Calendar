namespace EventCalendar.Class
{
    static class Global
    {
        private static string _username;
        private static string _password;
        private static string _iD;
        private static string _nome;
        private static string _email;
        private static bool _isSuperUser;
        private static bool _isActive;
        private static bool _isAdministrator;
        private static string _window;


        private static string _connTest;
        private static string _connAna;
        private static string _connSmart;

        public static string connTest
        {
            get { return _connTest; }
            set { _connTest = value; }
        }

        public static string connAna
        {
            get { return _connAna; }
            set { _connAna = value; }
        }

        public static string connSmart
        {
            get { return _connSmart; }
            set { _connSmart = value; }
        }

        public static string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public static string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public static string iD
        {
            get { return _iD; }
            set { _iD = value; }
        }

        public static string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public static string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public static bool IsSuperUser
        {
            get { return _isSuperUser; }
            set { _isSuperUser = value; }
        }

        public static bool IsAdmin
        {
            get { return _isAdministrator; }
            set { _isAdministrator = value; }
        }

        public static bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }

        public static string Window
        {
            get { return _window; }
            set { _window = value; }
        }
    }

}
