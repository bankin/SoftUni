function treeArea(b){
	return b*b/3 + Math.PI*b*b*16/36;
}

function houseArea(a){
	return a*a + a*a/3;
}

function treeOrHouse(a, b){
	console.log(treeArea(b));
	console.log(houseArea(a));
	return treeArea(b) > houseArea(a) ? "tree/"+treeArea(b) : "house/"+houseArea(a);
}

console.log(treeOrHouse(3, 2));
console.log(treeOrHouse(3, 3));
console.log(treeOrHouse(5, 4));