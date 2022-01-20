# Unity Minigame
This project has been develop following the *Roll-a-ball* tutorial, working on it and extending it.<br/>
<br/>
It's a *platform game* with 3 levels. You take control of a blue ball and have to avoid a series of obstacles
in order to pick *12 golden cubes* in each level.<br/>
<br/>
To play the game, download the project, go to the <a href="Builds">Builds</a> directory and execute the *Rollaball.exe*.

### Game Menus
The game has a *main menu* with 3 options.<br/>
You can choose 'PLAY' to start with the first level, 'LEVELS' to access the *level selector menu* or 'EXIT'
to close the game.<br/>
<br/>
In the *level selector menu* you can choose wich of the 3 levels you want to play.<br/>

### Player Controls
To move the ball you can either use the *directional arrows* or *W,A,S,D* (as in almost every computer game).<br/>
Also, you can press the SPACE key in order to jump. This is a key aspect in avoiding obstacles and reaching the golden cubes.
However, you may only jump when touching the ground.<br/>
<br/>
In this project, I used *Cinemachine* package for the camera. Moving your mouse, you can rotate the camera around
the player or tilt it up and down.<br/>

### Screen Display
The total amount of cubes in a level (12) is shown in the *right up corner* of the screen, where it says 'total'.<br/>
We can also check how many cubes we've picked in the same spot, where it says 'count'.<br/>
<br/>
In case we *fail* the level (falling off the map, getting hit by an enemy...) a text will appear on screen telling
us that we've failed. Two buttons we'll appear as well.<br/>
The first button says 'Retry'. It allows us to play the level again.<br/>
The second one is the 'Back' button. We can press it to return to the *main menu*.<br/>
<br/>
If we collect the 12 cubes, a text informing that we've completed the level will appear.<br/>
Now the first button will say 'Continue'. Press it to go to the next level.

### Game Levels
The *first level* is just the 'Roll-a-ball' example. Not much to say here.<br/>
<br/>
In the *second level* the jump becomes important, there're cubes relatively hidden that force you to move the cam
before you move and you have a bigger risk of falling off the map in this a bit larger level.<br/>
<br/>
The *third and last level* is the biggest one and has some of the greatest obstacles, though there're not the hardest ones.
The difficulty here comes with the new implemented *enemies*. All across the map, you can find *red balls* "patrolling" or
moving in a certain area. You must avoid touching them, as this will immediately fails you. However, you'll have to fight your
way as some cubes are located behind these enemies.<br/>

###
That's all. Hope you enjoy it!
