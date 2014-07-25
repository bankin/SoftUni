function bitChecker(value){
	var bit = Number(value).toString(2);
	return bit[bit.length-1-3] == '1';
}

console.log(bitChecker(333));
console.log(bitChecker(425));
console.log(bitChecker(2567564754));