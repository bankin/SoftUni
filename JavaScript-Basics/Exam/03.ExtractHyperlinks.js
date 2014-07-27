function solve(args){
	var input = "";
	var links = [];
	for(var i = 0; i < args.length; i++){
		input += args[i];
	}
	input = removeWhiteSpace(input);
	var index = input.indexOf("<a");
	while(index != -1){
		var i = index;
		var attr = "";
		while(input[i] != ">"){
			attr += input[i];
			i++;
		}
		//console.log("ATTR = " + attr);
		var hrefIndex = attr.indexOf("href=");
		if(hrefIndex != -1){
			var href = "";
			var limiter = attr[hrefIndex + 5];
			var p = hrefIndex + 6;
			while(attr[p] != limiter){
				href += attr[p];
				p++;
			}
			//console.log(href);
			links.push(href);
			//console.log("LIMITER = " + attr[hrefIndex + 5]);
		}

		index = input.indexOf("<a", index +1);
	}
	//console.log(input);
	//console.log(links);
	var output = "";
	for(var i = 0; i < links.length; i++){
		output += links[i];
		if(i != links.length - 1){
			output += "\n";
		}
	}

	return output;

	function removeWhiteSpace(str){
		return str.replace(/\s+/g, '');
	}
}



solve(['<ul><li><a   href="/"  id="home">Home</a></li><li><a',
' class="selected" href="/courses">Courses</a>',
'</li><li><a href = ',
'\'/forum\' >Forum</a></li><li><a class="href"',
'onclick="go()" href= "#">Forum</a></li>']);