# Hunter Games
*2D fighting platformer with bows and post-death building mechanics*

## Lore
- None

## Gameplay

### Basics
- **Genre:** 2D fighting platformer
- **Multiplayer:** Max. 4 players -  1v1, 2v2, and Free-for-All (1v1v1 | 1v1v1v1)
- **Core Mechanic:** Every player is equipped with a <ins>bow</ins> and a <ins>hook</ins>
- **Maps:** Map voting system
- **Match Format:** Played as a best-of-13 (first to 7 points)
- **Power-ups:** Random drops to enhance combat

### Bow Mechanics
- **Projectile-based:** Arrows follow physics-based trajectories
- **Aiming:** Drawing the bow displays a visual trajectory path
- **Power Scale:** Shot distance, velocity, and damage depend on how long the draw button is held

### Hook mechanics
- **Aiming:** Players can use a hook that shoots in the direction they are aiming
- **Range:** The hook has a limited range
- **Pulling:** When colliding with a surface (solid or walkable), the player is pulled toward the location where the hook landed
- **Cancellation:** The hook can be cancelled mid-pull
- **Cooldown:** After the hook is used the player won't be able to use it again for a few seconds

### Lobby
- **Host Control:** The lobby creator can manually change the team size before a map is selected
- **Voting System:** Players can select maps in the lobby using a voting system similar to **Ultimate Chicken Horse**
  
### Maps
- **Spawn Points:** Maps have predetermined spawn points that adapt to the number of teams (1v1, 2v2, or 1v1v1)
- **Team Spawns:** Teammates spawn at the same location
- **Restricted Placement:** You cannot place an object that would collide with a spawn point at the start of a round

### Match Flow
- **Objective:** Eliminate the opposing team
- **Loser's Advantage (Building):** After a round ends, the losing team is granted the ability to place obstacles on a grid
    - **2v2:** The losing team places 2 obstacles
    - **1v1:** The loser places 1 obstacle
    - **1v1v1:** Both losing players place 1 obstacle each
- **Winning Condition:** The match is played as a best-of-13 (or what we find the most comfortable to play with)
- *<ins>Additional</ins>* - **Victory Screen:** Features an interactive winning screen similar to **Party Animals**

### Power-ups
- **Spawning:** Power-ups drop from the sky or spawn randomly on the ground
- **Examples:**
    - **Increased Projectile Speed**
    - **Higher Damage**
    - **Special weapon:** bomb instead of a bow