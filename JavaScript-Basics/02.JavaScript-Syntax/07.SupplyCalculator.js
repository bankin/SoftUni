function supplyCalc(age, maxAge, foodPerDay){
	return ((maxAge - age)*365*foodPerDay) + "kg of food would be enough untill I'm " + maxAge + " years old";
}

console.log(supplyCalc(38, 118, 0.5));
console.log(supplyCalc(20, 87, 2));
console.log(supplyCalc(16, 102, 1.1));