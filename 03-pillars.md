# 03 - The Four Pillars

Example diagrams for module 3 - The Four Pillars

## Class Diagram

```mermaid
classDiagram
	class Shelter {
		<<interface>>
	}
	class Tent {
		
	}
	Tent --|> Shelter : implements
	class EV1 {
		
	}
	EV1 --|> Car : inherits

	class S1 {
		
	}
	S1 --|> Car : inherits

	class Car {
		<<abstract>>
		+BreakPedal : BreakPedal
		+EngineControlModule : EngineControlModule
		+IsRunning : bool
		+Make: string
		+Model: string
		+SteeringWheel : SteeringWheel
		+Throttle: Throttle
		+Start()
		+Stop()
	}
	Car --|> Shelter : implements
	Car --> BreakPedal
	Car --> EngineControlModule
	Car --> SteeringWheel
	Car --> Throttle

	class ElectricControlModule {
		
	}
	ElectricControlModule --|> EngineControlModule : inherits

	class IceControlModule {
		-_crankPositionSensor : CrankPositionSensor
		-_exhaustGasSensor : ExhaustGasSensor
		
	}
	IceControlModule --|> EngineControlModule : inherits
	IceControlModule --> CrankPositionSensor
	IceControlModule --> ExhaustGasSensor

	class EngineControlModule {
		<<abstract>>
		#AirTemperatureSensor : AirTemperatureSensor
		#ThrottlePositionSensor : ThrottlePositionSensor
		#Status : int
		+IsRunning() : bool
		+Start()
		+Stop()
	}
	EngineControlModule --> ThrottlePositionSensor
```

## Summary
- Abstraction; hide complexity
- Encapsulation; hide or move supporting data
- Inheritance; extract commonalities
- Polymorphism; objects can have multiple roles and multiple objects can have the same role