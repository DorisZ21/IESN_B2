function ajouteNumCode () {
	let codeBlocks = document.getElementsByTagName("code");
	for (let codeBlock of codeBlocks) {
		let code = codeBlock.innerHTML.replace(/</g,"&lt;");
		let lignes = code.split("\n");
		while (lignes[0].trim() == "") {
			lignes.splice(0,1);
		}
		while (lignes[lignes.length - 1].trim() == "") {
			lignes.splice(-1,1);
		}
		let lgMax = 0;
		for (let ligne of lignes) {
			if (ligne.length > lgMax) lgMax = ligne.length;
		}
		let nbLignes = lignes.length;
		let nbCaractères = Math.ceil(Math.log10(nbLignes+1));
		lignes = lignes.map((ligne,i) =>
			"<span class='" + (i%2 == 1 ? "im" : "") + "pair'>"
			+ "<span class='num'>" + écritNum(i+1,nbCaractères) + "</span>"
			+ écritLigne(ligne, lgMax) + "</span>");
		codeBlock.innerHTML = lignes.join("");
	}
}

function écritLigne (ligne, lg) {
	while (ligne.length < lg) {
		ligne += " ";
	}
	return  ligne;
}

function écritNum (i, nbCar) {
	let num = String(i);
	while (num.length < nbCar) {
		num = " " + num;
	}
	return "<em>" + num + "</em>";
}