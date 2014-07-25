function compare(str, comp){
	for(var i = 0; i < str.length; i++){
		if(str[i] != comp[i]){
			return false;
		}
	}

	return true;
}

console.log(compare(['1', 'f', '1', 's', 'g', 'j', 'f', 'u', 's', 'q'],['1', 'f', '1', 's', 'g', 'j', 'f', 'u', 's', 'q']) ? "Equal" : "Not Equal");
console.log(compare(['3', '5', 'g', 'd'] ,['5', '3', 'g', 'd']) ? "Equal" : "Not Equal");
console.log(compare(['q', 'g', 'q', 'h', 'a', 'k', 'u', '8', '}', 'q', '.', 'h', '|', ';'],['6', 'f', 'w', 'q', ':', '”', 'd', '}', ']', 's', 'r']) ? "Equal" : "Not Equal");