# Intro to VR Research Project

This project will focus on implementing several different ways for a player to swim in an underwater environment.

**Name: Patrick Hunt**

## Interaction Description
The interaction for this project will be swimming, and it will focus on different ways that players can interact with an underwater environment to move around. The 3 different implementations of such movement are described below.
#### Implementation #1: Large Handheld Thruster
   *   The final implementation involves a single large handheld thruster that is held in front of the player similar to what is seen in the game Subnautica. The player will be able to move their left hand onto the thruster as if they were holding onto it and will then be able to press the left trigger to generate thrust and swim around in the underwater environment.
#### Implementation #2: Double Handheld Thrusters
   *   The first implementation of this interaction will involve an implementation of small thrusters on the player's hands. The player will be able to point their hands in a specific direction and generate thrust so as to move in a specific direction. The thrusters will be activated by a trigger press on the controller. Pressing both triggers simultaneously will activate both thrusters at the same time.
#### Implementation #3: Speargun Grappling Hook 
   *   This implementation of the swimming interaction will feature a speargun held by the player. The player will be able to shoot the speargun at an object and will then be able to reel in the speargun to move themself towards the location where the object is attached. The speargun will shoot when the right trigger is pressed, and a button on the right controller will allow the player to reel it in.

## User Test Observations

### Implementation #1: Large Handheld Thruster
#### Observations
- Overall, users demonstrated a sense of familiarity with this implementation.
- Most participants would quickly glance at their hands, and then move their left hand towards the thruster object as expected. From here, there was some experimentation with trigger presses, as users would usually try to thrust by pressing both triggers, and then isolate both the left and right trigger before realizing that the left trigger was the correct one. This is what I expected to happen, as it is somewhat unclear which trigger is the correct one to press once the right and left hands are aligned.
- One user interestingly tried holding the left trigger while pulling his hand back, and then released the trigger hoping to generate thrust.
#### Reflection
I was pleased overall with the test results for this implementation. Most participants behaved as expected and execution of the movement was very smooth. I think this was due to the fact that this implementation as a whole is intuitive and familiar to most people.

### Implementation #2: Double Handheld Thrusters
#### Observations
- Testing participants seemed very comfortable with this implementation and even had different approaches to it.
- Most participants required little to no explanation of the implementation in order to figure it out. They would look at their hands and then experiment with trigger presses. They were then able to quickly figure out that both triggers were valid input.
- Some participants were initially confused as to which direction the thrust was generated. This could be improved by adding particles in the appropriate direction.
- I made it a point to allow for movement using only one thruster at a time if desired. What I found was that participants who utilized this feature seemed to move less efficiently than those who used both hands at the same time to thrust. I expected the opposite to be true.
- There was a mix of users using both hands to move at the same time and users using only one hand at a time. 
#### Reflection
I really liked how this implementation turned out in general. Most participants seemed to have an easy time swimming around and understanding it without me facilitating the interaction. It was interesting to see how some participants would strictly use two hands to thrust as opposed to using one hand at a time, or a combination of one and two hands, and how this seemed to be more efficient.
### Implementation #3: Speargun Grappling Hook 
#### Observations
- Participants overall were able to easily engage with this implementation. Most participants would take a glance at their hands, notice the speargun in their right hand, and then start pressing either the left or the right trigger to attempt to shoot. When they realized it was the right trigger that would fire the spear, they seemed to infer that the left trigger was the one that would reel themselves in to allow for movement. 
- Some participants I noticed would hold the right trigger while the spear was being fired, which was unnecessary as all that was required was a single press of the right trigger.
- One participant attempted to tread water with one hand to reel himself in which I thought was interesting. This could be a cool possible future implementation for this movement.
#### Reflection
I feel that participants were most familiar with this implementation. I believe this is because the grappling hook is a common item in many games that the participants have probably played before, so it was intuitive for most. I do think a different mechanism for reeling the user in to move would be a good thing to implement in the future based on the test interactions because I felt like this implementation could be a lot more interesting while I was watching the users test it. I actually expected this implementation to be the least intuitive because there are quite a few ways that it could work, but I turned out to be wrong as this implementation needed little to no explanation. 

## User Questions

### Pre-Test
1. *Have you ever used any kind of VR swimming interaction before?*
   #### Responses
   - Participant 1 (Peter): "I have not used any swimming interaction"
   - Participant 2 (Jen): "No I have not"
   - Participant 3 (Emily): "No"
   - Participant 4 (Quinton): "No, I have not"
   - Participant 5 (Evan): "No"
2. *How would you rate your experience level with VR technology in general?*
   #### Responses
   - Participant 1 (Peter): "8/10. I am familiar and could make a VR game"
   - Participant 2 (Jen): "I've played a few VR games, I wouldn't say I'm a complete beginner"
   - Participant 3 (Emily): "I don't have a lot of experience"
   - Participant 4 (Quinton): "I feel pretty comfortable with most interactions"
   - Participant 5 (Evan): "I would rate my experience level at an 8 or 9 out of 10. I'm pretty comfortable" 
3. *What are your expectations for how one might move around in an underwater environment?*
   #### Responses
   - Participant 1 (Peter): "Bubbles, lots of blue, and wavy textures" 
   - Participant 2 (Jen): "I'm expecting the grappling hook to be most fun, but I'm looking forward to the other interactions too"
   - Participant 3 (Emily): "I'm expecting to take both hands, move the hands and then propel myself and maybe hold a trigger to move around. I would move both hands at the same time, or one or the other"
   - Participant 4 (Quinton): "Some kind of classic hand paddling movement. I'm expecting some resistance"
   - Participant 5 (Evan): "A lot of hand movements" 

  
### Post-Test

1. *Which interaction was the most intuitive to you?*
   #### Responses
   - Participant 1 (Peter): "The big thruster. The grappling hook could be made more intuitive with additional conveyances"
   - Participant 2 (Jen): "Either the grappling hook or the first big thruster. THe big thruster takes a sec to get a feel for"
   - Participant 3 (Emily): "The Iron Man thrusters because it was clear what direction I was heading in"
   - Participant 4 (Quinton): "Grappling hook because you can easily just point, then you can tell when it’s locked onto something, and then pull yourself"
   - Participant 5 (Evan): "The Iron Man thrusters because my natural instinct is to press triggers where the other thruster requires you to use your left hand to put it near the cylinder before you can thrust"
    
2. *Which interaction did you find the least intuitive?*
   #### Responses
   - Participant 1 (Peter): "Iron man thrusters, because without gravity it becomes a lot more difficult to move around. It would benefit from some bubbles. The grappling hook also needs to be a lot faster and have a trail of bubbles"
   - Participant 2 (Jen): "The Iron Man thrusters because it was the least easy to control, it could benefit from having bubble effects" 
   - Participant 3 (Emily): "The speargun mainly because of the collision detection" 
   - Participant 4 (Quinton): "The first thruster was a bit too slow. It could benefit from a little more of an explanation"
   - Participant 5 (Evan): "The big thruster because sometimes you don’t know if your hand is touching it close enough or not. You could try making it so that the left hand is in a fixed position on the thruster"
    
3. *Are there any modifications that might improve the overall experience with this interaction?*
   #### Responses
   - Participant 1 (Peter): "Having some sort of target for the grappling hook to see where you’re shooting would help a lot. The first thruster needs to be smaller and lower down when you’re holding it. Lights or bubbles, more particles overall"
   - Participant 2 (Jen): "Bubbles might be helpful for the second one. Having the treasure chest higher up for the Iron Man thruster implementation would help because it is easier to move that direction"
   - Participant 3 (Emily): "Change the cylinders to some other shape, and the first one was weird because the left hand could pass through the cylinder but the right hand was fixed. You could make the hands more flush"
   - Participant 4 (Quinton): "All interactions could benefit from bubbles, the single thruster needs nore of an explanation. Having better collision, especially for the castle. Maybe a reset button for each level so the user could start over"
   - Participant 5 (Evan): "You could add coral throughout the map that you could attach to with the speargun. Some music or water sound effect would also be good. Adding some sort of slow gravity effect which would replicate how you would slowly fall down in the water and bubbles would be good as well"

## Storyboards
![IMG_2710](https://github.com/user-attachments/assets/992ac463-bcd7-4f47-8714-4141cbf91628)
![IMG_2712](https://github.com/user-attachments/assets/aa43fa0d-2780-4621-9461-166cc492407f)
