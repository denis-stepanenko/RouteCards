using System.Deployment.Application;

namespace RouteCards.Infrastructure
{
    static class VersionService
    {
        public static string Get()
        {
            if (!ApplicationDeployment.IsNetworkDeployed) return null;

            return ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString(4);
        }

        public static bool IsUpdateRequired()
        {
            if (!ApplicationDeployment.IsNetworkDeployed) return false;

            var ad = ApplicationDeployment.CurrentDeployment;

            var info = ad.CheckForDetailedUpdate();

            return info.UpdateAvailable;
        }
    }
}
