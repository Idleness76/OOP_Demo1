﻿namespace Demo
{
    public sealed class HybridControlModule : EngineControlModule
    {
        private int _engineStatus;
        private int _relayStatus;

        public CrankPositionSensor CrankPositionSensor { get; set; } = new CrankPositionSensor();
        public ExhaustOxygenSensor ExhaustOxygenSensor { get; set; } = new ExhaustOxygenSensor();

        public override bool IsRunning => _engineStatus == 1 && _relayStatus == 1;

        public HybridControlModule()
        {
            EngineType = EngineType.Hybrid;
        }

        public override void Start()
        {
            // Close some relays
            _relayStatus = 1;
            // Crank the starter
            _engineStatus = 1;
        }

        public override void Stop()
        {
            // Open some relays
            _relayStatus = 0;
            // Cut the power
            _engineStatus = 0;
        }
    }
}