function bracketsMatch(str){
	var brackets = [];
	for(var i = 0; i < str.length; i++){
		if(str[i] == '('){
			brackets.push('(');
		}
		if(str[i] == ')'){
			if(brackets.length == 0){ return false; }
			brackets.pop();
		}
	}
	if(brackets.length > 0){ return false; }
	return true;
}

console.log(bracketsMatch('( ( a + b ) / 5 – d )'));
console.log(bracketsMatch(') ( a + b ) )'));
console.log(bracketsMatch('( b * ( c + d *2 / ( 2 + ( 12 – c / ( a + 3 ) ) ) )'));