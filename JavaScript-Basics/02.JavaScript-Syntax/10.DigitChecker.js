function checkDigit(value){
	value = value/100;
	return Math.floor(value % 10) == 3;

}

console.log(checkDigit(1235));
console.log(checkDigit(25368));
console.log(checkDigit(123456));