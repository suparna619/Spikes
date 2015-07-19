namespace spikeApp
{
    public class V4Engine : IEngine
    {
        private TypeOfEngine type;
        private int maximumSpeed;

        public void SetEngineType(TypeOfEngine engineType)
        {
            this.type = engineType;
        }

        public void SetMaximumSpeed(int maximumSpeed)
        {
            this.maximumSpeed = maximumSpeed;
        }

        public TypeOfEngine GetEngineType()
        {
            return this.type;
        }

        public int GetMaximumSpeed()
        {
           return this.maximumSpeed;
        }
    }
}