function reverse(str){
	return str.split("").reverse().join("");
}

function palindromes(str){
	var result = [];
	str = str.toLowerCase();
	str = str.split(/[\s,\s.]+/);
	console.log(str);
	for(var i = 0; i < str.length; i++){
		if(str[i] == reverse(str[i]) && str[i].length > 0){
			result.push(str[i]);
		}
	}

	return result;
}

console.log(palindromes('There is a man, his name was Bob.'));