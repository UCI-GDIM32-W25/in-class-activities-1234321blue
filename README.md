# GDIM32 In Class Activities
## Week 1
### Activity 1
Some advice that our table came up with was to predict how long an assignment might take you in order to get in on time, not finishing it up in the last minute. We also said that it was important to utilize class resources, whether it be the la tech hours, unity documentation, or even just lecture and or pre-learning slides.
### Activity 2
1. x = 10
2. x = 2
3. They would print into the Unity console the words "hello word" every frame. 
4. MonoBehaviour
5. When the game starts up, it will call the "PrintMessage" method with its argument being 10. The method itself prints into the console the phrase "x = " and adds on the inputed argument at the end of it. Overall, at the start of the game, the message "x = 10" will print out once in the console.
6. The highlighted pieces of code are the arguments, which give an input into the respective method that is trying to be called.
7. In Update, the object's Transform class is defined as _playerTransform, which should be used instead.
8. _playerTransform
### Activity 3
[MG1 Breakdown Link](https://docs.google.com/document/d/1ZloeI2O3HLCZUm7UvvfKdylog4EuKHg3eZPcW1Tevz0/edit?usp=sharing)
## Week 2
### Activity 1
![IMG_1662-2](https://github.com/user-attachments/assets/632552ab-d80f-4a5c-aa96-bbc1688b9405)
### Activity 2
[GameObjects and Jumping](https://github.com/UCI-GDIM32-W25/mg2-1234321blue/commit/9b439635a8c09dd64bf7cce390028245b5f5e71d#diff-e65036fee1cff958931462d7536a02606acb134d91dd8b158421aa01ba3f1f5f) [Fixed Jumping](https://github.com/UCI-GDIM32-W25/mg2-1234321blue/commit/d9dc70cf2f32febf7b2fa7d19671594666130f92)
I added the basic game objects such as the player character, the ground, and the UI. Along with this, I added a Player script and coded it to make the player jump when you press space.
## Week 3
### Activity 0-2
Gael Porras
### Activity 3
![IMG_1668-2](https://github.com/user-attachments/assets/91cd920d-c930-4702-9af1-832e0b1e19fc)
## Week 4
### Activity 0
Gael Porras
### Activity 1
When you add multiple Locator objects to the scene and run the game, though the empty object itself will not be destroyed, the Locator component on these objects will disappear besides one. This happens because, on Awake, the Locator class will check if there are other Locator classes and if they are the this, and is so, they will destroy, eventually just leaving one Locator class.
### Activity 2
![IMG_1679](https://github.com/user-attachments/assets/2d9de740-0f84-49b9-8910-a92c1ae792e1)
### Activity 3
I added the sprites into the game and created the basic visual assets of the game, such as the bird and the floor. I also changed the aspect ratio to better fit the game of floppy bird.
## Week 5
### Activity 1
If I were implementing the IBreakable interface and Item abstract class just as it was, I think I would change Item from an abstract class to an interface as, in its current form, it only has an abstract method, which I could easily translate into just an interface. But in a broader scope, seeing as an item would probably have more than just interactions in common, such as durability or maybe an attacking power, I would probably keep it as an abstract class as they're more convenient for similar objects in a game.
### Activity 2
In demo 2, a class representing the model was the enemy script that was the scriptable object as it held only data. A class representing the controller part of the MVC design model would be the script running how the player interacts with the enemy and what they say as this is the logic that is actually running the game. Finally the view part of the model would be the class that just sets the dialogue of the enemy and shows it on screen.
### Activity 3
#### Scenario 1
For the rhythm game, you could use inheritance to make all the different type of beats you want in the game. Using something like an abstract class to determine the basics of each note (movement, getting hit, etc), you then make different types of notes by creating child classes that specify details to make them unique (movement speed, score, what key hits what note, etc). You could also use a Singleton in reference for a GameController, which would hold information like points and timing for the song.
#### Scenario 2
For a team shooter, you could probably use inheritance to make a base for all your characters with an abstract class or something of the sort, including movement, health, and attacking. From there, with child classes, you make each unique character, implementing a unique ability seperating the characters apart from each other.
#### Scenario 3
With the farm simulator, for the different things you can plant, you could use a mvc design model to keep the various plants' information as a scriptable object, than script the logic behind the player being able to interact with all the different plants. Then you could seperate out the view with events based off the logic code, including the player animation.
### Activity 4
Attendance: Gael Porras, Jeremiah Yang

Proposal: [Final Project Proposal](https://docs.google.com/document/d/1-4LVGJgfxqEb7zRdfGDfO5tOJxruOldH0SpWawnbftE/edit?usp=sharing)
## Week 6
### Activity 1
#### Merging
- When presented with conflict, hit open in Visual Studio
- Line with "HEAD" above it is your line of code, below that will be the conflicting line
- Once edited, you can go back to GitHub and push your change
- If changing code through conflicts, go back to Unity first and test before pushing
#### Profiling
- Window to Analysis to Profiler to access in Unity
- When red dot is active, profiling of game is happening
- Hierarchy in Profiler tool shows how long anything in the Scene is taking to load
- Profiler can help identify any big lag points in game
- Issues:
    - Using complex colliders can slow down your game a lot
    - GetComponent() method is slow to use, avoid when you can
    - Huge Textures may take too long to load
    - Don't use more rigidbodies than you need
#### Gizmos
- Gizmos methods are just called by Unity (don't have to edit it)
- Gizmos only viewable in Scene view
- Example of Gizmos:
    - Using Gizmos to give clearer outlines to Colliders
    - Using Gizmos to show Velocity, generally useful in making Physics or Vectors more visible and understandable
#### Breakpoints
- Click on left of lines to create a breakpoint in code, signaled by red dot
- Go to Run and Debug tag and hit Attatch to Unity to see whats going on
- Breakpoints stop the game from running when the line of code is attatched to is run
- Call stack tells you what methods were called before your breakpoint
- Hovering over variables in your code tell you what value they are holding
### Activity 2
Attendance: Gael Porras, Jeremiah Yang

Proposal: [Final Project Proposal](https://docs.google.com/document/d/1-4LVGJgfxqEb7zRdfGDfO5tOJxruOldH0SpWawnbftE/edit?usp=sharing)
## Week 7
### Activity 1
- Gizmos used to simulate line of sight on duck or raycast
- Duck uses finite state machine to define movement behavior, walking vs chasing player
- Finite state machine used here as these different movement behaviors are mutually exclusive, meaning they shouldn't be happening at the same time
- Raycast defined from where it starts, what direction it is going, and how far it should go
- Raycast is ultimately boolean, checking for if the raycast actually hit something
- Spherecast used to check area for obstacles, checks within a whole area as opposed to a single point
### Activity 2
Attendance: Gael Porras, Jeremiah Yang
### Activity 3
![IMG_1694](https://github.com/user-attachments/assets/1605a011-1619-4945-a5de-189c43564c49)
### Activity 4
[Final Project Taskboard](https://docs.google.com/document/d/1qcCvx221nZpAMjmwJdpyKQ7kBxEmTlBFmETyLgA6mj8/edit?usp=sharing)
### Activity 5
[Commit Link](https://github.com/1234321blue/GDIM32-Final/commit/ee2b387035a217081c1f222039a5b7f17f04a5be) 

I created basic prefabs for our playable character and our main NPC. I also created the basic scripts that will be controlling them.
## Week 8
### Activity 1
- Rendering Pipeline is what tells a game what objects and things to draw into the screen (CPU to GPU)
- For assets on Unity, check if the rendering pipeline matches your build's rendering pipeline type (built-in, universal, etc.)
- Post-processing applies a shader over your entire screen
- Post-processing can make your game look brighter or bring it together more thematically with colored shading
- For post-processing fx from Unity asset store, once again check if rendering pipeline is consistent with your build
- Check itch build after adding post-processing to make sure it doesn't tank your game's performance
### Activity 2
Attendance: Gael Porras, Jeremiah Yang
### Activity 3
#### Playtesting Notes
- Suggested alterior endings like an ending where, at the beginning, you could get a new interaction after saying no to the NPC's request 
- Suggested adding a gun to items you could interact with 
### Activity 4
For today, I will try to get player movement and camera movement working smoothly.
### Activity 5
[Commit Link](https://github.com/1234321blue/GDIM32-Final/commit/765e32eff1e21107ac590b6c9d2168d4329a3b5d) 

I added code to the Player script that allows for movement, implementing a steering kind of system where the player can go back and forward while the left and right keys change where the player is facing, changing the direction they go when moving. Also added camera as child of player to make sure it followed them around. 

