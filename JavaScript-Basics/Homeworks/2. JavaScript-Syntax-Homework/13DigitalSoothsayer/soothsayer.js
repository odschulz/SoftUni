function soothsayer(numsArr, langsArr, citiesArr, carsArr) {

	console.log('You will work ' + numsArr[Math.floor(Math.random() * numsArr.length)] +
		' years on ' + langsArr[Math.floor(Math.random() * langsArr.length)] +
		'. You will live in ' + citiesArr[Math.floor(Math.random() * citiesArr.length)] +
		' and drive ' + carsArr[Math.floor(Math.random() * carsArr.length)] + '.');
	// console.log(numsArr[1]);
}
var years = [3, 5, 2, 7, 9],
	languages = ['Java', 'Python', 'C#', 'JavaScript', 'Ruby'],
	cities = ['Silicon Valley', 'London', 'Las Vegas', 'Paris', 'Sofia'],
	cars = ['BMW', 'Audi', 'Lada', 'Skoda', 'Opel'];
soothsayer(years, languages, cities, cars);
