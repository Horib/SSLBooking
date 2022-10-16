namespace SSLBooking.Models.ViewModels;

public static class ViewModelFactory
{
    public static RouteViewModel Details(Route route)
    {
        return new RouteViewModel
        {
            Route = route,
            RouteTypes = route == null || route.Type == null
                ? Enumerable.Empty<RouteType>()
                : new List<RouteType> { route.Type },

            Action = "Details",
            ShowAction = false,
        };
    }

    public static RouteViewModel Create(Route route,
        IEnumerable<RouteType> routeTypes)
    {
        return new RouteViewModel
        {
            Route = route,
            RouteTypes = routeTypes,

            Action = "Create"
        };
    }

    public static RouteViewModel Edit(Route route,
        IEnumerable<RouteType> routeTypes)
    {
        return new RouteViewModel
        {
            Route = route,
            RouteTypes = routeTypes,

            Action = "Edit"
        };
    }

    public static RouteViewModel Delete(Route route,
        IEnumerable<RouteType> routeTypes)
    {
        return new RouteViewModel
        {
            Route = route,
            RouteTypes = routeTypes,

            Action = "Delete",
        };
    }
}