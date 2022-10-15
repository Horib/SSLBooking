namespace SSLBooking.Models.ViewModels;

public static class ViewModelFactory
{
    public static RouteViewModel Details(Route r)
    {
        return new RouteViewModel
        {
            Route = r, Action = "Details"
        };
    }

    public static RouteViewModel Create(Route route)
    {
        return new RouteViewModel { Route = route };
    }
}