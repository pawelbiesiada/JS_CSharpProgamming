namespace BasicCSharpConsoleNET.Samples.Class.Inheritance
{
    public interface IVehicle : IServiceable
    {
        int Distance { get; }

        void Drive(int duration);
    }

    public interface IServiceable
    {
        bool IsServiceCheckNeeded();
    }
}
