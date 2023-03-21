namespace UniMars.Models.Enums
{
    [Flags]
    public enum Roles
    {
        None = 0,
        SAdmin = 1,
        Admin = 2,
        Manager = 4,
        Editor = 8,
        User = 16,
    }
}
