function printNumbers(value){
	if(value <= 0 ){ console.log("No"); return; }

	for(var i = 0; i < value; i++){
		if(i % 4 != 0 && i % 5 != 0){
			console.log(i);
		}
	}
}

printNumbers(20);
printNumbers(-5);
printNumbers(13);