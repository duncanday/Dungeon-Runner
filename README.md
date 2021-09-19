# Foreword
Version: 1.0.0.0
Date: 09/18/2021

_Current Team:_
1. Duncan Day
2. CJ Remeikas
3. Jacob Dekker
4. Andrew Sullivan
5. Chelsea Frederick

Roles are currently non-descript.

# Disclosure
NOTE: By joining this GitHub, reading this document, and participating in its source code, you agree to standard NDAs (non-disclosure agreements). If you do not agree to the terms of a standard NDA, please close this window and notify the GitHub owner (Duncan Day) of your non-agreement.

In the team, there is a zero-tolerance policy for misbehaviors related to socially acceptable manners related to work and play. Naturally, this extends to the players who will eventually play the game; those who do not agree with, or abide by, good manners in gameplay, are subject to the zero-tolerance rule of permanent banning.

# Dungeon-Runner
Dungeon Runner is a free-to-play (F2P), 2-10 player game, focusing on the PvE experience. Players will delve into dungeons (levels) and earn in-game rewards, and out-of-game rewards using Web3 Technology (DLT/Blockchains)

There are no plans to introduce matchmaking or PvP experiences. The concept is to fuel an offline shell program (hereinafter "TURTLE") that will act as a multi-cade system; the game programs will execute from TURTLE's interface from the target OS. (currently, Windows or Linux only)

It will be finalized in a 3D engine. Outside of proprietary engines, the engine-of-choice is Unreal 5 (downloaded on Epic Games Launcher) or Unity 3D. There are no needs to develop proprietary engine software.

## "Marketable-Product" scalability
While the basis of this game is on the fun experienced grouping up and playing with strangers, or with friends, the game is intended to be a marketable product. There will be no espousing on my end of "doing it for the love of it" (though, by all means, if you love it, or working on it, good - but don't forget that it's intended to be sustainable).

There are several aspects to this project's scalability, not to be fully addressed within the local scope of this functional GDD, though acknowledged:
1. The TURTLE multi-cade: a proprietary multicade system to either be purchased for home use, or for commercial use;
2. Web3/DLT/Blockchain integration, in the format of "NFT Mining." In NFT-Mining, given a set of parameters for an item, character, or otherwise in-game object, a custom, or otherwise accommodating, blockchain will be used to distribute NFT(s) as block-rewards in a modifiable proof-of-work or proof-of-stake system. (currently observing Cosmos/ATOM for this purpose.)
3. Easability-of-use for aspiring designers, modders, and programmers - the DevTool Suite is available for purchase, or rental, and takes fractional royalties on commercial product sales or traffic.

### Inspirations
Dungeon Runner is the working title name, and takes inspiration from several games in various aspects:

1. _The Elder Scrolls III: Morrowind_ // dungeons & world-map are unique (hand-crafted), and level-scaling is linear (does not scale with player level).
2. _Warframe_ // uses the "freemium" GaaS model using the F2P model, namely for in-game, playable items. As it is not PvP, pay-to-win only constitutes expediting player progression. Warframe also allows users to design in-game content (generally, cosmetic-only), and vetted content is sold with shares of profits going to the designer.
3. _League of Legends (2021)_ // also uses the freemium-GaaS model, mostly for cosmetics, as it is a PvP experience. Their IP also lends to profitable, external sales of bespoke products.
4. _Overwatch (pre-2018)_ // Overwatch uses a premium-GaaS model, where you buy a copy of the game, and updates are given for free. Players can buy lootboxes for cosmetics. This is an example of what _not_ to do. The inspirations to take are similar to League: it's a Hero Shooter, and while there are FPS elements, they are not stringent regarding recoil patterns or other subtle nuances in regular FPS gameplay.
5. _Divinity: Original Sin 2_ // D:OS2 has a simple, yet amply robust, element system for their game. For example, combining a Lightning spell on a terrain that's affected by Water will cause many types of objects and characters to be affected by a "Shocked" status effect. Similarly, Dungeon-Runner heeds from this style of game (including Dungeons & Dragons) by the application of status effects and its tracking for strategic gameplay.
6. _Apex Legends & Titanfall_ // Both games are first-person, high-intensity/action shooters, allowing for a low skill floor and high skill ceiling. Like Warframe, it brings in new players, but allows dedicated players to master its nuances ("tech" included). The Guard system, which will later be expounded on, is based on a stamina system combined with the Vortex Shield available in Titanfall. Apex Legends has a great mobility system that is intuitive, which extends to Titanfall.

# Section 1: DevTools

## DevTools
Inspirations are acknowledged, but the DevTools allows for the scalability of this project. 

DevTools will act as a GUI-version of boilerplate code for easy access to non-programmers. Generally, this means designers with varying ranges of programming capabilities.

More importantly, this allows for easy iteration of game design and abstraction for numerical design. Features can be implemented to allow for more low-level editing, which is the goal of creating robust DevTools before designing game prototypes.

As a brief example, the Unit & Object Designer can allow for the creation of an IU, but ability to edit its numbers must be manually accessed. Additionally, code modifications to the methods inherent to IUs must be further accessed manually. There will be a level of abstraction that is privy to the developers in ownership of the tools.

## List of DevTools

Currently, the following DevTools are, in order of importance: 
1. Unit & Object Designer
2. Combat Designer
3. Dungeon & Level Designer
4. Objective Designer
5. Narrative Designer

There are later plans to include cutscene tools. However, it is currently undecided if it will be implemented in the Narrative Designer tool or be separate.
  
### 1. Unit Maker
The Unit Maker is an object-design system. In essence, it is a development abstraction of game objects, actors, and assets, for the engine to parse. Additionally, the Unit Maker will have methods that allow for gameplay testing.

At its base, the Unit Maker classifies Game Objects into two distinct Unit Categories under the "umbrella" of Interactable Units (IUs):
- Sentient, Interactable Units (SIUs);
- Non-interactable Units (NIUs).

The SIU category includes anything that can interact with another unit, therefore implying that it is, by nature, an Interactable Unit. The Sentience property specifies if the interaction between itself and another IU is _one-way_ or _two-way_; if it is one-way, the *receiving IU* is considered a "non-sentient, interactable unit" or "nSIU."

To provide an example of the differences in the SIU category:
- SIUs can include playable and non-playable characters that are able to be controlled. This property can be assigned to a Game Object such as: a player-character, a monster (controlled by AI or player), or something that would traditionally be non-sentient (a rock or treasure chest).
- An nSIU would traditionally be: a rock or treasure chest, bullets, weapons, or other weapon-like objects, or a destructible building.

The NIU category includes anything that is _unable_ to receive interaction from other IUs, including objects in the NIU category. Using the previous descriptions, this constitutes a _zero-way_ interaction. To provide examples:
- Scenery, such as a tree, or building, that the designer intends to have non-interactable qualities (such as destructibility);
- Weather elements, such as sun or clouds, that provide ambience only.

Lastly, for both categories, basic methods and method- or component-addition must be allowed. For example:
- This DevTool must allow for instantiation of IU objects and generate save-states relevant to the character and/or game state.
- As items fall under the nSIU category, generally, this DevTool must allow for the creation of these objects and attaching them to another IU as a component (including NIUs - this is what I would refer to as "an intended glitch/bug," since in the context of games, it allows various possibilities in different contexts, including game-breakingness that can provide boundary-pushing).

### 2. Combat Designer
The Combat Designer provides a basis for the above DevTool to have context. In order for any IU to interact with one another, it must have the ability to do so, programatically speaking.

There are four system elements to the Combat Designer DevTool:
1. Resource System
2. Handedness System
3. Element System
4. Interactivity System (dependent on the former three systems)

#### Resource System
The Resource System element allows the DevTool user to create and assign an arbitrary resource _R_ to an IU. The Resource _R_ is later referenced in the Interactivity System element in order to operate mathematically on it.

The Resource _R_ can be custom-named and then assigned a hex-code color. For example, the DevTool user can create a Resource "Health" and assign it a hexcode color of #ff0000 (red). Additionally, R can be specified with a quantity property.

#### Handedness System
The Combat Designer follows what will hereinafter be referred to as a "handedness" system. Whether Dungeon Runner operates better as a FPS or TPS, or other genre, the player will be using items (which, again, fall under the nSIU category, generally), or some variation of what we will refer to as "Spells."

In the Handedness system, usable spells and items are characterized by "the amount of hands this item or spell requires to use in a given context."

When clarifying how many "hands" an item takes to use, we can refer to a piano, for instance, or in games, a vehicle or weapon.
- In the example of a piano, many pieces only take one or two hands to play. However, there are some pieces that require two people, or four hands, to play. Therefore, in the Handedness system, the piano can be specified to be "up to" 4 Hands, or specifically "4 Hands" only, or another custom specifier. The Handedness of the piano can be specified as: ==1, ==2, <4, or <=4.
- In the example of Halo, a Warthog has a driver, a passenger, and a gunner seat. However, only the driver seat must be occupied to use it at a baseline level. Therefore, the Handedness of the Warthog is: ==1, <=3.

A unique example that this architecture can implement is a spell taking multiple users to cast. For example, let's assume we are creating a Dungeon Level that has Cultists as characters in it. In this Dungeon Level, the Cultists perform a blood ritual that requires 5 of them to be channeling it in order to summon a demon. In this case:
- The Spell, operated by the Cultist initiating it, has a Handedness of: ==2, <=10 (to continue), ==10 (to fully cast).
- On the cast, it can create a SIU named "Demon" with its own components and properties.

#### Element System
The Element System acts, currently, as a catch-all for primary combat or interactivity components to be used in the Interactivity Designer.

In order for two IUs to interact with one another beyond strictly forcing an operand on a Resource Quantity assigned to it, it must have some form of _element_ to interact with mutually.

For example, IU-A and IU-B can interact with a created _fire_ element by decrementing a Resource _Mana_ from IU-A and decrementing a Resource _Health_ from IU-B. This allows for dynamic systems design. Similarly, IUs can have an element _damage_ that has a flat value, and can be manipulated via the Interactivity System.

In addition, Elements in the Element System can be attached to IUs (Game Objects) or as a standalone abstraction to interact with.

#### Interactivity System
The Interactivity System Element allows for the DevTool user to allow interaction between IUs using the aforementioned Systems element, and thus is pillar to the Combat System.

In essence, the Interactivity System element allows the Designer using this DevTool to pick and choose IUs, Resources, and other components, and then perform operands on them given a set of player inputs.

For example, the Designer can choose IU-A and IU-B, the _Health_ elements of each, and then a _fire_ element assigned to IU-C. When the player input interacts with IU-C, the _Health_ elements of IU-A and IU-B have their operands performed on them. It is not necessary to always say the _fire_ elements "deals damage," when a "fire-like" creature could heal from it.

However, this system allows for multiple interpretations of this implementation. The Designer can opt for an operand that applies _damage_ related to _fire_ across the board, and then a negative multiplying operand if it is to heal.

### 3. Dungeon & Level Designer
The Dungeon & Level Designer is, fundamentally, a layered map system. It will allow a designer to either design a level linearly (manual placement), dynamically (automatic placement), or a hybrid of linear-dynamic generation.

The layered map system follows this schema:
1. Layer 1: Grid-based "wireframe" - this allows for layers above it to be affected by this layer
2. Layer 2: Visual/object generation - based on Layer 1, this layer will generate IUs, terrain, and other notable features. 

For example, if a map were to be generated dynamically, Layer 1 defines the size of the map in an A x B matrix (e.g., 8 x 8, the equivalent size of a chess board).
Layer 2 allows for rocks (a form of NSIU) to spawn on select - or random - squares, and then before the map is rendered and displayed to the client (player), rocks that are set on adjacent Layer-1 tiles will generate a "larger rock" that occupies those spaces in a 3D space.
This allows for a linear-dynamic hybrid generation.

### 4. Objective Designer
This section is later to be updated with information.

### 5. Narrative Designer
This section is later to be updated with information.

# Genre-less "boilerplate"
The reason to design the DevTools first is to provide a wide range of options for the applications of them. Not only does this allow expedited reiteration (if the proof-of-concept prototype fails), but the proof-of-concept prototype has the potential to adapt to a genre that wasn't intended.

Much like a sandbox, the DevTools should allow for core design loops that adjust to various genres: RPG, FPS, Third-Person Action-Adventure, you name it. The DevTool will not catch all genres, but should make attempts to be broad enough for developers to work with.

~~~

# Section 3: Game Design Ideas
This section will later be split to allow for free-flowing idea generation.

### Introducing unique elements on gameplay loops
The concept of allowing the developers and/or players to create their own characters to a detailed degree allows for unique elements to be added to the gameplay loop.

For example, a concept I've been playing around with is character permadeath, emulating roguelite progression. A unique element that can be applied to an RPG concept such as this is allowing for your created-character's permadeath in exchange for a chance at a more exotic item.

Many RPGs, especially group RPGs, want to encourage this sort of hoarding of items (in my experience, at least). So, I would like to explore this concept of risking your character's life for exotic gear, but this gear is not revealed (or generated) until the player opts into this risk.
