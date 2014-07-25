function variablesType(name, age, isMale, foods){
	console.log("My name is "+name+" // type is "+typeof(name));
	console.log("My age is "+age+" // type is "+typeof(age));
	console.log("I am male "+isMale+" // type is "+typeof(isMale));
	console.log("My favourite foods are "+foods.join()+" // type is "+typeof(foods));
}

variablesType('Pesho', 22, true, ['fries', 'banana', 'cake']);