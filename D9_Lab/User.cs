namespace D9_Lab.DataLayer.Models
{
    public class User
    {
        public int    Id        { get; set; }
        public string UserName  { get; set; }
        public string Password  { get; set; }
        public string Track     { get; set; }
        public string ImagePath { get; set; } = "";
    }
}
