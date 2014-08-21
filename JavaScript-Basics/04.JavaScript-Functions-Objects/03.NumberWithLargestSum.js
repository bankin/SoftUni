function largestSum(){
	var maxSum, first = true;
	for(var i = 0; i < arguments.length; i++){
		var current = findSum(arguments[i]);
	}
}

console.log(largestSum(5, 10, 15, 111));
console.log(largestSum(33, 44, -99, 0, 20));
console.log(largestSum('hello'));
console.log(largestSum(5, 3.3));