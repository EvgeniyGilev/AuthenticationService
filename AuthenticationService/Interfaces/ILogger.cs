namespace AuthenticationService.Interfaces
{
    public interface ILogger
    {
        public void WriteEvent(string evntMessage);

        public void WriteError(string errorMessage);

    }
}
