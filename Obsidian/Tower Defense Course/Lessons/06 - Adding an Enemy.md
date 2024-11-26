In this section, you will create a simple enemy that can move around the map.

## Creating an Enemy Prefab

Start by creating an Empty **Game Object** in your **Hierarchy** that will act as the base for your **Enemy**.

- [ ] Right click in the **Hierarchy**
- [ ] Select **Create Empty**
- [ ] Rename the **Game Object**. (I recommend calling it Enemy)

![[create-empty.png]]

**Note:** Double check that the new **Game Object** is not a child of any other object.

![[ensure-top-level-enemy.png]]

In the **Kenney Tower Defense Kit** assets, there are several UFO model that you can use for your first enemy:

* enemy-ufo-a
* enemy-ufo-b
* enemy-ufo-c
* enemy-ufo-d

You can search your assets for a specific file by using the search bar at the top of the **Project** explorer tab.

- [ ] In your **Project** explorer, Search for `enemy-ufo-`
- [ ] Drag one of the UFO models onto your **Enemy** game object to make it a child object.
	- **Note**: For this part of the project, it is recommended to use a UFO without a weapon attached to the top.


![[add-enemy-ufo-model.webp]]

### Practice: Unpack Model Prefab

Can you remember how to unpack a prefab? Notice, the `enemy-ufo-` model you have selected is a **Prefab** in the **Hierarchy**. Can you unpack it?

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

![[prefab-folder-structure.webp]]

## Moving the Enemy