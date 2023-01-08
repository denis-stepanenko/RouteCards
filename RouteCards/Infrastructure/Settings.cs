namespace RouteCards.Infrastructure
{
    public class Settings
    {
        public Settings()
        {
            MechanicalReportSettings = new MechanicalReportSettings();
        }

        public int LastUserId { get; set; }

        public MechanicalReportSettings MechanicalReportSettings { get; set; }
    }
}
