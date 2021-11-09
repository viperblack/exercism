//
// This is only a SKELETON file for the 'Gigasecond' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export const gigasecond = (input) => {

  const gigaseconds = 1000000000;
  const timestamp = input.getTime() + gigaseconds * 1000; //In JavaScript, a time stamp is the number of milliseconds that have passed since January 1, 1970
  var newDate = new Date(timestamp);

  return newDate;

  //throw new Error('Remove this statement and implement this function');
};
