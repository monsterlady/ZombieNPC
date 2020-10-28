<h1 align="center">Zombie State Machine 👋</h1>
<p>
  <img alt="Version" src="https://img.shields.io/badge/version-V0.1-blue.svg?cacheSeconds=2592000" />
  <a href="doc/UserPDF/html/index.html" target="_blank">
    <img alt="Documentation" src="https://img.shields.io/badge/documentation-yes-brightgreen.svg" />
  </a>
  <a href="todo" target="_blank">
    <img alt="License: MIT" src="https://img.shields.io/badge/License-MIT-yellow.svg" />
  </a>
</p>

> Two types of zombie that follows FSM pattern in Animator

## What is this Project?

It is a simple implementation of an :robot: A.I. behaviour :suspect:, by using the 'State Pattern' and State Machines in Unity3D :video_game: and C#. It is fully based on two great Blog Articles on internets.


### 1- Unity3D AI with State Machine (FSM), Drones, and Lasers!:gun:
Link: https://unity3d.college/2019/04/28/unity3d-ai-with-state-machine-drones-and-lasers/


### 2- Unity3D Design Patterns – State – :robot:  Building a Unity3D State Machine
Link:
https://unity3d.college/2017/05/26/unity3d-design-patterns-state-basic-state-machine/


### 3- And the YouTube video (Tutorial): :movie_camera: Unity3D AI with State Machine (FSM), Drones, and Lasers!
Link:
https://www.youtube.com/watch?v=YdERlPfwUb0

### 4- ADVANCED AI IN UNITY (Made EASY) - STATE MACHINE BEHAVIORS
Link:
https://www.youtube.com/watch?v=dYi-i83sq5g


## Notes:

:bulb: There are 2 different AI in the project:

#### :low_brightness: 1- Normal Zombie:
An A.I. example using substatemachine : An Super-Big Switch - Case with too many cases. Each 'animator' behaviour would correspond to a State of the A.I. (for instance: Walk, knock back, chase, etc.);

#### :low_brightness: 2- Crazy Zombie:
The recommended A.I. implementation, using a simple designed and simple 'animator State Pattern' in C# comparing to normal Zombie. 
The Scripts and code for this AI can be found inside the  'Assets/Scripts/CrazyZombieScripts/'  folder.


:bulb: I was motivated to write this code because of the tutorial from youtube and the animator usage which is way more understandable to me.


:bulb: This code is not :100: Optimized. It is intended to be a Template for Prototyping and making Game 'Proof-of-Concept' Demos. For making it a final product; it would be necessary to make some changes, for example: adding more states like crouch, climbing and fall down etcs to make it smooth , and we would need to remove the constant execution of GetComponent<>() from the collider. One possible solution would be to cache all game Characters that are to collide (in a Static Dictionary) inside a Component (maybe a Static Class), and compare in each Frame (update() execution) the Collider 'ID' with the one we would have cached (i.e.: a simple Search in the Dictionary, by 'ID'). Using well limited Raycasts is ok, but the command Debug.Raycast is just for 'debugging', so it would need to be commented out too.


:video_game: It was made in Unity 2020.1.5f1.


I hope it to be useful for anybody studying A.I.

Ruikang Xu



### 🏠 [Doxygen Documents](#)
```sh
Doxygen documentation path : newDoc/UserPDF/html/index.html
```

### ✨ [webGL Demo](https://monsterlady.github.io/ZombieNPC/)

## How to play

**W,A,S,D** move the player, **left shift** boost, **space** to jump,
Hold **right button** of mouse to attract zombies.

## Environment

```sh
Unity 2020.1.5f1
Windowns 10 64 bits
```
## FSM Design
In this Project, the state machine pattern follows the abstract class ***StateMachineBehaviour*** with ***Animator***,
and the NPC(zombies in this case) cooperate that with the Controller which extends ***MonoBehaviour***

## NPC Intro
the StateMachine Designs could be found in ***.Assets/Scenes***
```sh
Normal Zombie: 
Slow movement, 
poor eyesight and hearing(has a range), 
will not actively attack the player unless the player makes a sound or being bumped
```
![avatar](https://github.com/monsterlady/ZombieNPC/blob/master/newDoc/nzState.png)
![avatar](https://github.com/monsterlady/ZombieNPC/blob/master/doc/NormalZombie1.png)
![avatar](https://github.com/monsterlady/ZombieNPC/blob/master/doc/normalZombie2.png)
```sh
Crazy Zombie:
move fast,
can not see anything,
sensitive to sound, it will run towards whereever the sound made then starting to attack
will not stop attacking target untill it hear another sound
```
![avatar](https://github.com/monsterlady/ZombieNPC/blob/master/newDoc/czState.png)
![avatar](https://github.com/monsterlady/ZombieNPC/blob/master/doc/crazyZombieState.png)

```sh
Interaction between NPCs:
It happens when normal zombie bump crazy zombie, the former will be knocked back, the latter will adjust direction to aviod being bothered.
```
![avatar](https://github.com/monsterlady/ZombieNPC/blob/master/doc/GIF%202020-10-2%2020-45-35.gif)

## Author

👤 **Ruikang Xu**

* Github: [@Bestitz](https://github.com/monsterlady)



## 📝 License

Copyright © 2020 [Ruikang Xu](https://github.com/Bestitz).<br />
This project is [MIT](https://github.com/monsterlady/ZombieNPC/blob/master/LICENSE) licensed.

***
_This README was Wrote by Ruikang's ❤️_
