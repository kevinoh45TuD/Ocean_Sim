# Ocean Simulation

A short scene based on simulating fish in the ocean.

Story Summary:

- Seagull flies into scene, boats visible
- Camera moves to above boats looking down
- Boats circle area above group of fish
- Camera moves down to fish and locks onto one fish
- This fish swims away from group and is followed by shark
- The end

Youtube Video of my Project:

[![Youtube Video](https://img.youtube.com/vi/QlG9CWjS92U/0.jpg)](https://www.youtube.com/watch?v=QlG9CWjS92U)


Scripts:

For my scripts there are a few 'Managers'. I used empty game objects with a script on them called X Manager. They do a lot of controlling from different aspects of my scene.
An example of this is the 'camera manager'. This will keep any reference of new cameras that come into the scene and have a function to turn on the next camera in the list and turn off the previous one.

Another type of script/behaviour I use frequently in my scene is a path following behaviour. I will have a list of transform locations and It will make the game object with this
behaviour move to the location of each point on the path, once it reaches it then it will move to the next point on the path.

The final main script behaviour in my scene is the flocking behaviour. It controls the behaviour of the fish to move around in an area and avoid each other.
For this behaviour I followed a tutorial about fish flocking.
https://www.youtube.com/watch?v=mBVarJm3Tgk


Art Assets:

For my 3D models I used a low poly asset pack that I owned.
https://assetstore.unity.com/packages/3d/props/low-poly-ultimate-pack-54733

It featured quite a few assets that I felt were relevant to my concept. I also quite like the look of low poly models.

For my scene I also used a song I found from youtube that I felt fit well with my scene.
https://www.youtube.com/watch?v=czTksCF6X8Y


Graphical Technique:

I added a trail renderer to each of the fish in the scene so that they are easier to see at a distance, but also to make them look nicer.
