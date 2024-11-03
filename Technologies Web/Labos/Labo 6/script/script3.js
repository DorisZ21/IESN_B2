let grandActuel = 0;
let cadre = document.getElementById('cadre');
function modwith(x){
    cadre.children[grandActuel].style.with = 500 - x;
    cadre.children[x].style.with =  + x;

}
function clic(x){
    if(x != grandActuel){
       setTimeout(modwith(x,10),10);
    }
}
