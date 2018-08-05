# VR Maze

![Alt text](/Screenshot.jpg?raw=true "Screenshot")

Unity Editor Version: 2017.4.4f1
Google VR SDK: GVR SDK for Unity v1.100.1

A Maze Base Version: v6.0.0

Built for iOS

Assets Used:

Company: Gamemaster Audio
Asset Name: Pro Sound Collection
Where Used: For all SFX aside from the main score.


Company: JOHN LEONARD FRENCH
Asset Name: Ultimate Game Music Collection
Where Used: For the main score.

Company: Unity Technologies
Asset Name: Standard Assets Pack
Where Used: For Fire Particle Effect, and Water Box.


In Unity editor:
Alt+Mouse drag will rotate the camera.
Staring at the tips will fade in and fade out new tips.
Clicking a waypoint or coin will interact with it.
Clicking the door will open it if unlocked, Clicking on signpost will indicate victory

In VR:

The following things were added/edited from the default project.

Project Base Requirements:

The Maze is designed in such a way that the user can not identify a path to the Key from the start position.

Waypoints are placed throughout the Maze in such a way that the users can navigate from the start position to all the game objects that can be interacted with, i.e. all the Coins, the Key, the Door, and the SignPost.

There is a minimum of five Coins in the Maze.

There is a minimum of one Key in the Maze.

The Door prevents the user from navigating to the SignPost until it has been opened.

The SignPost cannot be seen or interacted with before the Door is opened.

When a Coin is clicked, a sound effect is played at the location of that Coin.

When a Coin is clicked, that Coin is removed from the scene hierarchy.

When the Key is clicked, a sound effect is played at the location of the Key.

When the Key is clicked, the Key is removed from the scene hierarchy.

When the Key is clicked, the Door becomes unlocked.

When the game starts, the Door is locked and closed.

The Door cannot be opened when it is locked.

The Door can only become unlocked by clicking the Key.

When the Door is clicked and unlocked, the Door starts opening.

When the Door starts opening, a sound effect is played at the location of the Door.

The Door is animated to an open position by code only, i.e. not by using animation and animator controller.

When the SignPost is clicked, the scene resets to its initial state so the game can be played again.

In addition to these things:

Hints are scattered throughout the maze to communicate what is going on to the user

Custom script written to fade in and fade out text

Lighting provided throughout maze

Water and Fire are added to scene

Various SFX were imported.

Overlying Score plays when game is playing

Victory SFX plays on victory.

Teleport SFX is changed.
