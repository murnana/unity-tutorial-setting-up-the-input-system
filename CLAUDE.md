# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

This is a Unity tutorial project for practicing **Challenge 1: Setting up the Input System** from the Unity Learn course **"Using the Input System in Unity"** (https://learn.unity.com/course/using-the-input-system-in-unity).

**Current State:**
- **Project Status:** Clean/empty project, reset for Challenge 1
- **Input System package:** v1.17.0 installed
- **Assets:** Only URP default assets (DefaultVolumeProfile, UniversalRenderPipelineGlobalSettings)
- **Previous Content:** All Roll-a-Ball tutorial assets and sample files have been removed
- **Goal:** Complete Challenge 1 by setting up Input System and converting a car switcher component

**Project Details:**
- **Unity Version:** 6000.3.2f1 (Unity 6)
- **Render Pipeline:** Universal Render Pipeline (URP) 17.3.0
- **Main Scene:** None (will be created as part of Challenge 1)
- **Unity Learn Challenge:** Challenge 1 - Setting up the Input System

**Challenge 1 URL:**
https://learn.unity.com/course/using-the-input-system-in-unity/tutorial/challenge-1-setup-the-input-system-and-convert-the-car-switcher-s-component-to-use-the-new-input-system

**Learning Objectives for Challenge 1:**
1. Setting up the Input System package in a project
2. Creating Input Actions Assets
3. Using the PlayerInput component
4. Converting existing input code to use Input System
5. Understanding Input System basics

## Development Commands

### Opening the Project
```bash
# Open in Unity Editor (requires Unity Hub and Unity 6000.3.2f1 installed)
# File → Open Project → Select this directory
```

### Working on Challenge 1
- Follow the Challenge 1 instructions on Unity Learn
- Create new scenes, scripts, and Input Actions as required
- Test your implementation in Play mode

### Building
No build scripts configured. Use Unity Editor's build menu: File → Build Settings

## Current Project Structure

```
Assets/
├── DefaultVolumeProfile.asset                      # Default URP volume settings
├── UniversalRenderPipelineGlobalSettings.asset     # URP global configuration
└── (Challenge 1 assets will be added here)

ProjectSettings/
└── (Unity project configuration files)
```

**Note:** The project is currently empty. All assets, scripts, and scenes will be created as part of Challenge 1.

## Challenge 1 Implementation Guide

### Expected Deliverables for Challenge 1

Based on the Unity Learn Challenge 1, you should create:

1. **Input Actions Asset**
   - Create a `.inputactions` file for the car switcher
   - Define appropriate Action Maps and Actions
   - Configure bindings for the required inputs

2. **Scene Setup**
   - Create or import the Challenge 1 starter scene
   - Set up game objects as required by the challenge

3. **Scripts**
   - Convert the car switcher component to use Input System
   - Use either PlayerInput component or direct Input Actions API

4. **Testing**
   - Verify input works correctly
   - Use Input Debugger to validate setup

### Input System Implementation Approaches

**Option A - PlayerInput Component (Recommended for Challenge 1):**
```csharp
using UnityEngine.InputSystem;

public class CarSwitcher : MonoBehaviour
{
    public void OnSwitchCar(InputValue value)
    {
        // Handle car switching logic
    }
}
```

**Option B - Direct Input Actions API:**
```csharp
using UnityEngine.InputSystem;

public class CarSwitcher : MonoBehaviour
{
    [SerializeField] private InputActionAsset inputActions;
    private InputAction switchAction;

    void Awake()
    {
        switchAction = inputActions.FindActionMap("Player").FindAction("SwitchCar");
    }

    void OnEnable() => switchAction.Enable();
    void OnDisable() => switchAction.Disable();

    void Update()
    {
        if (switchAction.triggered)
        {
            // Handle car switching logic
        }
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

### When Helping with Challenge 1

If asked to help with Challenge 1 implementation:

1. **Follow the Unity Learn Challenge Instructions:**
   - Reference the Challenge 1 page for specific requirements
   - Use terminology from the course (Action Maps, Actions, Bindings, Control Schemes)
   - Recommend PlayerInput component approach for beginners

2. **Project Setup:**
   - The project is currently empty (no scenes, scripts, or Input Actions)
   - Input System package v1.17.0 is already installed
   - URP is configured and ready to use

3. **Implementation Steps:**
   - Create Input Actions Asset first
   - Set up the scene with required GameObjects
   - Write or convert scripts to use Input System
   - Test using Input Debugger

4. **Code Style Guidelines:**
   - Use clear, beginner-friendly variable names
   - Add comments to explain Input System concepts
   - Keep code simple and tutorial-focused
   - Follow Unity's C# coding conventions

### Common Tasks for Challenge 1

**Creating Input Actions Asset:**
- Right-click in Project window → Create → Input Actions
- Name it appropriately (e.g., "CarSwitcherInputActions.inputactions")
- Define Action Maps, Actions, and Bindings as required by the challenge
- Save the asset and optionally generate a C# class

**Setting Up PlayerInput Component:**
- Add PlayerInput component to the appropriate GameObject
- Assign the Input Actions Asset
- Set Behavior to "Invoke Unity Events" or "Send Messages"
- Configure Default Action Map

**Writing Input System Scripts:**
- Add `using UnityEngine.InputSystem;` at the top
- Implement callback methods (e.g., `OnSwitchCar(InputValue value)`)
- Handle input values appropriately
- Add beginner-friendly comments

**Debugging and Testing:**
- Use Window → Analysis → Input Debugger to inspect inputs
- Verify bindings are triggering correctly
- Test with keyboard (and gamepad if available)
- Check Console for any Input System warnings or errors

### Project Settings for Input System

**Active Input Handling:**
- Location: Edit → Project Settings → Player → Other Settings → Active Input Handling
- Options:
  - "Input Manager (Old)" - Legacy only
  - "Input System Package (New)" - New system only (recommended for Challenge 1)
  - "Both" - Supports both systems (useful for gradual migration)

### Reference Documentation
- Unity Learn Challenge 1: https://learn.unity.com/course/using-the-input-system-in-unity/tutorial/challenge-1-setup-the-input-system-and-convert-the-car-switcher-s-component-to-use-the-new-input-system
- Unity Learn Course: https://learn.unity.com/course/using-the-input-system-in-unity
- Input System Package Manual: https://docs.unity3d.com/Packages/com.unity.inputsystem@1.17/manual/index.html

### Notes

- This project has been reset to a clean state for Challenge 1
- Previous Roll-a-Ball tutorial assets have been removed
- Focus is on learning Input System fundamentals through the Challenge 1 exercise
- After completing Challenge 1, you can proceed to Challenge 2 and beyond in the Unity Learn course
