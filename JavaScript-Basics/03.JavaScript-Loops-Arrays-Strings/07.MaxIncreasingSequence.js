function maxIncreasingSequence(arr){
	var maxSequence = [];
	var currentSequance = [];
	currentSequance.push(arr[0]);
	for(var i = 1; i < arr.length;i++){		
		if(arr[i] > arr[i-1]){
			currentSequance.push(arr[i]);
		}
		else{
			if(currentSequance.length > maxSequence.length){
				maxSequence = currentSequance
			}
			currentSequance = [];
			currentSequance.push(arr[i]);
		}
	}
	if(currentSequance.length > maxSequence.length){
		maxSequence = currentSequance;
	}

	if(maxSequence.length == 1){
		return "No";
	}
	return maxSequence;
}


console.log(maxIncreasingSequence([3, 2, 3, 4, 2, 2, 4]	));
console.log(maxIncreasingSequence([3, 5, 4, 6, 1, 2, 3, 6, 10, 32]));
console.log(maxIncreasingSequence([3, 2, 1]));