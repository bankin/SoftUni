function digitAsWord(digit){
	var word = "not a digit";
	switch(digit){
		case 0: word = "zero"; break;
		case 1: word = "one"; break;
		case 2: word = "two"; break;
		case 3: word = "three"; break;
		case 4: word = "four"; break;
		case 5: word = "five"; break;
		case 6: word = "six"; break;
		case 7: word = "seven"; break;
		case 8: word = "eight"; break;
		case 9: word = "nine"; break;
	}
	return word;
}

console.log(digitAsWord(8));
console.log(digitAsWord(3));
console.log(digitAsWord(5));