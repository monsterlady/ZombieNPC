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

### 🏠 [Doxygen Documents](#)
```sh
Doxygen documentation path : doc/UserPDF/html/index.html
```

### ✨ [webGL Demo](https://monsterlady.github.io/ZombieNPC/)

## How to play

**W,A,S,D** move the player, **left shift** boost, **space** to jump,
Hold **right button** of mouse to attract zombies.

## Environment

```sh
Unity Version 2020.1.5f1
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
```sh
Crazy Zombie:
move fast,
can not see anything,
sensitive to sound, it will run towards whereever the sound made then starting to attack
will not stop attacking target untill it hear another sound
```


## Author

👤 **Ruikang Xu**

* Github: [@Bestitz](https://github.com/monsterlady)



## 📝 License

Copyright © 2020 [Ruikang Xu](https://github.com/Bestitz).<br />
This project is [MIT](https://github.com/monsterlady/ZombieNPC/blob/master/LICENSE) licensed.

***
_This README was Write with ❤️ _
