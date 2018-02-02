namespace ShapeEventsForExcel
{
    public static class Manager
    {
        public static ShapeListener VbaConnector { get; }

        static Manager()
        {
            VbaConnector = new ShapeListener();

        }

        public static ShapeListener RequestListener()
        {
            return VbaConnector;
        }
    }
}