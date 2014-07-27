function solve(args){
	var json = {};
	for(var i = 0; i < args.length; i++){
		var row = args[i];
		var info = row.split("|");

		for(var k = 0; k < 4; k++){
			console.log("INFO");
			console.log(info[k]);
			info[k] = myTrim(info[k]);
		}
		if(!(info[1] in json)){			
			json[info[1]] = {};
			json[info[1]][info[3]] = [];
		}
		else{			
			if(json[info[1]][info[3]] == undefined){
				json[info[1]][info[3]] = [];
			}			
		}
		if(json[info[1]][info[3]].indexOf(info[0]) == -1){
			json[info[1]][info[3]].push(info[0]);
		}
	}

	json = sortObject(json);

	for(var key in json){
		json[key] = sortObject(json[key]);
		for(var p in json[key]){
			//console.log("p -> " + p);
			//console.log(json[key][p]);
			json[key][p].sort();
		}
	}

	return JSON.stringify(json);

	function sortObject(o) {
	    var sorted = {},
	    key, a = [];

	    for (key in o) {
	    	if (o.hasOwnProperty(key)) {
	    		a.push(key);
	    	}
	    }

	    a.sort();

	    for (key = 0; key < a.length; key++) {
	    	sorted[a[key]] = o[a[key]];
	    }
	    return sorted;
	} // Cities sorted

	function myTrim(x) {
	    return x.replace(/^\s+|\s+$/gm,'');
	}

}

solve(['ZZ Top | London | 2-Aug-2014 | Wembley Stadium',
'Iron Maiden | London | 28-Jul-2014 | Wembley Stadium',
'Metallica | Sofia | 11-Aug-2014 | Lokomotiv Stadium',
'Helloween | Sofia | 1-Nov-2014 | Vassil Levski Stadium',
'Iron Maiden | Sofia | 20-June-2015 | Vassil Levski Stadium',
'Helloween | Sofia | 30-July-2015 | Vassil Levski Stadium',
'Iron Maiden | Sofia | 26-Sep-2014 | Lokomotiv Stadium',
'Helloween | London | 28-Jul-2014 | Wembley Stadium',
'Twisted Sister | London | 30-Sep-2014 | Wembley Stadium',
'Metallica | London | 03-Oct-2014 | Olympic Stadium',
'Iron Maiden | Sofia | 11-Apr-2016 | Lokomotiv Stadium',
'Iron Maiden | Buenos Aires | 03-Mar-2014 | River Plate Stadium']);