let nombres;
let a;
let b;
let c;
let d;

function obtention(){
    let iNombre = 0;
    do{
        nombres[iNombre] = prompt("Entrez un nombre :");
        iNombre++;
    }while(isFinite(nombres[iNombre]) && nombres[iNombre] != "");
}