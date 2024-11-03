let valeurActuelle = 2;

function majValeur(f){
    let val = document.getElementById('spanVal');
    if(f){
        valeurActuelle = f()
    }
    val.innerHTML = valeurActuelle;
    
}

function calcOppose(){
    majValeur(() => ( 0 - valeurActuelle));
}

function calcCarre(){
    majValeur(() => (valeurActuelle ** 2));
}

function factorielle(n){
    if(n === 0 || n === 1){
        return 1;
    }
    return n * factorielle(n - 1);
}

function calcFactorielle(){
    if(valeurActuelle > 0){
        majValeur(() => factorielle(valeurActuelle));
    }
    
}

function calcAjoute(x){
    majValeur(() => (valeurActuelle += x));
}

function calcMultiple(x){
    return () => {valeurActuelle *= x; majValeur()}
}

function effetBoutonFois(x){

    return () => {
        let btnMultiplie = document.getElementById('bMultiplie');
        btnMultiplie.innerText = `x${x}`;
        btnMultiplie.onclick = calcMultiple(x);
    }
}

function init(){
    let btnFact = document.getElementById('bFact');
    let btnRAZ = document.getElementById('bRAZ');

    majValeur();

    btnFact.addEventListener('click', () =>{
        calcFactorielle();
    });

    btnRAZ.addEventListener('click', () => {
        valeurActuelle = 0;
        majValeur();
    })

    document.getElementById("bDecremente10").onclick = () => calcAjoute(-10);
    document.getElementById("bDecremente1").onclick = () => calcAjoute(-1);
    document.getElementById("bIncremente1").onclick = () => calcAjoute(1);
    document.getElementById("bIncremente10").onclick = () => calcAjoute(10);

    document.getElementById("bMultiplie").onclick = calcMultiple(2);
    document.getElementById("bDeux").onclick = effetBoutonFois(2);
    document.getElementById("bCinq").onclick = effetBoutonFois(5);
    document.getElementById("bDix").onclick =  effetBoutonFois(10);
}


window.onload = init;