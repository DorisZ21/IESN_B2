// Version utilisant la syntaxe standard

function sortir (txt) {
  console.log(txt);
}

function citeNFois (chaine, nbr) {
  nbr = Number(nbr);
  if (!isFinite(nbr) || nbr < 0) {
    sortir("Le deuxième argument doit être un nombre positif");
    return;
  } 
  for (let i = 1; i <= nbr; i++) {
    sortir(`${i}) ${chaine}`);
  }
}

// Version utilisant la syntaxe orienté objet</h3>

const sortir = new Function ("txt", 'console.log(txt)');

const citeNFois = new Function ("chaine", "nbr", 
  `nbr = Number(nbr);
   if (!isFinite(nbr) || nbr < 0) {
     sortir('Le deuxième argument doit être un nombre positif');
     return;
   }
   for (let i = 1; i <= nbr; i++) {
     sortir(i + ") " + chaine);
   }`
);
