namespace spikeApp
{
    public class EngineFactory
    {

        public static IEngine GetCarEngine(string choice)
        {
            IEngine carEngine = null;
            switch (choice)
            {
                case "1":
                    carEngine = new V4Engine();
                    carEngine.SetEngineType(TypeOfEngine.V4);
                    carEngine.SetMaximumSpeed(100);
                    break;
                case "2":
                    carEngine = new V8Engine();
                    carEngine.SetEngineType(TypeOfEngine.V8);
                    carEngine.SetMaximumSpeed(200);
                    break;
                case "3":
                    carEngine = new GLXEngine();
                    carEngine.SetEngineType(TypeOfEngine.GLX);
                    carEngine.SetMaximumSpeed(80);
                    break;
            }
            return carEngine;
        } 
    }
}