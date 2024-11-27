In this section, you will create a simple enemy that can move around the map.
## Import Assets
Kenney provides hundreds of free assets to the public domain that can be used to help in your prototypes (and even commercial projects). In this section, you will use the Graveyard Kit to create an enemy using one of the 5 provided models and animations.

Before starting, you should import the **FBX Models** from this asset pack: [Graveyard Kit · Kenney](https://kenney.nl/assets/graveyard-kit)

If you need help importing the models, you can refer to the Importing Asset section of [[02 - Creating a Tile Grid#Importing Assets]]

Here is a quick check list to help you:
- [ ] Download the Asset Pack
- [ ] Extract the ZIP archive
- [ ] Find the **FBX Model** folder
- [ ] Import the **FBX Models** into your **Assets**
- [ ] Rename the folder (I recommend **Kenny Graveyard Kit**)
## Creating an Enemy Prefab

Start by creating an Empty **Game Object** in your **Hierarchy** that will act as the base for your **Enemy**.

- [ ] Right click in the **Hierarchy**
- [ ] Select **Create Empty**
- [ ] Rename the **Game Object**. (I recommend calling it Enemy)

![[create-empty.png]]

**Note:** Double check that the new **Game Object** is not a child of any other object.

![[ensure-top-level-enemy.png]]

In the **Kenney Graveyard Kit** you will find 5 character models that can be used as a model for your Enemy:

* character-digger
* character-ghost
* character-skeleton
* character-vampire
* character-zombie

In the **Project** tab, if you search for `character-`, you should see the 5 models:

You can search your assets for a specific file by using the search bar at the top of the **Project** explorer tab.

![[kenney-character-models.png]]

- [ ] Drag one of the character models onto your **Enemy** game object to make it a child object.
	- **Note**: For this part of the project, I will be using the `character-zombie` model. However, feel free to use any of the models.

![[add-model-to-enemy.webp]]
### Practice: Unpack Model Prefab

Can you remember how to unpack a prefab? Notice, the `character-xyz` model you have selected is a **Prefab** in the **Hierarchy**. Can you unpack it?

- [ ] Unpack the `enemy-ufo-` model in your **Hierarchy**
- [ ] Rename the game object to be `model`

When you have finished, your **Hierarchy** should look similar to the image below:

![[practice-renaming-unpacking.png]]

### Practice: Create the Enemy Prefab
Now that you have an Enemy game object, turn it into a **Prefab**. At this point, you now have multiple types of **Prefabs** (tiles and enemies). Create a folder for each within your **Prefabs** folder to help organize them.

- [ ] Create a folder for your Enemy prefabs
- [ ] Create a folder for your Tile prefabs
- [ ] Move all of your prefabs to the appropriate folder

When you have finished, your **Prefabs** folder should look similar to the folders below:

![[create-prefabs-folders.webp]]
## Moving the Enemy
