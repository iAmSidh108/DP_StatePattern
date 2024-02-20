# **State Pattern in Unity:**

## **What is the State Pattern?**

The State Pattern is a behavioral design pattern that allows an object to alter its behavior when its internal state changes. This pattern involves creating state classes that represent various states of an object and a context class that allows the object to switch between these states. The object appears to change its class when its internal state changes, providing a more organized and maintainable approach to managing state-specific behaviors.

![state-en](https://github.com/iAmSidh108/DP_StatePattern/assets/63715240/5cb276cd-f2a5-4a5e-a092-0921fdfeeb29)

## **Examples of using the State Pattern in game development:**

1. **Character AI Behavior:**
   - **Context:** Represents a game character.
   - **States:** Different AI behaviors such as "Patrol," "Attack," and "Idle."
   - **Transition:** The character transitions between states based on certain conditions (e.g., spotting an enemy, completing a task).

2. **Game Menu System:**
   - **Context:** Represents the game menu.
   - **States:** Different menu screens (e.g., "Main Menu," "Options," "Pause").
   - **Transition:** The menu transitions between states when the player navigates or performs certain actions.

## **Drawbacks of using State Pattern:**

1. **Increased Number of Classes:**
   - Introducing multiple state classes can lead to an increased number of classes in the project.

2. **Complexity for Simple Systems:**
   - In simpler systems, using the State Pattern might introduce unnecessary complexity.

3. **Potential Overhead:**
   - Depending on the implementation, there may be a slight overhead associated with switching between states.

## **How to implement State Pattern:**

1. **Identify States:**
   - Determine the different states that the object can be in.

2. **Create State Classes:**
   - Create individual state classes that encapsulate the behavior corresponding to each state.

3. **Define Context Interface:**
   - Define an interface for the context class that allows it to interact with the state classes.

4. **Implement State Transitions:**
   - Implement mechanisms for the context class to switch between states based on certain conditions.

5. **Handle State-Specific Logic:**
   - Encapsulate state-specific logic within the respective state classes.

6. **Use Unity's State Machine Behaviors:**
   - Leverage Unity's Animator and State Machine Behaviors to implement the state pattern efficiently for animations and AI behaviors.

7. **Documentation:**
   - Clearly document the different states, their transitions, and the behavior encapsulated in each state to aid understanding and maintenance.

Implementing the State Pattern in Unity provides a structured way to manage complex state-dependent behaviors in your game, facilitating code organization and maintainability.

## How I implemented State Pattern in this project?
First we tried to implement Finite State Machine as represented in the picture below.
![image](https://github.com/iAmSidh108/DP_StatePattern/assets/63715240/31b5c49a-7fc1-494d-b407-106a48e5bf58)

## Finite State Pattern Script

![image](https://github.com/iAmSidh108/DP_StatePattern/assets/63715240/20d70801-7631-47de-8bbb-faec23857234)


![image](https://github.com/iAmSidh108/DP_StatePattern/assets/63715240/ec9e63f0-f6e0-43dc-8acb-5aac26586bf1)

The problem here is that the traversal is transition-centric not state-centric. This makes it very difficult to flip if we want to change something and human readibility is reduced. This is where state pattern comes in play.

### So this is how we implemented State Pattern.
![image](https://github.com/iAmSidh108/DP_StatePattern/assets/63715240/274d249b-7af1-4240-9dcd-81eaff7f982a)

First we create a base an interface called LocomotionState with 4 functions that every class needs to implement. Also we create a Locomotion main class where we will set the states as current state. And finally we will create different scripts for different states and make it implement Interface that we created in the beginning as LocomotionState. Since the states are transitions if we want to implement those we can or else leave them empty. This will ensure honesty in implementing all the transitions and will avoid any mistake of not implementing it.


![image](https://github.com/iAmSidh108/DP_StatePattern/assets/63715240/72a1237c-6892-425b-952f-0293dee00b61)

## This is for Grounded State.

![image](https://github.com/iAmSidh108/DP_StatePattern/assets/63715240/16f97433-ed97-415d-9005-1c6460fe7410)

## This is for InAir State.

![image](https://github.com/iAmSidh108/DP_StatePattern/assets/63715240/cb1326ea-2dde-4660-9c75-b344102d60a6)

## This is for Crouching State.

![image](https://github.com/iAmSidh108/DP_StatePattern/assets/63715240/e2cb234d-c23b-4d52-a3a1-114e8f488970)
