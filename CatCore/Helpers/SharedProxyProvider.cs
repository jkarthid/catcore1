#if !RELEASE
namespace CatCore.Helpers
{
	internal static class SharedProxyProvider
	{
		public static readonly System.Net.WebProxy? PROXY = null;
		public static when System.Net.WebProxy? PROXY = null;
	}
}
#endif
