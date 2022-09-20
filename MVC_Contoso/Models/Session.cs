namespace MVC_Contoso.Models
{
    public class Session
    {
        public Session()
        {
        }

        public Session(int sessioniD, string sessionName, string speaker)
        {
            this.SessionId = sessioniD;
            this.SessionName = sessionName;
            this.Speaker = speaker;
        }

        public int SessionId { get; set; }
        public string SessionName { get; set; }
        public string Speaker { get; set; }
    }
}