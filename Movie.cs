using TrelloUtility;

namespace TheMovieDBClassLibrary
{
    public class Movie : TrelloCard
    {
        public string Title
        {
            get {
                return this.name;
            }
            set {
                this.Title = value;
                this.name = value;
            }
        }
        public string Description
        {
            get {
                return this.desc;
            }
            set {
                this.Description = value;
                this.desc = value;
            }
        }
        public string Poster { get; set; }
    }
}
