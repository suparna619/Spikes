using System;

namespace spikeApp
{
    public class Car
    {
        private readonly IEngine engine;

        public Car(IEngine engine)
        {
            this.engine = engine;
        }

        public string GetSpecifications()
        {
            try
            {
                if (this.engine == null)
                    return "Wrong Choice - Try again";

                else
                    return "Maximum speed of" + engine.GetEngineType() + " engine is " + engine.GetMaximumSpeed();
            }
            catch (Exception e)
            {
                return  e.Message;
            }
        }

    }
}