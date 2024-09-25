let pile = [];
let dossier = prompt("Nom du dossier ?");
while (dossier != null) {
  if (dossier !== "") {     
    document.write(`<p>Nouveau dossier : ${dossier} - actuellement :
                    ${pile.push(dossier)} dossier(s) dans la pile</p>`);
  } else {
    if (pile.length == 0) {
      document.write(`<p>Plus de dossier dans la pile ! </p>`);
    } else {
      document.write(`<p>Dossier en cours : ${pile.pop(dossier)} - actuellement :
                      ${pile.length} dossier(s) dans la pile</p>`);
    }
  }
  dossier = prompt("Nom du dossier ?");
}
