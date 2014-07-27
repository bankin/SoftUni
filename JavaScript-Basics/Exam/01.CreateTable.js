function solve(args){
	var start = Number(args[0]);
	var end = Number(args[1]);

	var result = openElement("table");
	result += "\n";
	result += createTableHeader();
	result += "\n";
	for(var i = start; i <=end; i++){
		result += openElement("tr");
		result += createElement("td", i);
		result += createElement("td", i*i);
		result += createElement("td", isFibonacci(i));
		result += closeElement("tr");
		result += "\n";
	}

	result += closeElement("table");

	return result;

	function openElement(el){
		return "<"+el+">";
	}

	function closeElement(el){
		return "</"+el+">";
	}

	function createTableHeader(){
		return "<tr><th>Num</th><th>Square</th><th>Fib</th></tr>";
	}

	function createElement(element, inner){
		return openElement(element) + inner + closeElement(element);
	}

	function isFibonacci(num){
		var a = 0;
		var b = 1;
		var c = 1;

		while(num > c){
			a = b;
			b = c;
			c = b + a;
		}

		if(num < c){
			return "no";
		}
		else{
			return "yes";
		}
	}
}

solve(['2', '6']);