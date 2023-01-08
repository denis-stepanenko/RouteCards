using Newtonsoft.Json;
using System;
using System.IO;
using System.Reflection;

namespace RouteCards.Infrastructure
{
    public class SettingsService
	{
		string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Assembly.GetExecutingAssembly().GetName().Name + "Settings.json");

		public void Save(Settings settings)
		{
			File.WriteAllText(path, JsonConvert.SerializeObject(settings));
		}

		public Settings Load()
		{
			if (File.Exists(path))
				return JsonConvert.DeserializeObject<Settings>(File.ReadAllText(path));
			else return new Settings();
		}
	}
}
