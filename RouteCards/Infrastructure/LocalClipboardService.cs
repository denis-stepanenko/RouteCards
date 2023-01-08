using AgileObjects.AgileMapper.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace RouteCards.Infrastructure
{
    public static class LocalClipboardService
    {
        static List<object> _objects = new List<object>();

        public static void Set<T>(List<T> objects)
        {
            _objects = objects.Cast<object>().ToList();
        }

        public static List<T> Get<T>()
        {
            var clonedObjects = _objects.DeepClone().OfType<T>().Reverse().ToList();
            if(clonedObjects.Count > 0) _objects.Clear();
            return clonedObjects;
        }
    }
}
