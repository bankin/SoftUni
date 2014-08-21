function nthDigit(arr){
	if(arr[0] == 1){
		return arr[1];
	}
	var num = "" + Math.abs(arr[1]);
	num = num.slice(0, num.indexOf('.')) + num.slice(num.indexOf('.')+1, num.length);



	return num[num.length-arr[0]] == undefined ? "this number does not have " + arr[0] + " digits" : num[num.length-arr[0]];


}

console.log(nthDigit([1, 6]));
console.log(nthDigit([2, -55]));
console.log(nthDigit([6, 923456]));
console.log(nthDigit([3, 1451.78]));
console.log(nthDigit([6, 888.88]));