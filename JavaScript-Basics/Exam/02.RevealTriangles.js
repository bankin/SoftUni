function solve(args){
	var field = [];
	field.push(args[0]);
	for(var i = 0; i < args.length-1; i++){
		var first = args[i];
		var second = args[i+1];
		field.push(second);
		for(var k = 1; k < first.length; k++){
			var ch = first[k];
			if(second[k-1] == ch && second[k] == ch && second[k+1] == ch){
				//console.log("TRIANGLE");
				var str = field[i];
				str = str.slice(0, k) + '*' +str.slice(k+1, str.length);
				//console.log(str);
				field[i] = str;
				str = field[i+1];

				str = str.slice(0, k - 1) + '*' +str.slice(k, str.length);
				str = str.slice(0, k ) + '*' +str.slice(k+1, str.length);
				str = str.slice(0, k + 1) + '*' +str.slice(k+2, str.length);
				field[i+1] = str;
			}
		}
	}
	var result = "";
	for(var i = 0; i < field.length; i++){
		result += field[i];
		if(i != field.length - 1){
			result += "\n";
		}
	}
	return result;
}

solve(['dffdsgyefg', 'ffffeyeee', 'jbfffays','dagfffdsss','dfdfa','dadaaadddf','sdaaaaa','daaaaaaasf']);