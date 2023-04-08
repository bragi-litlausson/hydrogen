# Event System specification

- - -

# Base features 

- Events are split into general types (input, rendering, app, etc.) to allow quick identification without need for casting.
- Events can be marked as solved. Solved events will be ignored by all other systems.
- Each system has their own implementation of `IEvent`, those implementation can contain additional identifiers or in case of simple system type test can be used out of the gate.
- Events can be sent instantly or on the beginning of the next frame.
