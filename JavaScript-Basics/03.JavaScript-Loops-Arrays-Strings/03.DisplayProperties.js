function displayProperties(obj){
	console.log(Object.getOwnPropertyNames(obj));
}
//This is not a HTML page so document is undefined. To show that my task is correct I put the Math object.
displayProperties(Math);