public class ActionResultSet
{
    public int Code { get; set; }
    public string Description { get; set; }

    public ActionResultSet(int code, string description)
    {
        Code = code;
        Description = description;
    }
}