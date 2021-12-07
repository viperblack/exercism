//
// This is only a SKELETON file for the 'Perfect Numbers' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export const classify = (number) => {

  let divisors = [];
  let sum = 0;

  for (let i = 0; i < number; i++)
  {
    if (number % i === 0){
      divisors.push(i);
      sum += i;
    }

  }
  
  if (number <= 0){
    throw "Classification is only possible for natural numbers.";

  } else if (sum == number){
    return "perfect";

  } else if (sum > number){
    return "abundant";

  } else if (sum <= number){
    return ("deficient");
  }

};