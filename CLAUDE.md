# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

This is a Unity tutorial project for practicing challenges from the Unity Learn course **"Using the Input System in Unity"** (https://learn.unity.com/course/using-the-input-system-in-unity).

**Current State:**
- **Project Status:** Challenge 2 completed
- **Input System package:** v1.17.0 installed
- **Completed Challenges:** Challenge 1 & Challenge 2
- **Current Focus:** Ready for Challenge 3 and beyond

**Project Details:**
- **Unity Version:** 6000.3.2f1 (Unity 6)
- **Render Pipeline:** Universal Render Pipeline (URP) 17.3.0
- **Main Scene:** TestTrack.unity
- **Completed Unity Learn Challenges:**
  - Challenge 1: Setting up the Input System
  - Challenge 2: Configure the Wheel Drive Component's Handbrake Input

**Challenge URLs:**
- Challenge 1: https://learn.unity.com/course/using-the-input-system-in-unity/tutorial/challenge-1-setup-the-input-system-and-convert-the-car-switcher-s-component-to-use-the-new-input-system
- Challenge 2: https://learn.unity.com/course/using-the-input-system-in-unity/tutorial/challenge-2-configure-the-wheel-drive-component-s-handbrake-input

**Completed Learning Objectives:**
1. ✅ Setting up the Input System package in a project
2. ✅ Creating Input Actions Assets
3. ✅ Using the PlayerInput component
4. ✅ Converting existing input code to use Input System
5. ✅ Understanding Input System basics
6. ✅ Implementing 1D axis input for vehicle control
7. ✅ Using button and modifier actions in C# scripts
8. ✅ Managing input lifecycle (OnEnable/OnDisable)

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
- **Tab Key:** Switch between vehicles (Challenge 1)
- **X Key:** Handbrake (Challenge 2)
- Use Window → Analysis → Input Debugger to inspect inputs

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
│   └── WheelDrive.cs                               # Vehicle drive script with Input System (Challenge 2)
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

**Approach B - Direct Input Actions API (Used in Challenge 2):**
```csharp
using UnityEngine.InputSystem;

public class WheelDrive : MonoBehaviour
{
    [SerializeField] private InputActionAsset inputActions;
    private InputAction handbrakeAction;

    void Awake()
    {
        // Find the action in the asset
        handbrakeAction = inputActions.FindActionMap("Player").FindAction("Handbrake");
    }

    void OnEnable()
    {
        // Enable the action when component is enabled
        handbrakeAction.Enable();
    }

    void OnDisable()
    {
        // Disable the action when component is disabled
        handbrakeAction.Disable();
    }

    float GetHandBrakeInput()
    {
        // Read the current value of the action
        return handbrakeAction.ReadValue<float>();
    }
}
```

### Input System Key Concepts

- **Action Maps**: Organizational containers for related actions (e.g., "Player", "UI")
- **Actions**: Individual inputs (e.g., "Move", "SwitchCar", "Jump")
- **Bindings**: Specific device inputs mapped to actions (e.g., Tab key → SwitchCar)
- **Control Schemes**: Device-specific configurations (Keyboard+Mouse, Gamepad)
- **PlayerInput Component**: Unity component that bridges Input Actions and MonoBehaviour scripts

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
   - Challenge 1 and 2 are complete
   - Input System package v1.17.0 is installed and configured
   - Primary Input Actions asset exists with SwitchCar and Handbrake actions
   - TestTrack scene has 3 vehicles with configured components

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

**Using Direct Input Actions API (Challenge 2 approach):**
- Add `using UnityEngine.InputSystem;` at the top of script
- Add `[SerializeField] private InputActionAsset inputActions;` field
- Find actions in Awake(): `inputActions.FindActionMap("Player").FindAction("ActionName")`
- Enable/disable in OnEnable()/OnDisable()
- Read values with `action.ReadValue<T>()`

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
- Input System Package Manual: https://docs.unity3d.com/Packages/com.unity.inputsystem@1.17/manual/index.html

### Notes

- Challenge 1 and Challenge 2 are completed
- Project demonstrates two different Input System approaches:
  - PlayerInput component with callbacks (CarSwitcher)
  - Direct Input Actions API (WheelDrive)
- Ready to proceed with Challenge 3 and beyond
- All vehicle prefabs are configured with Input Actions
- TestTrack scene is fully set up for vehicle testing
