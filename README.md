# unity-gravity-spheres


## Example of gravity around sphere
	
These are the steps I took to make the example scene

1. create sphere as Planet
2. add sphere collider to Planet sphere
2. add `fauxGravityAttractor.cs` to Planet sphere intended as source of gravity
2. add `fauxGravityBody.cs` to Player Controller
3. set Planet as Attractor 
4. add `fauxGravityController.cs` to Player Controller
5. add `MouseLook.cs` to Player Controller
6. add RigidBody to Player Controller
7. add sphere collider to Player Controller

## Example of gravity inside sphere

These are the steps I took to make the example scene

1. import sphere with inverted/flipped normals
2. invert scale of Planet sphere
3. add mesh collider to Planet sphere
2. add `fauxGravityAttractor.cs` to Planet sphere 
3. add mesh collider to Planet sphere
4. add `fauxGravityBody.cs` to Player Controller
4. set Planet as Attractor
5. add `fauxGravityController.cs` to Player Controller
8. add `MouseLook.cs` to Player Controller
6. add RigidBody to Player Controller
7. add capsule collider to Player Controller

