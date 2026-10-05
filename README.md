# VR "Living Space": A Prototype to Ease Loneliness (Unity + OpenXR)

A virtual reality **prototype** that explores VR as a tool for people who feel lonely.

It simulates the **noise and crowding of a busy, lived-in place**. The user puts on a headset, steps into the space, and is surrounded by people moving around, so the environment around them feels alive instead of empty.

## Concept
Loneliness often comes with quiet, empty surroundings. This prototype tests the idea that VR can recreate the feeling of being among people in a lively space. That gives the user a sense of presence and life around them, and it could become the basis for a supportive or therapeutic experience.

## Features
- **A populated environment:** AI characters walk around the office space on their own. They use NavMesh navigation to roam to random points (`RandomMovement.cs`) and play animations that match their speed (`NavMeshAnimator.cs`), which creates a sense of crowd and activity.
- **Natural VR movement:** a teleport ray turns on from controller input (`ActivateTeleportationRay.cs`)
- **Animated VR hands:** Oculus hand models respond to trigger and grip input (`AnimateHandOnInput.cs`)
- **An office setting:** furnished with low-poly props and characters

## Tech
Unity 2022.3.61f1 · XR Interaction Toolkit 2.6 · OpenXR · AI Navigation (NavMesh) · C#

## Third-party assets
The scene uses three free Unity Asset Store packs. Their licence does not allow redistributing them, so they are **not included** in this repository. Import them from the Asset Store (Package Manager > My Assets) before opening the scene:

- **CharacterPack Lowpoly (FREE)** by elvismd: the office characters
- **Human Basic Motions FREE** by Kevin Iglesias: the idle and walk animations. `Anim Control.controller` uses its `HumanM@Walk01_Forward` clip and a `HumanM@Idle01` clip: duplicate the idle clip from the pack's `HumanM@Idle01` model into `Assets/Animation Controller/` (or point the controller at the pack's clip)
- **Office Props Softpack** by nappin: the furniture and props

Included in the repository: the Oculus hand models (Meta) and Unity's XR Interaction Toolkit samples.

## Open the project
1. Install **Unity 2022.3.61f1** from Unity Hub.
2. Add this folder as a project in Unity Hub and open it. Unity rebuilds the `Library` folder on first open.
3. Import the three Asset Store packs listed above.
4. Open `Assets/Scenes/Main.unity` and press Play with a headset connected. To test without a headset, drag the **XR Device Simulator** prefab from `Assets/Samples/XR Interaction Toolkit/2.6.4/XR Device Simulator/` into the scene.

On Windows, if cloning fails with "Filename too long", run `git config --global core.longpaths true` and clone again.
