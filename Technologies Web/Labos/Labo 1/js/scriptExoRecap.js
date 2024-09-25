let mms = [Number.MAX_SAFE_INTEGER, Number.MIN_SAFE_INTEGER, 0];

function construireBaseTableau(){
    document.write("<table><tr> <th>No</th> <th>Nombre</th> <th>Min</th> <th>Max</th> <th>Somme</th> </tr>")
}  

function demanderNombreEtModifierTableau(){
    let nombre = prompt("Entrez un nombre");
    let i = 0;
    while(nombre !== "" && isFinite(nombre)){
        nombre = Number(nombre);
        calculMinMaxSomme(nombre);
        ajouterUneLigne(nombre,i);
        i++;
        nombre = prompt("Entrez un nombre");
    }
}

function calculMinMaxSomme(nombre){
    // calcul du min
    if(mms[0] > nombre){
        mms[0] = nombre;
    }
    // calcul du max
    if(mms[1] < nombre){
        mms[1] = nombre;
    }
    // calcul de la somme
    mms[2] += nombre;
}

function ajouterUneLigne(nombre, index){
    let nombreClass = nombre > 0 ? "positif" : "negatif";
    let minClass = mms[0] > 0 ? "positif" : "negatif";
    let maxClass = mms[1] > 0 ? "positif" : "negatif";
    let sommeClass = mms[2] > 0 ? "positif" : "negatif";
    document.write("<tr> <td class='positif'>" + (index + 1) + "</td> <td class='" + nombreClass + "'>" + nombre + "</td> <td class='" + minClass + "'>" + mms[0] + "</td> <td class='" + maxClass + "'>" + mms[1] + "</td> <td class='" + sommeClass + "'>" + mms[2] + "</td> </tr>");
}