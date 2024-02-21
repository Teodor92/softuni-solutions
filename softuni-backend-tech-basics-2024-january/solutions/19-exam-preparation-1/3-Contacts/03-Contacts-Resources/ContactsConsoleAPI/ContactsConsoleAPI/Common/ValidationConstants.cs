namespace ContactsConsoleAPI.Common
{
    public static class ValidationConstants
    {
        public const int NameMaxLength = 100;
        public const int AddressMaxLength = 255;
        public const string ULIDRegex = @"^([0-9A-Z]{10,30})$";
        public const int PhoneMaxLength = 15;
        public const int EmailMaxLength = 255;
        public const int GenderMaxLength = 10;
    }
}
