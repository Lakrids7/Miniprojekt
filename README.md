Overview of the Game:
The project is a 3D first-person platformer with a linear level based in an island setting, in which the player must progress through. In order to do this, the player is to jump from platform to platform and dodge various obstacles. The properties of the platforms vary depending on the color of the platform, with each property being triggered as the player touches them. The properties are the following:
-	Tan platform: The “regular” platform which does nothing upon contact.
-	Red platform: Sinks into the water, killing the player if they fail to get off the platform
-	Yellow platform: Moves in a given direction for a varying amount of time.
-	Pink platform: “Bounces” the player upwards.
In addition to these platforms, the player must also dodge falling boulders, swinging boulders, and spinning “logs”. Upon contact with any of these obstacles, the player “dies” and is transported to either the start of the level, or a checkpoint in case they have progressed past certain triggers. In case the player falls off the platform into the water, they are also transported back to the start or a checkpoint. The UI contains two elements: A timer and a stamina bar. The timer counts the amount of seconds the player takes to complete the level, and highlights this upon completion of the game. The stamina bar shows the amount of stamina the player has. Stamina is used to “sprint”, allowing the player to run faster when holding shift. Throughout the level two pick-ups are placed: Stamina sodas and watches. The stamina sodas refill the players stamina. The watch decreases the timer by 5 seconds.
Project Parts:
-	Scripts:
o	PlayerController – used for first-person movement along with camera rotation
o	ResetLocation – used to reset the location of the player upon collision with an obstacle or the water.
o	SinkingPlatform – transforms the platform downwards upon collision with a player.
o	MovingPlatform – moves the platform upon collision with the player.
o	BouncingPlatform – increases the players vertical speed upon collision.
o	StaminaPickup – refills the players stamina upon collision.
o	Timer – keeps track of the amount of time passed and updates the UI.
o	Win – shows the winscreen when the player reaches the end of the level.
-	Models & Prefabs
o	Particle smoke effect downloaded from https://assetstore.unity.com/packages/vfx/particles/fire-explosions/free-stylized-smoke-effects-pack-226406 (Used for volcano smoke)
o	Skybox downloaded from https://assetstore.unity.com/packages/vfx/particles/fire-explosions/free-stylized-smoke-effects-pack-226406
o	Palmtree, barrel, watch-pickup, stamina soda-pickup and volcano were made by me in Blender
o	The rest of the models were made in Unity using probuilder or primitives.
-	Sound and music:
o	Sound effects downloaded from freesound.org and pixabay.com
	Stamina soda: https://freesound.org/people/tapochqa/sounds/573582/
	Watch pickup: https://freesound.org/people/ST303/sounds/171043/
	Bounce sound: https://pixabay.com/sound-effects/boing-6222/
o	Wave sound is downloaded from https://www.youtube.com/watch?v=5nI8EyKMo2E
o	Music is Melody of Jellyfish by Yu-Peng Chen (downloaded from https://www.youtube.com/watch?v=sNOufksym5Y&list=PLUJ9TtKEOLBzDYYN6dJyxtskSJJUdawCh)
-	Materials:
o	All materials have either been made in Unity or Blender
-	Scenes
o	Game consists of one scene
-	Testing:
o	Games was tested on Windows only
Time Management:
Task	Time it Took (in hours)
Setting up Unity, making a project in GitHub	0.5
Research and conceptualization of game idea	0.5
Searching for assets: Skybox, particle effect	0.5
Building 3D models from scratch -barrel, palm tree, soda, watch, volcano	10
Making camera movement controls and initial testing	1
Player movement (Taken from previous project)	0.5
Implementing behavior for the different platforms	3
Implementing obstacles behavior	1
Implementing pickups (Stamina soda + watch pickup)	1
Implementing timer	0.5
Implementing respawn and checkpoints	1
Implementing win screen	0.5
Adding sounds and music	1
Level design and testing	12
All	33

Used Resources:
-	Movement script taken from previous project
-	Tutorial for barrel modelling in Blender: https://www.youtube.com/watch?v=_Iu88tZ9utE&t=276s
-	Tutorial for palm tree modelling in Blender: https://www.youtube.com/watch?v=Z1PxTboz-nw

