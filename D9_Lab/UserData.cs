using D9_Lab.DataLayer.Models;

namespace D9_Lab.DataLayer
{
    public static class UserData
    {
        public static User CurrentUser = null;

        public static User Login(string username, string password)
        {
            using var db = new AppDbContext();

            return db.Users.FirstOrDefault(u =>
                u.UserName.ToLower() == username.ToLower() &&
                u.Password == password);
        }

        public static void UpdateProfile(string oldUsername, string newUsername,
                                         string newTrack, string imagePath)
        {
            using var db = new AppDbContext();

            var user = db.Users.FirstOrDefault(u => u.UserName == oldUsername);
            if (user == null) return;

            user.UserName  = newUsername;
            user.Track     = newTrack;
            user.ImagePath = imagePath ?? "";

            db.SaveChanges();

            if (CurrentUser != null)
            {
                CurrentUser.UserName  = newUsername;
                CurrentUser.Track     = newTrack;
                CurrentUser.ImagePath = imagePath ?? "";
            }
        }
    }
}
