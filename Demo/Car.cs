namespace Demo
{
    public class Car
    {
        public string Make { get; set; } = "";
        public string Model { get; set; } = "";
        public EngineControlModule EngineControlModule { get; set; }
        public bool IsRunning => EngineControlModule.IsRunning;

        public BrakePedal BrakePedal { get; set; }
        public SteeringWheel SteeringWheel { get; set; }
        public Throttle Throttle { get; set; }

        public Car(EngineControlModule engineControlModule)
        {
            EngineControlModule = engineControlModule;
        }

        public void Start() => EngineControlModule.Start();
        public void Stop() => EngineControlModule.Stop();
    }
}