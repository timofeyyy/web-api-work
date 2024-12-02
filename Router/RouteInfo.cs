namespace app.Router
{
    public class RouteInfo
    {
        public string Path { get; set; }
        public string Value { get; set; }

        public RouteInfo(string path, string value)
        {
            Path = path;
            Value = value;
        }
    }
}
