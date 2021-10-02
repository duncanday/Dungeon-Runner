# Foreword
Version: 2.2.0.0

Date: 09/25/2021

# Disclosure
NOTE: By joining this GitHub, reading this document, and participating in its source code, you agree to standard NDAs (non-disclosure agreements) and intellectual property standards and laws.

# Dungeon-Runner
Dungeon Runner is a free-to-play (F2P), 2-10 player game, focusing on the PvE experience. Players will delve into dungeons (levels) and earn in-game rewards, and out-of-game rewards using Web3 Technology (DLT/Blockchains).

The game's perspective is currently undecided. Currently, the following are options:
1. 3D, first-person shooter (e.g. Titanfall)
2. 3D, third-person shooter (e.g. Warframe)
3. 3D, isometric RPG (e.g. RuneScape, League of Legends, Divinity: Original Sin 2)
4. 2D, isometric RPG (e.g. Into the Breach)

There are no current plans to introduce matchmaking or PvP experiences. If the framework proves viable, then the possibilities will be considered.

It will be finalized in a 3D engine. Currently, the engine of choice is Unity 5, as it currently is able to integrate with enjin.io on the Ethereum Network, and is more widely applicable in several regards.

**There are no current plans for monetization.** 

There are many aspects of games that can be monetized, but fun and game feel are prioritized first. Monetization as it relates to sustainability of the game will be implemented as needed.

As far as sustainability goes, there are plans to implement a DeFi/open-source aspect to the game via governance. That is, stakeholders in the game can propose balance changes which the development team can implement. (for an example, see how Jagex utilizes poll booths in OSRS.)

*However,* there is a no-/zero-tolerance policy on the following:
- greater than 1 assigned vote token, if votes are tokenized via a governance protocol;
- Misbehavior (whether matchmaking is implemented or not) - this may include writing chat data on the blockchain in extreme measures (if a player says to another, "go kys," that player is banned permanently with or without appeal, and that chat data will be written within the data aspect(s) of blockchain account access revoking.)
- Alternate account creation; if another account is created, it must be linked to the original address used to participate in the game. The game's design should naturally lend to not smurfing (e.g., transferring unique items between characters is linked to a single account.)

TBA: forms of KYC (which don't involve SSN/TIN/DL #s) to be enforced with regards to single-accounts only.

## Overarching Story
The release title will be "The Carbon Hearts."

In the world of "The Carbon Hearts," an endless war is in place. However, those engaged in battle are obligated to do so, after coming into contact with the world's powerful, yet corruptible material: AETHER.

Those who came in contact with AETHER became, to their loved ones..._something else._

For better, their powers grew, and they were able to use it for good or evil.

For worse, those touched by AETHER were envenomed by its power, and so, their powers would subside without more of it. Over time, their hearts would become a steely carbon, and over time, they became more machine than man.

For better or for worse.

## NFT integration
A novel concept of blockchain technology is the ability to tokenize a representative of a digital or real-world object as a "token." While many cryptocurrencies are _fungible_, meaning that a token (or tokenized represenation of "something") can be reminted and reissued, an NFT, or non-fungible token, cannot be reminted or reissued in its "truest" form by attaching a digital signature to the recipient/purchaser, and write and therefore provide an immutable record of it on the blockchain.

NFTs have been explored in use cases regarding digital media, including games. In this project, NFTs will be integrated via:
1. Unique characters;
2. Unique items, transferrable between characters;
3. (Possibly) unique spells, transferrable between characters, and applicable to items.

A character is created and formally linked to a user's network address. Ideally, the game is to be network-/blockchain-agnostic; that is, it is applicable to any blockchains capable of hosting it.

## Core Gameplay Loop (macro)
The character, upon creation, is naturally susceptible to permadeath, and enemies grow stronger as more players that are recorded as played or playing the game have characters who die.

The character is, lore-wise, a "Bio-Mech." The Carbon Heart they possess is the heart of a machine, and so their goal is to improve efficacy. (this may later be changed.)

A player's character starts off alone in its own "safe zone." The player must opt to go beyond the "safe zone" into the "danger zone" and furthermore, the "dark zone."
1. The Safe Zone is a hub where the player can adjust their character's applicable loadouts (items, spells, etc.)
2. The Danger Zone is the immediate zone outside of the Safe Zone. Here is where enemies first appear. The map will continue to generate procedurally and increase in difficulty linearly.
3. The Dark Zone is the opt-in zone outside of the Danger Zone. Here is where unique enemies and items can be found. The map system follows the same progression as the Danger Zone (each map completed is one "notch," and for each four completed, the player must complete an additional map to return to the previous zone). The difficulty increases exponentially. The player must have a prerequisite amount of "Darkfuel" found in the Danger Zone.

In order for a player to change paths, they must change their preferred Navigation Target. For each map completed, a "notch" is logged. For every four notches completed, the player must complete one notch to return to the safe zone. (e.g. thereotically, if a player completed 100 maps and wanted to return to the safe zone, they must complete 25 more maps to return back.)

In the Danger Zone, Darkfuel is harvested from every hostile enemy. When the player collects enough, they can opt to travel to the Dark Zone after completing the current map. This action can be done regardless of party approval. (all party member actions are independent of one another.)

The player can stay in the Dark Zone as long as he or she has Darkfuel. When their amount of Darkfuel expires, they must return to the Danger Zone, and take consistent damage until doing so. If they die, all acquired gear is lost.

A player's goal is to collect loot and Carbon. Carbon is used to augment the character's Bio-Mech by adding spells and spell loadouts, weapon and weapon loadouts, and Tech, which are gameplay-altering items that are not inherently weaponized. Loot follows a randomized table based on player level differentials from enemies (i.e. if the enemy level is higher than the player, the loot power is increased, following a loot table inherent to the enemy.)

## Content format
The game is segmented into 4 seasons per year. Each season has a period towards its end known as Season's End, and is thematic to the corresponding Season (Autumn, Winter, Spring, Summer).

Season's End is a period intended to challenge the player's character and player skills significantly. In Season's End, the Danger Zone and the Dark Zone do not apply; instead, there is a thematic Seasonal Zone that applies. 

The thematic Seasonal Zone suspends character permadeath until the release of the next season, where new content is added to the enemy and loot pool.

1. Autumn Seasonal Zone involves overwhelming waves of enemies.
2. Winter Seasonal Zone involves limited loadouts.
3. Spring Seasonal Zone involves overgrown enemies, who are increased in size and power.
4. Summer Seasonal Zone involves required spells in order to survive, which are predetermined at the beginning of Season's End.

Cross-seasonal Zones may apply.

Season's End's duration, and to an extent, content, is determined by the playerbase. (more on this in a later version, and tentative.)

# Section 1: Designer Suite
The Designer Suite is intended to facilitate a developer or designer's ease-of-use with creating content. It must be extendable such that onboarded designers or developers (include player modders) are able to work with the tools easily.

## List of Designer Suite Features (DSFs)
The following Designer Suite Features planned are:
1. Charactermancer (current)
2. Dungeon/Level Designer
3. Item Designer
4. Spell Designer

### Charactermancer
The Charactermancer is a broad DSF that acts as a container for item and spell methods.

The Charactermancer involves a broad range of variables that are to be used when creating items and spells. Here is a brief outline of the Character as an object-entity:
1. has Skills (spells), which may or may not involve resource costs.
2. has 16 Skill Slots, which can be sub-divided into multiple Skill Racks, up to a limit of 5. one Skill Rack can have 16 assignable slots; subdividing Skill Racks requires a Skill-Rack changing skill ("change Skill Rack").
3. has at least one Weapon, which may be melee or ranged.
4. has at least one Guard, which is a unique blocking skill.
