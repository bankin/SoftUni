function substringCount(arr){
	var needle = arr[0];
	var haystack = arr[1];
	haystack = haystack.toLowerCase(); 

	var mask = '/'+needle+'/g';
	var count = haystack.match(new RegExp(needle, "g")).length; 

	return count;
}

console.log(substringCount(['in', 'We are living in a yellow submarine. We don\'t have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.']));
console.log(substringCount(['your', 'No one heard a single word you said. They should have seen it in your eyes. What was going around your head.']));
console.log(substringCount(['but', 'But you were living in another world tryin\' to get your message through.']));
