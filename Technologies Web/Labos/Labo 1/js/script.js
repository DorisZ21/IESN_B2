let maintenant = new Date();
let h = maintenant.getHours();
let m = maintenant.getMinutes();
let dynMinuscule = true;

function changeDyn(txt){
    let cible = document.getElementById("dyna").innerHTML = txt;
}

function toggleDyn(){
    if(dynMinuscule){
        changeDyn("DYNAMIQUE");
        dynMinuscule = false;
    }else{
        changeDyn("dynamique");
        dynMinuscule = true;
    }
}