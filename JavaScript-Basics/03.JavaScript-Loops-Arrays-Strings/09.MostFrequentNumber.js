function mostFrequent(arr){
	var mostRepeatedChar = '';
	var mostRepeated = 0;

	while(arr.length > 0){		
		var ch = arr[0];
		count = 1;
		for(var i = 0; i < arr.length; i++){
			if(ch == arr[i]){
				count ++;
			}			
		}

		if(count > mostRepeated){
			mostRepeated = count;
			mostRepeatedChar = ch;
		}	

		arr.shift();	
	}

	return mostRepeatedChar + " ( " + (mostRepeated-1) + " times )";
}

console.log(mostFrequent([4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3]));
console.log(mostFrequent([2, 1, 1, 5, 7, 1, 2, 5, 7, 3, 87, 2, 12, 634, 123, 51, 1]));
console.log(mostFrequent([1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13]));
