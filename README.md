# Space Adventure – Third-Person Survival Game

A 3D action-adventure survival game built in Unity where the player must collect spaceship parts and survive against hostile alien creatures. Built as a full project for Harvard's edX Game Development course.

## 🌌 Game Summary

The project that I have made in Unity is a third-person 3D game where the objective is for the player to collect materials for their ship that has crashed on an unknown planet. There are giant spiders on the planet that will chase the player if the player is near them and will attack the player if they can get close enough. The player has a health bar and when the player has taken too much damage from spider attacks the game ends. The player has a stick to defend themselves from the spiders which they can use to swing at the spiders and kill them. Once the player has collected enough materials without dying to the spiders they win the game.

The first thing that I did when making this game was creating the player. I imported the Third-Person Controller from the Unity Starter Assets and used the model and animations that are provided with that asset to set up the player character. I then set up the camera to follow the player. I knew I wanted to have the world be set in space, so I dowloaded a space soldier model for the player character that would fit with the basic humanoid skeleton and animations that come with the Third-Person Controller. I also adjusted the jumping so that it would seem like there is less gravity.

The next thing that I did was set up the environment that the game would take place in. I downloaded assets to use for the trees and the ground and I set up a plane that the player could move around on using those assets. I wanted the environment to be slightly different for every playthrough of the game, so I decided to make a spawner that would randomly spawn rocks around the map. I downloaded assets to use as the rocks and wrote a script that would randomly spawn these different rocks around the map. I also added some mountains surrounding the area that the player can play in and an invisible wall that prevents the player from leaving the play area and going out to the mountains.

I added a model of a crashed ship to the middle of the map and used downloaded particle effects to make the ship look as if it was on fire. I added a collider around the ship to prevent the player from walking through it. The next thing that I added was the materials that would randomly spawn around the map for the player to collect. I wrote a script for the materials to rotate so the player can see them and for the materials to disappear on collision with the player. I wrote another script to keep track of how many the player has collected. I used the random spawning script from earlier to have the materials randomly spawn around the play area. I also added a counter that would display how many of the materials the player has collected.

The next thing that I added was the spiders that randomly spawn around the play area. I downloaded assets to use as the spider and used the animations that were provided. I then wrote a script to have the spiders wander around the map. I added to that script the ability for the spiders to chase the player when the player comes near them and the ability for the spiders to attack the player if they are really close to the player. I added a health bar and wrote a script to keep track of the players health and make the player lose health if they are attacked by a spider. I used turning box colliders on and off to simulate the attacking. I also added an animation for the player dying if they run out of health.

I then added a way for the player to attack the spiders. I gave the player a stick in their hand and added a box collider for the player to simulate their attack. I added an attack animation to the players animator and wrote a script that would turn on the attack collider and trigger the attack animation when the player left-clicks. I then wrote a script for the spiders to trigger a death animation when they are attacked and to spawn particle effects and then dissappear from the game.

I then created the different states for the game. I created a MainMenu state that shows the player model in its idle animation on a spaceship. In this state the player can quit or continue to the Instructions state. The Instructions state gives the backstory of the game, demonstrates what the materials that they are looking for look like, and displays the controls of the game. The player can press a button to continue to the Play state. The Play state contains everything from the above paragraphs. When the player runs out of health in the Play state they are sent to the GameOver state. The GameOver state gives the player the option to return to the MainMenu state and play again or to quit. If the player collects enough materials they are sent to the Win state. The Win state has the same options as the GameOver state.

The final part that I added was the music and sound effects. I added music for the MainMenu and Instructions states that turns off when the player gets to the Play state. The Play state contains forest sounds and a fire burning sound for the crashed ship that gets quieter as the player moves away from it. When the player attacks, an attacking sound plays. When the spider attacks, a biting sound plays. When the spider is killed, a hissing sound plays. When the player dies, a moaning sound is played. A sound also plays when the player collects materials. In the GameOver scene a game over sound effect plays. The Win scene contains triumphant music.

## 🛠 Technologies Used

- Unity 3D (C#)
- Unity Starter Assets (Third-Person Controller)
- NavMesh AI
- Animator Controller
- Sound & Audio Manager
- Particle Systems

## 🧠 Key Learning Outcomes

- Implementing player controls with Unity's third-person system
- AI systems: enemy behavior, proximity triggers, health/damage logic
- Random generation for replayability (rocks, spiders, materials)
- Scene management for game states (menu, play, win, lose)
- Using Unity’s Audio and Particle Systems to enhance immersion

## 📺 Video Demo

[Watch on YouTube](https://www.youtube.com/watch?v=CufS2USIR1Y)

## 🕹️ Play (Itch.io or WebGL Link)

[Play Here](https://ethanperello.itch.io/space-game)
