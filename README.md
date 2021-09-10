# Foreword
By joining this GitHub, reading this document, and participating in its source code, you agree to standard NDAs (non-disclosure agreements). If you do not agree to the terms of a standard NDA, please close this window and notify the GitHub owner (Duncan Day) of your non-agreement.

# Dungeon-Runner
Dungeon Runner is a free-to-play (F2P), 2-10 player game, focusing on the PvE experience. Players will delve into dungeons (levels) and earn in-game rewards. There are no plans to introduce matchmaking or PvP experiences.

It will be finalized in Unreal 5 in an FPS style, including its melee combat (which will allow shielding/guarding in the form of Titanfall 2's vortex shield)

### Inspirations
Dungeon Runner is the working title name, and takes inspiration from several games in various aspects:
- The Elder Scrolls III: Morrowind: in dungeon/world-map uniqueness, level scaling
- Warframe: using the F2P model (crafting + expediting for money), group-joining to play levels (it supports 1-6 small levels, and server-limit open-roaming)
- League of Legends (2021): F2P model (like Warframe, allowing cosmetics and other in-game characters to be unlocked by playing enough, and allowing microtxs for instant unlocks), in-game item synergies (though altered)
- Overwatch (pre-2018): like League of Legends, taking the "hero shooter" format and transforming it into a PvE experience, although with more customization
- Divinity: Original Sin 2: character and skill customization and inter-skill "element" interactions (skillbars, oil + fire = explosion, water + lightning = shock, etc.)
- Apex Legends/Titanfall: first-person, high-intensity/action shooter, allowing for a low skill floor and high skill ceiling (like Warframe, it brings in new players, but allows dedicated players to master "tech"). Also, wall-running and an energy-system based on the Vortex Shield (the ability that catches bullets and throws it back. it's badass.)

# DevTools
Inspirations are acknowledged, but the DevTools allows for the scalability of this project. DevTools will act as a GUI-version of boilerplate code for easy access to non-programmers (generally, designers). This allows for easy iteration of game design and abstraction for numerical design (e.g., "should this character/item/spell do 10 or 100 damage? should we include a range and pseudo-randomize the numbers? etc.)

**Wireframes will be presented for the following tools in a separate file section.**

Currently, the following DevTools are in order: 
1. "Unit Maker"
2. "Dungeon (Level) Designer"
3. "Spell Maker"
4. ...placeholder...
  
## Unit Maker
The Unit Maker is an object-design system. A wireframe will be made to give an idea of the GUI necessary for this devtool. More detailed sub-concepts in this wireframe will be added later. (such as methods)

The Unit Maker is a tool for a 3D-object-designer in Unreal Engine 5. It will specify the following aspects:
- SIUs and NSIUs: (non-)sentient-interactable-units. SIUs include: characters, NPCs (including monsters), and anything that can interact with another IU (interactable unit). NSIUs include: trees, rocks, chests, and other objects which are able to be interacted with in a one-way "method-receiving," but not vice versa. (however, NSIUs may have the ability to transform into an SIU.)
- Units also include characters, which are considered SIUs. The Unit Maker must allow for instantiation of these objects and save-states.
- Units also include items, which are considered NSIUs. The Unit Maker must allow for the creation of these objects and adding to IUs as a component.

## Dungeon (Level) Designer
The Dungeon (Level) Designer is a layered map system. It will allow a designer to either design a level linearly (manual placement), dynamically (automatic placement), or a hybrid of linear-dynamic generation.

The layered map system follows this schema:
1. Layer 1: Grid-based "wireframe" - this allows for layers above it to be affected by this layer
2. Layer 2: Visual/object generation - based on Layer 1, this layer will generate IUs, terrain, and other notable features. 

For example, if a map were to be generated dynamically, Layer 1 defines the size of the map in an A x B matrix (e.g., 8 x 8, the equivalent size of a chess board).
Layer 2 allows for rocks (a form of NSIU) to spawn on select - or random - squares, and then before the map is rendered and displayed to the client (player), rocks that are set on adjacent Layer-1 tiles will generate a "larger rock" that occupies those spaces in a 3D space.
This allows for a linear-dynamic hybrid generation.

## Spell Maker
The Spell Maker is very similar to how The Elder Scrolls III: Morrowind utilizes their spell-making/enchantment system.

In summary:
1. The player chooses a spell, such as "Levitation." Selecting this spell has an inherent currency cost.
2. The player then chooses several aspects of this spell to increase its efficacy. For example, if "Duration" was increased as *n* approaches +*inf*, the cost increases exponentially *x^n*.
3. The player then pays the in-game currency cost of creating this spell, and then can name it.

A wireframe of the "Elements" system will later be updated here.

### Introducing unique elements on gameplay loops
The concept of allowing the developers and/or players to create their own characters to a detailed degree allows for unique elements to be added to the gameplay loop.

For example, a concept I've been playing around with is character permadeath, emulating roguelite progression. A unique element that can be applied to an RPG concept such as this is allowing for your created-character's permadeath in exchange for a chance at a more exotic item.

Many RPGs, especially group RPGs, want to encourage this sort of hoarding of items (in my experience, at least). So, I would like to explore this concept of risking your character's life for exotic gear, but this gear is not revealed (or generated) until the player opts into this risk.
