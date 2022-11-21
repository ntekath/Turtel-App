using System.Collections.Generic;

namespace Turtel_App.ServerApp.User.Domain
{
    public class User
    {
        public User()
        {
            Account = null;
            Gallery = null;
            Matches = new List<User>();
            Preferences = new List<Preference>();
            Presentation = null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="account"></param>
        /// <param name="gallery"></param>
        /// <param name="matches"></param>
        /// <param name="preferences"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public User(Account account, Gallery gallery, ICollection<User> matches, ICollection<Preference> preferences)
        {
            Account = account ?? throw new ArgumentNullException(nameof(account));
            Gallery = gallery ?? throw new ArgumentNullException(nameof(gallery));
            Matches = matches ?? throw new ArgumentNullException(nameof(matches));
            Preferences = preferences ?? throw new ArgumentNullException(nameof(preferences));
        }

        public Account? Account { get; private set; }
        public Gallery? Gallery { get; private set; }
        public ICollection<User> Matches { get; }
        public ICollection<Preference> Preferences { get; }
        public Presentation? Presentation { get; }
    }
}
