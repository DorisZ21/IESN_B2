function demanderNombre(min,max){
    let nombre = prompt("Entrez un nombre : ");
    while(!isFinite(nombre) || nombre.trim() === "" || /^\s/.test(nombre) || Number(nombre) < min || Number(nombre) > max ){
        console.log(min);
        console.log(max);
        nombre = prompt("Entrez un nombre : ");
    };
    console.log("Le nombre est : " + nombre);
}


var reponse = prompt("Que vaut 36 * 0 ?");
if (reponse == 0 && reponse !== "")
  alert("Bravo !");
else
  alert("T’es nul !");
