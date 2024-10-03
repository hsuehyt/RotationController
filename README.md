# RotationController

This Unity script allows you to rotate multiple 3D game objects at the same constant speed but in different, evenly spaced directions. It is designed to work with any 3D objects in your scene, and rotation directions are automatically calculated.

## Features
- **Automatic Direction Calculation**: All objects rotate in evenly spaced directions along the x, y, and z axes.
- **Single Speed Input**: Set one common rotation speed for all objects.
- **Endless Rotation**: The objects rotate continuously based on the assigned direction and speed.

## Usage

### Setup
1. Attach the `RotationController` script to an empty GameObject in your Unity scene.
2. In the Unity Inspector, add the objects you want to rotate by expanding the `Objects To Rotate` list and assigning GameObjects.
3. Set the `Rotation Speed` for all objects. This speed is applied equally to all objects.
4. Press play, and the objects will rotate endlessly with different directions but at the same speed.

### Inspector Properties
- **Objects To Rotate**: A list of 3D GameObjects that will be rotated by the script.
- **Rotation Speed**: The common rotation speed applied to all objects in the list.

## Example

1. Create multiple GameObjects (e.g., spheres, cubes, custom models) in your Unity scene.
2. Attach the `RotationController` script to an empty GameObject.
3. Add the GameObjects you want to rotate into the `Objects To Rotate` list.
4. Set the `Rotation Speed` to control how fast the objects rotate.

## Script Breakdown

### `RotationSettings`
This is a custom class that holds the reference to each object and automatically calculates its rotation direction.

### `SetRotationDirections()`
This method calculates evenly spaced rotation directions for all objects in the `Objects To Rotate` list. The directions are automatically assigned during runtime.

### `Update()`
The `Update()` method continuously rotates the objects based on their assigned direction and speed.