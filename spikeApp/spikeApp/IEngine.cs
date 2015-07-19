namespace spikeApp
{
    public interface IEngine
    {
        void SetEngineType(TypeOfEngine engineType);

        void SetMaximumSpeed(int maximumSpeed);

        TypeOfEngine GetEngineType();

        int GetMaximumSpeed();
    }
}