namespace MVC_Contoso.Models
{
    public class Sessions
    {
        public List<Session> sessionsList { get; set; }

        public Sessions()
        {

        }

        public Sessions(List<Session> sessions)
        {
            this.sessionsList = sessions;
        }

        public Sessions(int sessioniD, string sessionName, string speaker)
        {
            var session = new Session()
            {
                SessionId = sessioniD,
                SessionName = sessionName,
                Speaker = speaker
            };
        }

    }
}