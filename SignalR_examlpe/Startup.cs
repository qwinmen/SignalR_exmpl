using Owin;

namespace SignalR_examlpe
{
	public class Startup
	{
		//чтобы задействовать фукциональность SignalR
		public void Configuration(IAppBuilder app)
		{
			app.MapSignalR();
		}
	}
}