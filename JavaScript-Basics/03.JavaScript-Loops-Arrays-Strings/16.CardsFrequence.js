function cardFrenquence(cards){
	cards = cards.split(" ");
	var freques = {'2':0,
					'3':0,
					'4':0,
					'5':0,
					'6':0,
					'7':0,
					'8':0,
					'9':0,
					'10':0,
					'J':0,
					'Q':0,
					'K':0,
					'A':0 };
	var all = cards.length;

	for(var i = 0; i < cards.length; i++){
		var card = cards[i].slice(0, - 1);
		freques[card]++;
	}
	//console.log(freques);

	for(key in freques){
		if(freques[key] != 0){
			console.log(key + " -> " + ((freques[key]/all)*100) + "%")
		}
	}
}

cardFrenquence('8♥ 2♣ 4♦ 10♦ J♥ A♠ K♦ 10♥ K♠ K♦');
console.log("---");
cardFrenquence('J♥ 2♣ 2♦ 2♥ 2♦ 2♠ 2♦ J♥ 2♠');
console.log("---");
cardFrenquence('10♣ 10♥');