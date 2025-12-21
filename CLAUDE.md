# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

This is a Unity tutorial project that serves as a practical companion to the Unity Learn course **"Using the Input System in Unity"** (https://learn.unity.com/course/using-the-input-system-in-unity). The project applies Input System concepts taught in the course to the classic **Roll-a-Ball** game sample.

**Base Asset:**
- This project is based on the official Unity Asset Store package: **"Unity Learn | 3D Beginner: Roll-a-Ball | Complete Project | URP"**
- Asset Store URL: https://assetstore.unity.com/packages/essentials/tutorial-projects/unity-learn-3d-beginner-roll-a-ball-complete-project-urp-77198
- Version 4.0 (Released August 7, 2024)
- Publisher: Unity Technologies
- License: Free under Unity Asset Store EULA

**Current State:**
- The project uses **legacy Input Manager API** (`Input.GetAxis()`)
- Modern **Input System package** (v1.17.0) is installed but not yet integrated
- The goal is to migrate from legacy input to the new Input System following the Unity Learn course methodology

**Project Details:**
- **Unity Version:** 6000.3.2f1 (Unity 6)
- **Render Pipeline:** Universal Render Pipeline (URP) 17.3.0
- **Main Scene:** `Assets/UnityTechnologies/RollABall/Roll-a-ball.unity`
- **Unity Learn Course:** Using the Input System in Unity (Beginner level, ~3.5 hours)

**Learning Objectives from Unity Learn Course:**
1. Setting up the Input System package
2. Scripting player movement with Input Actions
3. Customizing Input Actions for keyboard and gamepad
4. Using the Input System Scripting API
5. Debugging and testing with Input Debugger

## Development Commands

### Opening the Project
```bash
# Open in Unity Editor (requires Unity Hub and Unity 6000.3.2f1 installed)
# File → Open Project → Select this directory
```

### Running the Game
- Press the Play button in Unity Editor, or use `Ctrl+P` (Windows) / `Cmd+P` (Mac)
- Test with keyboard: WASD or Arrow keys for movement

### Building
No build scripts configured. Use Unity Editor's build menu: File → Build Settings

## Code Architecture

### Project Structure

```
Assets/UnityTechnologies/RollABall/
├── Scripts/              # All C# game logic
├── Prefabs/              # Reusable game objects (Pick Up items)
├── Materials/            # Visual materials for objects
├── URP/                  # Render pipeline configuration
└── Roll-a-ball.unity     # Main game scene
```

### Core Scripts

**PlayerController.cs** (Assets/UnityTechnologies/RollABall/Scripts/PlayerController.cs:8)
- Main player movement and game logic
- Currently uses **legacy Input.GetAxis()** API (lines 39-40)
- Handles physics-based movement via Rigidbody.AddForce()
- Manages pickup collection and win condition (12 pickups required)
- Controls UI updates for score and win text

**CameraController.cs** (Assets/UnityTechnologies/RollABall/Scripts/CameraController.cs:4)
- Simple third-person camera follow system
- Maintains fixed offset from player position
- Updates in LateUpdate() to avoid jitter

**Rotator.cs** (Assets/UnityTechnologies/RollABall/Scripts/Rotator.cs:4)
- Continuously rotates pickup objects for visual effect
- Applied to Pick Up prefab instances

### Input System Architecture

**Current State:**
- Scripts use **legacy Input Manager** API: `Input.GetAxis("Horizontal")` and `Input.GetAxis("Vertical")`
- Input axes defined in `ProjectSettings/InputManager.asset`
- Modern **Input System package** (com.unity.inputsystem@1.17.0) is installed but not yet used

**Migration Path (Following Unity Learn Course):**

When implementing Input System based on the Unity Learn course methodology:

1. **Setup Phase (Course Lesson 1):**
   - Verify Input System package is installed
   - Enable "Both" input backends in Project Settings (Edit → Project Settings → Player → Active Input Handling)
   - Or switch to "Input System Package (New)" for full migration

2. **Create Input Actions Asset (Course Lesson 2-3):**
   - Create `.inputactions` file: Right-click in Project → Create → Input Actions
   - Define Action Map (e.g., "Player")
   - Add Move action as Value → Vector2
   - Add bindings for WASD, Arrow Keys, and Gamepad Left Stick

3. **Update PlayerController.cs (Course Lesson 2, 4):**

   **Option A - PlayerInput Component (Recommended for beginners):**
   ```csharp
   using UnityEngine.InputSystem;

   private Vector2 moveInput;

   public void OnMove(InputValue value) {
       moveInput = value.Get<Vector2>();
   }
   ```

   **Option B - Direct Input Actions API:**
   ```csharp
   using UnityEngine.InputSystem;

   [SerializeField] private InputActionAsset playerControls;
   private InputAction moveAction;

   void Awake() {
       moveAction = playerControls.FindActionMap("Player").FindAction("Move");
   }

   void OnEnable() => moveAction.Enable();
   void OnDisable() => moveAction.Disable();

   void FixedUpdate() {
       Vector2 moveInput = moveAction.ReadValue<Vector2>();
       // Use moveInput instead of Input.GetAxis()
   }
   ```

4. **Testing and Debugging (Course Lesson 5):**
   - Use Window → Analysis → Input Debugger
   - Verify input bindings work for both keyboard and gamepad
   - Check for input response in play mode

**Key Concepts from Unity Learn Course:**
- **Action Maps**: Organizational containers for related actions (e.g., "Player", "UI")
- **Actions**: Individual inputs (e.g., "Move", "Jump", "Fire")
- **Bindings**: Specific device inputs mapped to actions (e.g., WASD → Move)
- **Control Schemes**: Device-specific configurations (Keyboard+Mouse, Gamepad)

## Key Dependencies

Critical packages in `Packages/manifest.json`:
- `com.unity.inputsystem@1.17.0` - New Input System (target for migration)
- `com.unity.render-pipelines.universal@17.3.0` - URP rendering
- `com.unity.test-framework@1.6.0` - Unit testing support
- `com.unity.visualscripting@1.9.9` - Visual scripting (alternative to C# scripts)

## Scene Configuration

The main scene (`Roll-a-ball.unity`) contains:
- Player GameObject with PlayerController script and Rigidbody
- Camera GameObject with CameraController script
- Multiple Pick Up GameObjects (instances of Pick Up prefab with Rotator script)
- UI Canvas with score counter and win text
- Lighting and environment setup

## Development Patterns

### Physics Movement
Movement is handled in `FixedUpdate()` using `Rigidbody.AddForce()` rather than direct transform manipulation, ensuring consistent physics simulation.

### Collision Detection
Pickup collection uses `OnTriggerEnter()` with colliders marked as "Is Trigger" and tagged with "Pick Up".

### UI Updates
UI text elements are updated through public references set in the Unity Inspector, using `UnityEngine.UI.Text` components.

## Working with This Project

### When Helping with Input System Migration

If asked to migrate from legacy Input Manager to Input System:

1. **Follow the Unity Learn Course Structure:**
   - Reference the 5 main lessons when explaining or implementing
   - Use terminology from the course (Action Maps, Actions, Bindings, Control Schemes)
   - Recommend PlayerInput component approach for beginners

2. **Preserve Existing Functionality:**
   - The current implementation uses `Input.GetAxis("Horizontal")` and `Input.GetAxis("Vertical")` in PlayerController.cs:39-40
   - Maintain the same movement behavior (physics-based via AddForce)
   - Keep the same feel and responsiveness

3. **Testing Requirements:**
   - Verify WASD and Arrow Keys work identically to legacy input
   - Test gamepad support (Left Stick for movement)
   - Ensure UI updates still function correctly
   - Confirm all 12 pickups can be collected and win condition triggers

4. **Code Style:**
   - Match the existing code style (explicit type declarations, clear variable names)
   - Add comments similar to the existing ones (beginner-friendly explanations)
   - Keep the tutorial nature of the code intact

### Common Tasks

**Creating Input Actions Asset:**
- Place in `Assets/UnityTechnologies/RollABall/` directory
- Name it "PlayerInputActions.inputactions" for clarity
- Generate C# class for strongly-typed access if using scripting API

**Updating PlayerController.cs:**
- Add `using UnityEngine.InputSystem;` at the top
- Replace lines 39-40 (the Input.GetAxis calls) with Input System equivalent
- Keep the rest of the FixedUpdate logic unchanged
- Maintain the existing public variables for Inspector configuration

**Debugging Issues:**
- Check Input System package version matches (1.17.0)
- Verify Project Settings → Player → Active Input Handling is set appropriately
- Use Input Debugger: Window → Analysis → Input Debugger
- Check Console for Input System-specific warnings or errors

### Reference Documentation
- Unity Learn Course: https://learn.unity.com/course/using-the-input-system-in-unity
- Input System Package Manual: https://docs.unity3d.com/Packages/com.unity.inputsystem@1.17/manual/index.html
