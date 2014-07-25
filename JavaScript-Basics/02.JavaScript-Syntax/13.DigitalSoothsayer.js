function soothsayer(numbers, langs, cities, cars){
	return [numbers[Math.floor((Math.random() * 5))], langs[Math.floor((Math.random() * 5))], cities[Math.floor((Math.random() * 5))], cars[Math.floor((Math.random() * 5))]];
}

var result = soothsayer([3, 5, 2, 7, 9], ['Java', 'Python', 'C#', 'JavaScript', 'Ruby'], ['Silicon Valley', 'London', 'Las Vegas', 'Paris', 'Sofia'], ['BMW', 'Audi', 'Lada', 'Skoda', 'Opel']);
console.log("You will work " + result[0] +" years on " + result[1] + ". You will live in " + result[2] + " and drive " +result[3]);
