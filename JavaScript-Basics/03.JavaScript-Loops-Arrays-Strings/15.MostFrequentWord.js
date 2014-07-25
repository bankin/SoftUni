function mostFrequent(str){
	var arr = str.toLowerCase().split(/[\s,\s.]+/);
	arr = arr.sort();
	var maxLength = 1;
	var repeat = [];
	var currentLength = 1;	
	var i = 0;
	for(i = 1; i < arr.length; i++){
		if(arr[i] == arr[i-1]){
			currentLength++;
		}
		else{
			if(currentLength > maxLength){
				repeat = [];
				repeat.push(arr[i-1]);
				maxLength = currentLength;
			}
			else if(currentLength == maxLength){
				repeat.push(arr[i-1]);
			}
			currentLength = 1;
		}
	}

	if(currentLength > maxLength){
		repeat = [];
		repeat.push(arr[i-1]);
		maxLength = currentLength;
	}
	else if(currentLength == maxLength){
		repeat.push(arr[i-1]);
	}

	for(var i = 0;i < repeat.length; i++){
		console.log(repeat[i] + " -> "+maxLength);
	}
}

mostFrequent('in the middle of the night');
console.log("---");
mostFrequent('Welcome to SoftUni. Welcome to Java. Welcome everyone.');
console.log("---");
mostFrequent('Hello my friend, hello my darling. Come on, come here. Welcome, welcome darling.');