namespace Samples;
public partial class AppShell : Shell
{
    internal const string arrow = "Arrow";
    internal const string focus = "Focus";
    internal const string spotlight = "Spotlight";
    internal const string pulse = "Pulse";

    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(arrow, typeof(Arrow.ArrowCoachmarkPage));
        Routing.RegisterRoute(focus, typeof(Focus.FocusCoachmarkPage));
        Routing.RegisterRoute(spotlight, typeof(Spotlight.SpotlightCoachmarkPage));
        Routing.RegisterRoute(pulse, typeof(Pulse.PulseCoachmarkPage));
    }
}