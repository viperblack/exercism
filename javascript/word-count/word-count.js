//
// This is only a SKELETON file for the 'Word Count' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

const getWords = (phrase) => {
  return phrase.toLowerCase().match(/\w+('\w+)?/g);
};

export const countWords = (phrase) => {
  const dict = {};

  for (const word of getWords(phrase)) {
    if (Object.prototype.hasOwnProperty.call(dict, word)) {
      dict[word] += 1;
    } else {
      dict[word] = 1;
    }
  }

  return dict;
};