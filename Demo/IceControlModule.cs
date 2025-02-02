namespace Demo
{
    public sealed class IceControlModule : EngineControlModule
    {
        private int _engineStatus;

        public CrankPositionSensor CrankPositionSensor { get; set; } = new CrankPositionSensor();
        public ExhaustOxygenSensor ExhaustOxygenSensor { get; set; } = new ExhaustOxygenSensor();

        public override bool IsRunning => _engineStatus == 1;

        public IceControlModule()
        {
            EngineType = EngineType.Gasoline;
        }

        public override void Start()
        {
            // Crank the starter
            _engineStatus = 1;
        }

        public override void Stop()
        {
            // Cut the power
            _engineStatus = 0;
        }
    }
}