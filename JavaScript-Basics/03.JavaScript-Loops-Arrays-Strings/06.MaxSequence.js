function maxSequence(arr){
	var maxSequenceChar = arr[0];
	var maxLength = 1;
	var currentLength = 1;
	for(var i = 1; i < arr.length;i++){		
		if(arr[i] == arr[i-1]){
			currentLength++;
		}
		else{
			if(currentLength > maxLength){
				maxSequenceChar = arr[i-1];
				maxLength = currentLength + 1;
			}
			currentLength = 0;
		}
	}
	if(currentLength > maxLength){
		maxSequenceChar = arr[i-1];
		maxLength = currentLength + 1;
	}
	
	var toReturn = [];
	for(var i = 0; i < maxLength; i++){
		toReturn.push(maxSequenceChar);
	}
	return toReturn;
}

console.log(maxSequence([2, 1, 1, 2, 3, 3, 2, 2, 2, 1]));
console.log(maxSequence(['happy']));
console.log(maxSequence([2, 'qwe', 'qwe', 3, 3, '3']));