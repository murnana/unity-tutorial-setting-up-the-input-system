# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

This is a Unity tutorial project for practicing challenges from the Unity Learn course **"Using the Input System in Unity"** (https://learn.unity.com/course/using-the-input-system-in-unity).

**Current State:**
- **Project Status:** Challenge 4 (part 1) completed
- **Input System package:** v1.17.0 installed
- **Completed Challenges:** Challenge 1 & Challenge 2 & Challenge 3 & Challenge 4 (part 1)
- **Current Focus:** Ready for additional challenges

**Project Details:**
- **Unity Version:** 6000.3.2f1 (Unity 6)
- **Render Pipeline:** Universal Render Pipeline (URP) 17.3.0
- **Main Scene:** TestTrack.unity
- **Completed Unity Learn Challenges:**
  - Challenge 1: Setting up the Input System
  - Challenge 2: Configure the Wheel Drive Component's Handbrake Input
  - Challenge 3: Configure the Wheel Drive Component's Acceleration and Steering Angle Inputs
  - Challenge 4 (part 1): Setting up a Second set of Bindings for a Gamepad

**Challenge URLs:**
- Challenge 1: https://learn.unity.com/course/using-the-input-system-in-unity/tutorial/challenge-1-setup-the-input-system-and-convert-the-car-switcher-s-component-to-use-the-new-input-system
- Challenge 2: https://learn.unity.com/course/using-the-input-system-in-unity/tutorial/challenge-2-configure-the-wheel-drive-component-s-handbrake-input
- Challenge 3: https://learn.unity.com/course/using-the-input-system-in-unity/tutorial/challenge-3-configure-the-wheel-drive-component-s-acceleration-and-steering-angle-inputs
- Challenge 4: https://learn.unity.com/course/using-the-input-system-in-unity/tutorial/challenge-4-setting-up-a-second-set-of-bindings-for-a-gamepad

**Completed Learning Objectives:**
1. ✅ Setting up the Input System package in a project
2. ✅ Creating Input Actions Assets
3. ✅ Using the PlayerInput component
4. ✅ Converting existing input code to use Input System
5. ✅ Understanding Input System basics
6. ✅ Implementing 1D axis input for vehicle control
7. ✅ Using button and modifier actions in C# scripts
8. ✅ Managing input lifecycle (OnEnable/OnDisable)
9. ✅ Using Composite Bindings (1D Axis) for bidirectional control
10. ✅ Implementing event-based input processing (performed/canceled callbacks)
11. ✅ Managing multiple input actions in a single component
12. ✅ Replacing legacy Input Manager code with Input System
13. ✅ Configuring alternative input bindings for gamepad controllers
14. ✅ Setting up multi-device input support (keyboard + gamepad)
15. ✅ Using Input Debugger to monitor real-time input data

## Development Commands

### Opening the Project
```bash
# Open in Unity Editor (requires Unity Hub and Unity 6000.3.2f1 installed)
# File → Open Project → Select this directory
```

### Working on Challenges
- Follow the Challenge instructions on Unity Learn
- Implement required features using Input System
- Test your implementation in Play mode

### Testing Controls

**Keyboard Controls:**
- **Tab Key:** Switch between vehicles (Challenge 1)
- **X Key:** Handbrake (Challenge 2)
- **W/S Keys:** Acceleration/Deceleration (Challenge 3)
- **A/D Keys:** Steering left/right (Challenge 3)

**Gamepad Controls (Challenge 4):**
- **Button North (Y on Xbox):** Next vehicle
- **Select (Back on Xbox):** Reset
- **Button South (A on Xbox):** Handbrake
- **Right Trigger:** Acceleration
- **Left Trigger:** Deceleration
- **Left Stick X-Axis:** Steering

**Debugging:**
- Use Window → Analysis → Input Debugger to inspect inputs in real-time

### Building
No build scripts configured. Use Unity Editor's build menu: File → Build Settings

## Current Project Structure

```
Assets/
├── DefaultVolumeProfile.asset                      # Default URP volume settings
├── UniversalRenderPipelineGlobalSettings.asset     # URP global configuration
├── Prefabs/
│   └── Vehicles/                                   # Vehicle prefabs
│       ├── FamilyCar.prefab                        # Family car with WheelDrive component
│       ├── SportsCar.prefab                        # Sports car with WheelDrive component
│       └── Truck.prefab                            # Truck with WheelDrive component
├── Scenes/
│   └── TestTrack.unity                             # Main test track scene
├── Scripts/
│   ├── CarSwitcher.cs                              # Vehicle switching script (Challenge 1)
│   └── WheelDrive.cs                               # Vehicle drive script with Input System (Challenge 2 & 3)
└── Settings/
    └── InputSystems/
        └── Primary Input Actions.inputactions      # Main input actions asset

ProjectSettings/
└── (Unity project configuration files)
```

## Completed Challenges Implementation

### Challenge 1: Setting up the Input System

**Deliverables:**

1. **Input Actions Asset**
   - ✅ Created "Primary Input Actions.inputactions"
   - ✅ Defined "Player" Action Map
   - ✅ Created "SwitchCar" action bound to Tab key

2. **Scene Setup**
   - ✅ Created TestTrack.unity scene
   - ✅ Set up vehicle prefabs (FamilyCar, SportsCar, Truck)

3. **Scripts**
   - ✅ Implemented CarSwitcher.cs using PlayerInput component
   - ✅ Integrated Input System with OnSwitchCar callback

4. **Testing**
   - ✅ Verified Tab key switches between vehicles correctly

### Challenge 2: Configure the Wheel Drive Component's Handbrake Input

**Deliverables:**

1. **Input Actions Update**
   - ✅ Added "Handbrake" action to Primary Input Actions
   - ✅ Bound Handbrake to X key

2. **Script Implementation**
   - ✅ Updated WheelDrive.cs with Input System namespace
   - ✅ Added InputActionAsset reference field
   - ✅ Implemented Awake() method to initialize input
   - ✅ Created GetHandBrakeInput() method
   - ✅ Added OnEnable()/OnDisable() for lifecycle management
   - ✅ Removed legacy Input.GetKey() code

3. **Scene Configuration**
   - ✅ Assigned Primary Input Actions to all vehicle prefabs

4. **Testing**
   - ✅ Verified X key triggers handbrake on all vehicles

### Challenge 3: Configure the Wheel Drive Component's Acceleration and Steering Angle Inputs

**Deliverables:**

1. **Input Actions Update**
   - ✅ Added "Acceleration" action to Primary Input Actions
   - ✅ Bound Acceleration to W (positive) and S (negative) keys using 1D Axis Composite
   - ✅ Added "Steering Angle" action to Primary Input Actions
   - ✅ Bound Steering Angle to D (positive) and A (negative) keys using 1D Axis Composite

2. **Script Implementation**
   - ✅ Added InputAction references for acceleration and steering
   - ✅ Updated Awake() to find and register new actions
   - ✅ Implemented GetTorqueInput() method with event callbacks
   - ✅ Implemented GetAngleInput() method with event callbacks
   - ✅ Removed legacy Input.GetAxis("Horizontal") and Input.GetAxis("Vertical") code
   - ✅ Updated OnEnable()/OnDisable() to manage all input actions

3. **Scene Configuration**
   - ✅ Verified Primary Input Actions are assigned to all vehicle prefabs

4. **Testing**
   - ✅ Verified W/S keys control vehicle acceleration/deceleration
   - ✅ Verified A/D keys control vehicle steering
   - ✅ Verified smooth control with 1D Axis Composite Bindings

### Challenge 4 (Part 1): Setting up a Second set of Bindings for a Gamepad

**Deliverables:**

1. **Input Actions Update - Gamepad Bindings**
   - ✅ Added gamepad binding to "Next Vehicle" action (Button North / Y button)
   - ✅ Added gamepad binding to "Reset" action (Select / Back button)
   - ✅ Added gamepad binding to "Handbrake" action (Button South / A button)
   - ✅ Added gamepad bindings to "Acceleration" action:
     - Right Trigger (positive acceleration)
     - Left Trigger with Invert Processor (negative acceleration/deceleration)
   - ✅ Added gamepad binding to "Steering Angle" action (Left Stick X-Axis)

2. **Multi-Device Input Support**
   - ✅ Configured dual input bindings (keyboard + gamepad) for all actions
   - ✅ No code changes required - Input System handles multiple devices automatically
   - ✅ Both input methods work simultaneously

3. **Testing and Debugging**
   - ✅ Tested gamepad controls in Play mode
   - ✅ Used Input Debugger (Window → Analysis → Input Debugger) to verify inputs
   - ✅ Confirmed all gamepad bindings work correctly alongside keyboard controls

4. **Key Learning Points**
   - Alternative input bindings can be added without modifying code
   - Input System automatically handles multiple input devices
   - Processors (like Invert) can modify input values before they reach the code
   - Input Debugger is essential for testing and debugging input configurations

### Input System Implementation Approaches

**Approach A - PlayerInput Component (Used in Challenge 1):**
```csharp
using UnityEngine.InputSystem;

public class CarSwitcher : MonoBehaviour
{
    public void OnSwitchCar(InputValue value)
    {
        // Handle car switching logic
        // This approach uses PlayerInput component with Send Messages behavior
    }
}
```

**Approach B - Direct Input Actions API (Used in Challenge 2 & 3):**
```csharp
using UnityEngine.InputSystem;

public class WheelDrive : MonoBehaviour
{
    [SerializeField] private InputActionAsset inputActions;
    private InputAction handbrakeAction;
    private InputAction accelerationAction;
    private InputAction steeringAction;

    void Awake()
    {
        // Find the actions in the asset
        var actionMap = inputActions.FindActionMap("Gameplay");
        handbrakeAction = actionMap.FindAction("Handbrake");
        accelerationAction = actionMap.FindAction("Acceleration");
        steeringAction = actionMap.FindAction("Steering Angle");

        // Register event callbacks
        handbrakeAction.performed += GetHandBrakeInput;
        handbrakeAction.canceled += GetHandBrakeInput;

        accelerationAction.performed += GetTorqueInput;
        accelerationAction.canceled += GetTorqueInput;

        steeringAction.performed += GetAngleInput;
        steeringAction.canceled += GetAngleInput;
    }

    void OnEnable()
    {
        // Enable all actions when component is enabled
        handbrakeAction.Enable();
        accelerationAction.Enable();
        steeringAction.Enable();
    }

    void OnDisable()
    {
        // Disable all actions when component is disabled
        handbrakeAction.Disable();
        accelerationAction.Disable();
        steeringAction.Disable();
    }

    void GetHandBrakeInput(InputAction.CallbackContext context)
    {
        handBrake = context.ReadValue<float>() * brakeTorque;
    }

    void GetTorqueInput(InputAction.CallbackContext context)
    {
        torque = context.ReadValue<float>() * maxTorque;
    }

    void GetAngleInput(InputAction.CallbackContext context)
    {
        angle = context.ReadValue<float>() * maxAngle;
    }
}
```

### Input System Key Concepts

- **Action Maps**: Organizational containers for related actions (e.g., "Player", "Gameplay", "UI")
- **Actions**: Individual inputs (e.g., "Move", "SwitchCar", "Jump", "Acceleration")
- **Bindings**: Specific device inputs mapped to actions (e.g., Tab key → SwitchCar)
  - **Multiple Bindings**: Actions can have multiple bindings for different devices (e.g., keyboard + gamepad)
  - Input System automatically handles multiple devices without code changes
- **Composite Bindings**: Complex bindings that combine multiple inputs (e.g., 1D Axis, 2D Vector)
  - **1D Axis**: Combines two inputs into a single axis (-1 to +1 range)
  - Example: W (positive) + S (negative) = Acceleration axis
- **Processors**: Modify input values before they reach the code
  - **Invert**: Flips the sign of the input value (e.g., for reversing trigger input)
  - **Scale**: Multiplies the input value by a constant
  - **Clamp**: Limits the input value to a specific range
- **Control Schemes**: Device-specific configurations (Keyboard+Mouse, Gamepad)
- **PlayerInput Component**: Unity component that bridges Input Actions and MonoBehaviour scripts
- **Event Callbacks**: Methods triggered by input events (performed, started, canceled)
- **Input Debugger**: Tool for monitoring real-time input data (Window → Analysis → Input Debugger)

## Key Dependencies

Critical packages in `Packages/manifest.json`:
- `com.unity.inputsystem@1.17.0` - New Input System (main learning focus)
- `com.unity.render-pipelines.universal@17.3.0` - URP rendering
- `com.unity.test-framework@1.6.0` - Unit testing support
- `com.unity.visualscripting@1.9.9` - Visual scripting

## Working with This Project

### When Helping with Future Challenges

If asked to help with future challenge implementation:

1. **Follow the Unity Learn Challenge Instructions:**
   - Reference the specific Challenge page for requirements
   - Use terminology from the course (Action Maps, Actions, Bindings, Control Schemes)
   - Build on existing implementations from previous challenges

2. **Project Setup:**
   - Challenge 1, 2, and 3 are complete
   - Input System package v1.17.0 is installed and configured
   - Primary Input Actions asset exists with SwitchCar, Handbrake, Acceleration, and Steering Angle actions
   - TestTrack scene has 3 vehicles with fully configured WheelDrive components

3. **Implementation Steps:**
   - Review existing Input Actions Asset
   - Add new actions as required by the challenge
   - Update or create scripts using Input System API
   - Configure scene objects and components
   - Test using Input Debugger

4. **Code Style Guidelines:**
   - Use clear, beginner-friendly variable names
   - Add comments to explain Input System concepts
   - Keep code simple and tutorial-focused
   - Follow Unity's C# coding conventions
   - Match the style of existing scripts (CarSwitcher.cs, WheelDrive.cs)

### Common Tasks

**Updating Input Actions Asset:**
- Open "Primary Input Actions.inputactions" in Assets/Settings/InputSystems/
- Add new actions to the "Player" Action Map
- Define bindings for keyboard/gamepad controls
- Save the asset

**Using PlayerInput Component (Challenge 1 approach):**
- Add PlayerInput component to GameObject
- Assign Primary Input Actions asset
- Set Behavior to "Send Messages"
- Implement callback methods like `OnActionName(InputValue value)`

**Using Direct Input Actions API (Challenge 2 & 3 approach):**
- Add `using UnityEngine.InputSystem;` at the top of script
- Add `[SerializeField] private InputActionAsset inputActions;` field
- Find actions in Awake(): `inputActions.FindActionMap("Gameplay").FindAction("ActionName")`
- Register event callbacks: `action.performed += CallbackMethod;` and `action.canceled += CallbackMethod;`
- Enable/disable in OnEnable()/OnDisable()
- Read values in callback methods: `context.ReadValue<T>()`

**Creating Composite Bindings (1D Axis):**
- Open Input Actions Asset in editor
- Add new action with "Value" type and "Axis" expected control type
- Click "+" on the action and select "Add 1D Axis Composite"
- Assign "negative" binding (e.g., S key, A key)
- Assign "positive" binding (e.g., W key, D key)
- The composite automatically provides values from -1 to +1

**Adding Gamepad Bindings (Challenge 4):**
- Open Input Actions Asset in editor
- Select the action you want to add a gamepad binding to
- Click "+" on the action and select "Add Binding"
- Click on the new binding and press "Listen" button
- Press the desired button/stick on your gamepad
- For triggers with opposite directions:
  - Add two separate bindings (e.g., Right Trigger, Left Trigger)
  - On the reverse direction binding, add an "Invert" processor
  - This allows one trigger for positive values and another for negative values
- Save the asset

**Using Input Processors:**
- Select a binding in the Input Actions Asset
- Click "Add Processor" in the inspector
- Choose processor type (Invert, Scale, Clamp, etc.)
- Configure processor parameters if needed
- Processors modify input values before they reach your code

**Debugging and Testing:**
- Use Window → Analysis → Input Debugger to inspect inputs
- Verify bindings are triggering correctly
- Test with keyboard (and gamepad if available)
- Check Console for any Input System warnings or errors

**Assigning Input Actions to Prefabs:**
- Select prefab in Project window
- Find the component that needs Input Actions (e.g., WheelDrive)
- Assign the Primary Input Actions asset to the InputActionAsset field
- Apply changes to prefab

### Project Settings for Input System

**Active Input Handling:**
- Location: Edit → Project Settings → Player → Other Settings → Active Input Handling
- Options:
  - "Input Manager (Old)" - Legacy only
  - "Input System Package (New)" - New system only (recommended for Challenge 1)
  - "Both" - Supports both systems (useful for gradual migration)

### Reference Documentation
- Unity Learn Course: https://learn.unity.com/course/using-the-input-system-in-unity
- Unity Learn Challenge 1: https://learn.unity.com/course/using-the-input-system-in-unity/tutorial/challenge-1-setup-the-input-system-and-convert-the-car-switcher-s-component-to-use-the-new-input-system
- Unity Learn Challenge 2: https://learn.unity.com/course/using-the-input-system-in-unity/tutorial/challenge-2-configure-the-wheel-drive-component-s-handbrake-input
- Unity Learn Challenge 3: https://learn.unity.com/course/using-the-input-system-in-unity/tutorial/challenge-3-configure-the-wheel-drive-component-s-acceleration-and-steering-angle-inputs
- Unity Learn Challenge 4: https://learn.unity.com/course/using-the-input-system-in-unity/tutorial/challenge-4-setting-up-a-second-set-of-bindings-for-a-gamepad
- Input System Package Manual: https://docs.unity3d.com/Packages/com.unity.inputsystem@1.17/manual/index.html

### Notes

- Challenge 1, Challenge 2, Challenge 3, and Challenge 4 (part 1) are completed
- Project demonstrates two different Input System approaches:
  - PlayerInput component with callbacks (CarSwitcher)
  - Direct Input Actions API with event callbacks (WheelDrive)
- WheelDrive component now fully uses Input System for all controls:
  - Vehicle switching (Tab / Gamepad Y button)
  - Handbrake (X / Gamepad A button)
  - Acceleration/Deceleration (W/S / Gamepad triggers)
  - Steering (A/D / Gamepad left stick)
- All legacy Input Manager code has been removed from WheelDrive
- Multi-device input support configured (keyboard + gamepad work simultaneously)
- No code changes were needed to add gamepad support - only Input Actions Asset updates
- Gamepad bindings use processors (Invert) to handle trigger inputs correctly
- Input Debugger is available for testing and debugging input configurations
- Ready to proceed with additional challenges
- All vehicle prefabs are configured with complete Input Actions
- TestTrack scene is fully set up for complete vehicle testing with keyboard and gamepad
