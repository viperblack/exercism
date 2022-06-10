/// <reference path="./global.d.ts" />

// @ts-check

/**
 * Implement the functions needed to solve the exercise here.
 * Do not forget to export them so they are available for the
 * tests. Here an example of the syntax as reminder:
 *
 * export function yourFunction(...) {
 *   ...
 * }
 */

export function cookingStatus (timer) {
  switch (timer) {
    case 0:
      return 'Lasagna is done.'
    case undefined:
      return 'You forgot to set the timer.'
    default:
      return 'Not done, please wait.'
  }
}

export function preparationTime (layers, timeAverage = 2) {
  return layers.length * timeAverage
}

export function quantities (layers) {
  let countNoodles = 0
  let countSauces = 0

  for (let i = 0; i <= layers.length; i++) {
    if (layers[i] === 'noodles') {
      countNoodles++
    } else if (layers[i] === 'sauce') { countSauces++ }
  }

  const dict = { noodles: countNoodles * 50, sauce: countSauces * 0.2 }

  return dict
}

export function addSecretIngredient (friendsList, myList) {
  myList.push(friendsList[friendsList.length - 1])
}

export function scaleRecipe (recipe, scale = 2) {
  const scaledRecipe = {}

  for (const key in recipe) {
    scaledRecipe[key] = recipe[key] * (scale / 2)
  }

  return scaledRecipe
}
