function lastDigit(num){
	var digit = Math.abs(Math.floor(num%10));
	var name = "not a digit";
	switch(digit){
		case 0: digit = "zero"; break;
		case 1: digit = "one"; break;
		case 2: digit = "two"; break;
		case 3: digit = "three"; break;
		case 4: digit = "four"; break;
		case 5: digit = "five"; break;
		case 6: digit = "six"; break;
		case 7: digit = "seven"; break;
		case 8: digit = "eight"; break;
		case 9: digit = "nine"; break;
	}

	return digit;
}

console.log(lastDigit(6));
console.log(lastDigit(-55));
console.log(lastDigit(133));
console.log(lastDigit(14567));
