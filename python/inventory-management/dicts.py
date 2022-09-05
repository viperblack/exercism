"""Functions to keep track and alter inventory."""


def create_inventory(items):
    """Create a dict that tracks the amount (count) of each element on the `items` list.

    :param items: list - list of items to create an inventory from.
    :return: dict - the inventory dictionary.
    """
    return {key: items.count(key) for key in items}


def add_items(inventory, items):
    """Add or increment items in inventory using elements from the items `list`.

    :param inventory: dict - dictionary of existing inventory.
    :param items: list - list of items to update the inventory with.
    :return: dict - the inventory updated with the new items.
    """
    for key in create_inventory(items):
        if key in inventory:
            inventory[key] = (create_inventory(items)).get(key) + inventory.get(key)
        else:
            inventory[key] = (create_inventory(items))[key]
    return inventory

def decrement_items(inventory, items):
    """Decrement items in inventory using elements from the `items` list.

    :param inventory: dict - inventory dictionary.
    :param items: list - list of items to decrement from the inventory.
    :return: dict - updated inventory with items decremented.
    """
    for key in inventory:
        if inventory.get(key) <= create_inventory(items).get(key):
            inventory[key] = 0
        else:
            inventory[key] = inventory.get(key) - (create_inventory(items)).get(key)
    return inventory


def remove_item(inventory, item):
    """Remove item from inventory if it matches `item` string.

    :param inventory: dict - inventory dictionary.
    :param item: str - item to remove from the inventory.
    :return: dict - updated inventory with item removed. Current inventory if item does not match.
    """
    if item in inventory:
        inventory.pop(item)
    return inventory


def list_inventory(inventory):
    """Create a list containing all (item_name, item_count) pairs in inventory.

    :param inventory: dict - an inventory dictionary.
    :return: list of tuples - list of key, value pairs from the inventory dictionary.
    """
    for item in list(inventory):
        if inventory[item] <= 0:
            list(inventory).append(remove_item(inventory, item))
    return list(inventory.items())
