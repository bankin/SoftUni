function minAndMax(arr){
	var min = arr[0];
	var max = arr[1];

	for(var i = 1; i < arr.length; i++){
		if(arr[i] < min){
			min = arr[i];
		}

		if(arr[i] > max){
			max = arr[i];
		}
	}

	console.log("Min -> "+min);
	console.log("Max -> "+max);
}

minAndMax([1, 2, 1, 15, 20, 5, 7, 31]);
minAndMax([2, 2, 2, 2, 2]);
minAndMax([500, 1, -23, 0, -300, 28, 35, 12]);